using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
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

        ChromiumWebBrowser wb = null;

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


        class MyLifeSpanHandler : ILifeSpanHandler
        {
        
            public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
            {
                // Preserve new windows to be opened and load all popup urls in the same browser view
                browserControl.Load(targetUrl);

                newBrowser = browserControl;
                //
                return true;
            }

            public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser)
            {
                //throw new NotImplementedException();
            }

            public bool DoClose(IWebBrowser browserControl, IBrowser browser)
            {
                //throw new NotImplementedException();
                return true;
            }

            public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser)
            {
                //throw new NotImplementedException();
            }
        }

         

        private List<MyLink> lst = null;
        private int loc_x = 180;
        private int loc_y = 10;


        private void FormBrowser_Load(object sender, EventArgs e)
        {

            // loadData();
            lst = MyAppSetting.GetInstance().GetCompanyLinks();

            loc_x = 10;
            if (lst != null && lst.Count >0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    //Button btn = new Button();
                    //btn.BackgroundImage = ExhibitionApp.Properties.Resources.Navigation_Button2;
                    //btn.AutoSize = true;
                    
                    ImageButton btn_item = new ImageButton();
                    btn_item.setFlagForNavigation(true);
                    btn_item.Size = new Size(160, 80);
                    btn_item.NormalImage = ExhibitionApp.Properties.Resources.Navigation_Button21;
                    btn_item.Click += Btn_Click;
                    btn_item.Text = lst[i].websiteName;
                    btn_item.Tag = lst[i];

                    btn_item.Location = new Point(loc_x,loc_y);

                    panel1.Controls.Add(btn_item);

                    loc_x += btn_item.Width ;

                    if (i == 0)
                    {
                        wb = new ChromiumWebBrowser(lst[i].url);
                        wb.Dock = DockStyle.Fill;

                        btn_item.NormalImage = ExhibitionApp.Properties.Resources.Navigation_Button11;
                        this.panel2.Controls.Clear();
                        this.panel2.Controls.Add(wb);
                    }
                }
                
            }
        }


        private void Btn_Click(object sender, EventArgs e)
        {

            foreach (var item in  panel1.Controls)
            {
                if (item.GetType() == typeof(ImageButton))
                {
                    ImageButton render = (ImageButton)item;

                  
                    if (render.Name == "btn_menu" || 
                        render.Name == "btn_go_forward" || 
                        render.Name == "btn_go_back")
                        continue;
                    
                     render.NormalImage = ExhibitionApp.Properties.Resources.Navigation_Button21;
                }
                
            }

            if (!CefSharp.Cef.IsInitialized)
            {
                CefSharp.Cef.Initialize();
            }

            ImageButton btn = (ImageButton)sender;
            MyLink link = (MyLink)btn.Tag;

            wb = new ChromiumWebBrowser(link.url);
            wb.Dock = DockStyle.Fill;

            wb.LifeSpanHandler = new MyLifeSpanHandler();
            btn.NormalImage = ExhibitionApp.Properties.Resources.Navigation_Button11;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(wb);
        }

        private void onClickGoBack(object sender, EventArgs e)
        {
            if (wb!= null && wb.CanGoBack)
            {
                wb.GetBrowser().GoBack();
            }
        }

        private void onClickGoForward(object sender, EventArgs e)
        {
            if (wb != null && wb.CanGoForward)
            {
                wb.GetBrowser().GoForward();
            }
        }
    }
}
