using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExhibitionApp
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }


        private ChangePwd _changePwd = null;

        private void Setting_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_change_pwd_Click(object sender, EventArgs e)
        {
            if (_changePwd != null)
            {
                _changePwd.Activate();
            }
            else
            {
                _changePwd = new ChangePwd();
                _changePwd.Show();
                _changePwd.FormClosed += FormChangePwd_Closed;
            }
        }

        private void FormChangePwd_Closed(object sender, EventArgs e)
        {
            _changePwd = null;
        }
    }
}
