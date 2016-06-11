using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ExhibitionApp
{
    class SystemController
    {

        // 导入的方法必须是static extern的，并且没有方法体。调用这些方法就相当于调用Windows API。   
        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
        ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int flg, int rea);

        

        // 这个结构体将会传递给API。使用StructLayout   
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        // 以下定义了在调用WinAPI时需要的常数。这些常数通常可以从Platform SDK的包含文件（头文件）中找到   
        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        internal const int EWX_SHUTDOWN = 0x00000001;
        private static Process onScreenKeyboardProc;

        //internal const int EWX_LOGOFF = 0x00000000;   
        //internal const int EWX_REBOOT = 0x00000002;   
        //internal const int EWX_FORCE = 0x00000004;   
        //internal const int EWX_POWEROFF = 0x00000008;   
        //internal const int EWX_FORCEIFHUNG = 0x00000010;   


        // 通过调用WinAPI实现关机，主要代码再最后一行ExitWindowsEx，这调用了同名的WinAPI，正好是关机用的。   
        private static void DoExitWin(int flg)
        {
            bool ok;
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid);
            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);
            ok = ExitWindowsEx(flg, 0);
        }

        public static void onShutDown(){
            DoExitWin(EWX_SHUTDOWN);
        }


        public static void onOpenWindowSoftInput()
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string onScreenKeyboardPath = System.IO.Path.Combine(progFiles, "TabTip.exe");
            onScreenKeyboardProc = System.Diagnostics.Process.Start(onScreenKeyboardPath);
        }

        public static void onCloseWindowSoftInput()
        {
            //Kill all on screen keyboards
            Process[] oskProcessArray = Process.GetProcessesByName("TabTip");
            foreach (Process onscreenProcess in oskProcessArray)
            {
                onscreenProcess.Kill();
            }
        }

        public static bool isShowingSoftInput()
        {
            Process[] oskProcessArray = Process.GetProcessesByName("TabTip");
            return oskProcessArray.Length > 0 ? true : false;
           
        }

        public static void onExitApplication()
        {
            if (SystemController.isShowingSoftInput())
            {
                SystemController.onCloseWindowSoftInput();
            }

            Application.Exit();
        }
    }
}
