using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExhibitionApp
{
    public partial class ConfirmPwd : Form
    {
        public ConfirmPwd()
        {
            InitializeComponent();
        }

        public delegate void onConfirmPwdEventHandler(object sender, EventArgs e);
        public event onConfirmPwdEventHandler onConfirmPwdEvent;

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string pwd = tb_pwd.Text.Trim();
           

            if (!IsCurrentPwd(pwd))
            {
                MessageBox.Show("用户密码不正确，请重新输入!");
                tb_pwd.Focus();
                return;
            }


            if (onConfirmPwdEvent != null)
            {
                onConfirmPwdEvent(sender, e);
            }

        }

      
        private bool IsCurrentPwd(string pwd)
        {
            return true;
        }
    }
}
