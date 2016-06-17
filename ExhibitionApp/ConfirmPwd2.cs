using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExhibitionApp
{
    public partial class ConfirmPwd2 : Form
    {
       

        public ConfirmPwd2()
        {
            InitializeComponent();
        }

        //public delegate void onConfirmPwdEventHandler(object sender, EventArgs e);
        //public event onConfirmPwdEventHandler onConfirmPwdEvent;

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string pwd = tb_pwd.Text.Trim();


            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("请输入用户密码!");
                tb_pwd.Focus();
                return;
            }

            if (!IsCurrentPwd(pwd))
            {
                MessageBox.Show("用户密码不正确，请重新输入!");
                tb_pwd.Focus();
                return;
            }

            SystemController.onExitApplication();

            //if (onConfirmPwdEvent != null)
            //{
            //    onConfirmPwdEvent(sender, e);
            //}

        }

      
        private bool IsCurrentPwd(string pwd)
        {
            return MyAppSetting.GetInstance().GetPassWordOfLogout() == pwd;
        }

        private void Softkeyboard_Click(object sender, EventArgs e)
        {

            if (SystemController.isShowingSoftInput())
            {
                SystemController.onCloseWindowSoftInput();
            }
            else
            {
                SystemController.onOpenWindowSoftInput();
            }

            tb_pwd.Focus();
            
        }
    }
}
