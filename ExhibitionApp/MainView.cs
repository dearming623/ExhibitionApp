using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace ExhibitionApp
{
    class MainView
    {
        private int current_option = -1;
        private FormMenu menu = null;

        private FormBrowser _FormBrowser = null;
        private FormPlayPicture _FormPlayPicture = null;
        // private FormPlayVideo _FormPlayVideo = null;
        private FormVideoSelection _FormPlayVideo = null;

        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        public  MainView()
        {

            MyAppSetting.GetInstance().Load();

            //OpenMenuView();

            //CloseMenuView();


            Menu_onOptionClickEvent(MyAppSetting.GetInstance().GetStartRun());

            //OpenPlayPicView();

            //current_option = FormMenu.OPTION_PLAY_PIC;


            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            timer1.Enabled = true;
   
        }


        private void OpenMenuView()
        {
            if (menu != null)
            {

                //  menu.Activate();
                menu.Close();
            }
            else
            {
                menu = new FormMenu();
                menu.FormClosed += Menu_FormClosed;
                menu.onOptionClickEvent += Menu_onOptionClickEvent;
                menu.Show();
            }
        }

        private void CloseCurrentView(int option)
        {
            if (option >= 0)
            {
                switch (option)
                {
                    case FormMenu.OPTION_PLAY_PIC:
                        ClosePlayPicView();
                        break;
                    case FormMenu.OPTION_PLAY_VIDEO:
                        ClosePlayVideoView();
                        break;
                    case FormMenu.OPTION_BROWSER:
                        CloseBrowser();
                        break;
                    case FormMenu.OPTION_SETTING:
                        //OpenSetting();
                        break;
                }
            }
        }

        private void Menu_onOptionClickEvent(int option)
        {
            CloseMenuView();

            CloseCurrentView(current_option);

            current_option = option;

            switch (option)
            {
                case FormMenu.OPTION_PLAY_PIC:
                    OpenPlayPicView();
                    break;
                case FormMenu.OPTION_PLAY_VIDEO:
                    OpenPlayVideoView();
                    break;
                case FormMenu.OPTION_BROWSER:
                    OpenBrowser();
                    break;
                case FormMenu.OPTION_SETTING:
                    //OpenSetting();
                    break;

                default:

                    break;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu = null;
        }

        private void CloseMenuView()
        {
            if (menu != null)
            {
                menu.Close();
                //menu.Hide();
            }
        }

        private void OpenPlayPicView()
        {
            if (_FormPlayPicture != null)
            {
                _FormPlayPicture.Activate();
            }
            else
            {
                _FormPlayPicture = new FormPlayPicture();
                _FormPlayPicture.FormClosed += Form_FormPlayPicture_Closed;
                _FormPlayPicture.onScreenClickEvent += Func_Screen_Clicked;
                _FormPlayPicture.Show();
            }

        }

        private void ClosePlayPicView()
        {
            if (_FormPlayPicture != null)
            {
                _FormPlayPicture.Close();
            }
        }

        private void Form_FormPlayPicture_Closed(object sender, FormClosedEventArgs e)
        {
            _FormPlayPicture = null;
        }


        private void OpenBrowser()
        {
            if (_FormBrowser != null)
            {
                _FormBrowser.Activate();
            }
            else
            {
                _FormBrowser = new FormBrowser();
                _FormBrowser.FormClosed += Form_FormBrowser_Closed;
                _FormBrowser.onScreenClickEvent += Func_Screen_Clicked;
                _FormBrowser.Show();
            }
        }

        private void CloseBrowser()
        {
            if (_FormBrowser != null)
            {
                _FormBrowser.Close();
            }
        }

        private void Form_FormBrowser_Closed(object sender, FormClosedEventArgs e)
        {
            _FormBrowser = null;
        }

        private void OpenPlayVideoView()
        {
            if (_FormPlayVideo != null)
            {
                _FormPlayVideo.Activate();
            }
            else
            {
                _FormPlayVideo = new FormVideoSelection();
                _FormPlayVideo.FormClosed += Form_FormPlayVideo_Closed;
                _FormPlayVideo.onScreenClickEvent += Func_Screen_Clicked;
                _FormPlayVideo.Show();
            }
        }

        private void ClosePlayVideoView()
        {
            if (_FormPlayVideo != null)
            {
                _FormPlayVideo.Close();
            }
        }

        private void Form_FormPlayVideo_Closed(object sender, FormClosedEventArgs e)
        {
            _FormPlayVideo = null;
        }

        private void Func_Screen_Clicked(object sender, EventArgs e)
        {
            OpenMenuView();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("DateTime.Now.Hour ==" + DateTime.Now.Hour + " DateTime.Now.Minute = " + DateTime.Now.Minute + " DateTime.Now.second ==" + DateTime.Now.Second);

            if (DateTime.Now.Hour == MyAppSetting.GetInstance().ShutDownTime.Hour &&
                DateTime.Now.Minute == MyAppSetting.GetInstance().ShutDownTime.Minute)
            {

                timer1.Enabled = false;

                SystemController.onShutDown();
                //MessageBox.Show("测试，你已经关机");
            }
        }
    }
}
