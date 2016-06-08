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
            numericUpDownHour.Value =  MyAppSetting.GetInstance().ShutDownTime.Hour;
            numericUpDownMin.Value = MyAppSetting.GetInstance().ShutDownTime.Minute;

            numericUpDownHour.ValueChanged += numericUpDown_ValueChanged;
            numericUpDownMin.ValueChanged += numericUpDown_ValueChanged;

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
                Convert.ToInt32(numericUpDownHour.Value),
                Convert.ToInt32( numericUpDownMin.Value));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            tb_btn_name.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            tb_link.Text = dataGridView1.Rows[e.RowIndex].Cells["link"].Value.ToString();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "del")
            {
                string name = this.dataGridView1.CurrentRow.Cells["name"].Value.ToString();

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
                }
                else if(affected > 0)
                {
                    tb_btn_name.Text = "";
                    tb_link.Text = "";
                   this.dataGridView1.Rows.RemoveAt(e.RowIndex);

                }

            }


          
        }

        private void btn_add_new_link_Click(object sender, EventArgs e)
        {
            if (tb_btn_name.Text.Trim() == "" || tb_link.Text.Trim() == "")
            {
                MessageBox.Show("插入数据不能为空，请按要求插入数据!");
                return;
            }

            int affected = 0;

            try
            {
                affected = SQLiteDBHelper.ExecuteSql("INSERT OR REPLACE INTO t_company_link ( name,link) VALUES ( '" + tb_btn_name.Text + "', '" + tb_link.Text + "')");

            }
            catch (Exception ex)
            {
            }
           
            if (affected ==0 )
            {
                MessageBox.Show("添加失败!");
            }
            else if (affected > 0)
            {
                MessageBox.Show("添加成功");
            }

            dataGridView1.DataSource = MyAppSetting.GetInstance().GetCompanyLinks2();
        }

        private void btn_del_record_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_save_record_Click(object sender, EventArgs e)
        {
            if (tb_btn_name.Text.Trim() == "" || tb_link.Text.Trim() == "")
            {
                MessageBox.Show("文本框不能为空!");
                return;
            }

            int affected = 0;

            try
            {
                affected = SQLiteDBHelper.ExecuteSql("update t_company_link set name = '" + tb_btn_name.Text + "',link =  '" + tb_link.Text + "' where name = '" + tb_btn_name.Text + "' "); 

            }
            catch (Exception ex)
            {
            }

            if (affected == 0)
            {
                MessageBox.Show("更新失败!");
            }
            else if (affected > 0)
            {
                MessageBox.Show("更新成功");
            }

            dataGridView1.DataSource = MyAppSetting.GetInstance().GetCompanyLinks2();
        }
    }
}
