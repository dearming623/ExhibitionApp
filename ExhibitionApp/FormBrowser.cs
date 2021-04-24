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
         
        private List<MyLink> links = null;
        private int loc_x = 180;
        private int loc_y = 10;

        private ChromiumWebBrowser displayBrowser = null;
        private Dictionary<string, ChromiumWebBrowser> browsers = new Dictionary<string, ChromiumWebBrowser>();
        private CefSettings cefSettings = null;
        private void FormBrowser_Load(object sender, EventArgs e)
        {
            cefSettings = new CefSettings();
            //设置浏览器语言，默认en-us
            cefSettings.Locale = "zh-cn";
            //设置userAgent
            cefSettings.UserAgent = "Mozilla/5.0(Windows NT 6.1; WOW64) AppleWebKit/537.36(KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
            // settings.LegacyJavascriptBindingEnabled = true;
            if (!Cef.IsInitialized)
            {
                Cef.Initialize(cefSettings);
            }

            // loadData();
            links = MyAppSetting.GetInstance().GetCompanyLinks();

            loc_x = 10;
            if (links != null && links.Count > 0)
            {
                for (int i = 0; i < links.Count; i++)
                {
                    //Button btn = new Button();
                    //btn.BackgroundImage = ExhibitionApp.Properties.Resources.Navigation_Button2;
                    //btn.AutoSize = true;

                    string key = links[i].websiteName;
                    string url = links[i].url;

                    ImageButton tabButton = new ImageButton();
                    tabButton.Location = new Point(loc_x, loc_y);
                    tabButton.setFlagForNavigation(true);
                    tabButton.Size = new Size(160, 80);
                    tabButton.NormalImage = ExhibitionApp.Properties.Resources.Navigation_Button21;
                    tabButton.Click += Btn_Click;
                    tabButton.Text = links[i].websiteName;
                    tabButton.Tag = links[i];
                     
                    panel1.Controls.Add(tabButton);

                    loc_x += tabButton.Width ;

                    ChromiumWebBrowser browser = new ChromiumWebBrowser(url); 
                    browser.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true;
                    browser.LifeSpanHandler = new LifeSpanHandler();
                    browsers.Add(key, browser);

                    if (i == 0)
                    {
                        tabButton.NormalImage = ExhibitionApp.Properties.Resources.Navigation_Button11;
                        displayBrowser = browser;
                        BringToMain(displayBrowser);

                    }
                }
                  
            }

            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls)
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

            ImageButton tabButton = (ImageButton)sender;
            tabButton.NormalImage = ExhibitionApp.Properties.Resources.Navigation_Button11;

            MyLink link = (MyLink)tabButton.Tag;

            displayBrowser = browsers[link.websiteName];

            BringToMain(displayBrowser);
            
        }

        private void BringToMain(ChromiumWebBrowser displayBrowser)
        {
            displayBrowser.Dock = DockStyle.Fill; 
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(displayBrowser);
        }

        private void onClickGoBack(object sender, EventArgs e)
        {
            if (displayBrowser!= null && displayBrowser.CanGoBack)
            {
                displayBrowser.GetBrowser().GoBack();
            }
        }

        private void onClickGoForward(object sender, EventArgs e)
        {
            if (displayBrowser != null && displayBrowser.CanGoForward)
            {
                displayBrowser.GetBrowser().GoForward();
            }
        }

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
    }
}
