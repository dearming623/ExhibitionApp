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
            numericUpDownMin.Value =  MyAppSetting.GetInstance().ShutDownTime.Minute;
            numericUpDownSec.Value = MyAppSetting.GetInstance().ShutDownTime.Second;

            numericUpDownMin.ValueChanged += numericUpDown_ValueChanged;
            numericUpDownSec.ValueChanged += numericUpDown_ValueChanged;

            string path_slide = MyAppSetting.GetInstance().GetPathOfSlide();
            string path_video = MyAppSetting.GetInstance().GetPathOfVideo();

            if (string.IsNullOrEmpty(path_slide))
            {
                tb_slide_path.Text =  Environment.CurrentDirectory + "\\Pictures";
            }
            else
            {
                tb_slide_path.Text = path_slide;
            }

            if (string.IsNullOrEmpty(path_video))
            {
                tb_video_path.Text = Environment.CurrentDirectory + "\\Videos";
            }else
            {
                tb_video_path.Text = path_video;
            }

            dataGridView1.DataSource = MyAppSetting.GetInstance().GetCompanyLinks2();
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

        private void btn_save_slide_path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_slide_path.Text = folderBrowserDialog1.SelectedPath;
                MyAppSetting.GetInstance().SavePathOfSlide(folderBrowserDialog1.SelectedPath);
            }
           
        }

        private void btn_save_video_path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_video_path.Text = folderBrowserDialog1.SelectedPath;
                MyAppSetting.GetInstance().SavePathOfVideo(folderBrowserDialog1.SelectedPath);
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MyAppSetting.GetInstance().SaveShutDownTime(
                Convert.ToInt32(numericUpDownMin.Value),
                Convert.ToInt32( numericUpDownSec.Value));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "del") 
            {
                string name = this.dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();

                int affected = 0;
                string err = "";
                try
                {
                    affected = MyAppSetting.GetInstance().DeleteLink(name);
                }
                catch (Exception ex)
                {
                    err = ex.ToString();
                }

                if (affected <= 0)
                {
                    MessageBox.Show("更新失败!\n" + err);
                }else
                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
               

               
            }
        }
    }
}
