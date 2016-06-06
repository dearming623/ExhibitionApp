using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExhibitionApp
{
    public partial class ChangePwd : Form
    {
        public ChangePwd()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string old_pwd = tb_current_pwd.Text.Trim();
            string new_pwd = tb_new_pwd.Text.Trim();
            string confirm_new_pwd = tb_confirm_new_pwd.Text.Trim();


            if (!IsCurrentPwd(old_pwd))
            {
                MessageBox.Show("当前用户密码不正确，请重新输入!");
                tb_current_pwd.Focus();
                return;
            }

            if (old_pwd == new_pwd)
            {
                MessageBox.Show("新密码不能与旧密码相同，请重新输入!");
                tb_new_pwd.Focus();
                return;
            }

            if (new_pwd != confirm_new_pwd)
            {
                MessageBox.Show("新密码与重新确认密码不相同，请重新输入!");
                tb_new_pwd.Focus();
                return;
            }

            SavePwd(new_pwd);

            this.Close();

        }

        private void SavePwd(string new_pwd)
        {
            MyAppSetting.GetInstance().SavePwd(new_pwd);
        }

        private bool IsCurrentPwd(string pwd)
        {
            return MyAppSetting.GetInstance().GetPassWordOfLogout() == pwd;
        }
    }
}
