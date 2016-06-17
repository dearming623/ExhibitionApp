using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExhibitionApp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public const int OPTION_PLAY_PIC = 0;
        public const int OPTION_PLAY_VIDEO = 1;
        public const int OPTION_BROWSER = 2;
        public const int OPTION_SETTING = 3;
        public const int OPTION_EXIT_SYSTEM = 4;

        public delegate void onOptionClickEventHandler(int option);
        public event onOptionClickEventHandler onOptionClickEvent;


        private ConfirmPwd2 _ConfirmPwd = null;
        private Setting2 _Setting = null;
        private FormBrowser _FormBrowser = null;
        private FormPlayPicture _FormPlayPicture = null;
        private FormPlayVideo _FormPlayVideo = null;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit_system_Click(object sender, EventArgs e)
        {

            if (_ConfirmPwd != null)
            {
                _ConfirmPwd.Activate();
            }
            else
            {
                _ConfirmPwd = new ConfirmPwd2();
               
                _ConfirmPwd.FormClosed += FormConfirmPwd_Closed;
                //_ConfirmPwd.onConfirmPwdEvent += _ConfirmPwd_onConfirmPwdEvent;

                _ConfirmPwd.Show();
            }

            this.Close();
        }

        private void _ConfirmPwd_onConfirmPwdEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormConfirmPwd_Closed(object sender, EventArgs e)
        {
            _ConfirmPwd = null;
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            if (_Setting != null)
            {
                _Setting.Activate();
            }
            else
            {
                _Setting = new Setting2();
                _Setting.FormClosed += Form_Setting_Closed;
                _Setting.Show();
            }

            this.Close();
        }

        private void Form_Setting_Closed(object sender, FormClosedEventArgs e)
        {
            _Setting = null;
        }

        private void btn_play_video_Click(object sender, EventArgs e)
        {
            //if (_FormPlayVideo != null)
            //{
            //    _FormPlayVideo.Activate();
            //}
            //else
            //{
            //    _FormPlayVideo = new FormPlayVideo();
            //    _FormPlayVideo.FormClosed += Form_FormPlayVideo_Closed;
            //    _FormPlayVideo.Show();
            //}

            //this.Close();

            if (onOptionClickEvent != null)
            {
                onOptionClickEvent(OPTION_PLAY_VIDEO);
            }
        }

        private void Form_FormPlayVideo_Closed(object sender, FormClosedEventArgs e)
        {
            _FormPlayVideo = null;
        }

        private void btn_web_browser_Click(object sender, EventArgs e)
        {
            //if (_FormBrowser != null)
            //{
            //    _FormBrowser.Activate();
            //}
            //else
            //{
            //    _FormBrowser = new FormBrowser();
            //    _FormBrowser.FormClosed += Form_FormBrowser_Closed;
            //    _FormBrowser.Show();
            //}

            //this.Close();

            if (onOptionClickEvent != null)
            {
                onOptionClickEvent(OPTION_BROWSER);
            }
        }

        private void Form_FormBrowser_Closed(object sender, FormClosedEventArgs e)
        {
            _FormBrowser = null;
        }

        private void btn_play_pic_Click(object sender, EventArgs e)
        {
            //if (_FormPlayPicture != null)
            //{
            //    _FormPlayPicture.Activate();
            //}
            //else
            //{
            //    _FormPlayPicture = new FormPlayPicture();
            //    _FormPlayPicture.FormClosed += Form_FormPlayPicture_Closed;
            //    _FormPlayPicture.Show();
            //}

            //this.Close();

            if (onOptionClickEvent != null)
            {
                onOptionClickEvent(OPTION_PLAY_PIC);
            }
        }

        private void Form_FormPlayPicture_Closed(object sender, FormClosedEventArgs e)
        {
            _FormPlayPicture = null;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
