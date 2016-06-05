using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExhibitionApp
{
    public partial class FormBrowser : Form
    {
        public FormBrowser()
        {
            InitializeComponent();

           
        }

        public delegate void onScreenClickEventHandler(object sender, EventArgs e);
        public event onScreenClickEventHandler onScreenClickEvent;

        private void menu_option_Click(object sender, EventArgs e)
        {
            onScreenClick();
        }

        private void onScreenClick()
        {
            if (onScreenClickEvent != null)
            {
                onScreenClickEvent(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CefSharp.Cef.IsInitialized)
            {
                //必须进行初始化，否则就出来页面啦。
                CefSharp.Cef.Initialize();
            }
           

            //实例化控件
            ChromiumWebBrowser wb = new ChromiumWebBrowser("http://www.baidu.com");
            //设置停靠方式
            wb.Dock = DockStyle.Fill;

            //加入到当前窗体中
            //this.Controls.Add(wb);
            this.panel2.Controls.Add(wb);
        }

        private List<MyLink> lst = null;
        private int loc_x = 180;
        private int loc_y = 10;

        private void FormBrowser_Load(object sender, EventArgs e)
        {

            loadData();

            loc_x = 180;
            if (lst != null && lst.Count >0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    Button btn = new Button();
                    btn.Click += Btn_Click;
                    btn.Text = lst[i].websiteName;
                    btn.Tag = lst[i];

                    btn.Location = new Point(loc_x,loc_y);

                    panel1.Controls.Add(btn);

                    loc_x += btn.Width;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (!CefSharp.Cef.IsInitialized)
            {
                CefSharp.Cef.Initialize();
            }

            Button btn = (Button)sender;
            MyLink link = (MyLink)btn.Tag;

            ChromiumWebBrowser wb = new ChromiumWebBrowser(link.url);
            wb.Dock = DockStyle.Fill;

            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(wb);
        }

        private void loadData()
        {
            if (lst == null)
            {
                lst = new List<MyLink>();
            }

            lst.Clear();

            for (int i = 0; i < 5; i++)
            {
                MyLink link = new MyLink();
                link.websiteName = " website -> " + i;
                link.url = "www.baidu.com";

                lst.Add(link);
            }
           
        }
    }
}
