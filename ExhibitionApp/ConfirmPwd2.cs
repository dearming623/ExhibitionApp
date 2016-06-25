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
        public const int CAN_DISPOSE_APP = 0;
        public const int CAN_OPEN_CONFIG = 1;

        private int _action = CAN_DISPOSE_APP;

        private Setting2 _Setting = null;

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


            switch (_action)
            {
                case CAN_DISPOSE_APP:
                    SystemController.onExitApplication();
                    break;
                case CAN_OPEN_CONFIG:
                    OpenSetttingForm();
                    break;

                default:
                    break;
            }


            //if (onConfirmPwdEvent != null)
            //{
            //    onConfirmPwdEvent(sender, e);
            //}

        }
        private void OpenSetttingForm()
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



        public void setAcitionAfterConfirm(int type)
        {
            _action = type;
        }

        private void ConfirmPwd2_Load(object sender, EventArgs e)
        {
            pb_popup_softkeyboard.Focus();
        }
    }
}
