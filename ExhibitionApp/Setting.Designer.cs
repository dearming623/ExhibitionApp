namespace ExhibitionApp
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_slide_path = new System.Windows.Forms.TextBox();
            this.tb_video_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save_slide_path = new System.Windows.Forms.Button();
            this.btn_save_video_path = new System.Windows.Forms.Button();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownSec = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_change_pwd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "将于每天的";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "幻灯图片文件路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "视频文件路径";
            // 
            // tb_slide_path
            // 
            this.tb_slide_path.Location = new System.Drawing.Point(79, 76);
            this.tb_slide_path.Name = "tb_slide_path";
            this.tb_slide_path.Size = new System.Drawing.Size(453, 21);
            this.tb_slide_path.TabIndex = 3;
            // 
            // tb_video_path
            // 
            this.tb_video_path.Location = new System.Drawing.Point(79, 157);
            this.tb_video_path.Name = "tb_video_path";
            this.tb_video_path.Size = new System.Drawing.Size(453, 21);
            this.tb_video_path.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "文件管理:";
            // 
            // btn_save_slide_path
            // 
            this.btn_save_slide_path.Location = new System.Drawing.Point(79, 104);
            this.btn_save_slide_path.Name = "btn_save_slide_path";
            this.btn_save_slide_path.Size = new System.Drawing.Size(75, 23);
            this.btn_save_slide_path.TabIndex = 6;
            this.btn_save_slide_path.Text = "更改目录";
            this.btn_save_slide_path.UseVisualStyleBackColor = true;
            this.btn_save_slide_path.Click += new System.EventHandler(this.btn_save_slide_path_Click);
            // 
            // btn_save_video_path
            // 
            this.btn_save_video_path.Location = new System.Drawing.Point(79, 184);
            this.btn_save_video_path.Name = "btn_save_video_path";
            this.btn_save_video_path.Size = new System.Drawing.Size(75, 23);
            this.btn_save_video_path.TabIndex = 7;
            this.btn_save_video_path.Text = "更改目录";
            this.btn_save_video_path.UseVisualStyleBackColor = true;
            this.btn_save_video_path.Click += new System.EventHandler(this.btn_save_video_path_Click);
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(141, 14);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(45, 21);
            this.numericUpDownMin.TabIndex = 8;
            this.numericUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMin.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "时";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "分";
            // 
            // numericUpDownSec
            // 
            this.numericUpDownSec.Location = new System.Drawing.Point(212, 14);
            this.numericUpDownSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSec.Name = "numericUpDownSec";
            this.numericUpDownSec.Size = new System.Drawing.Size(45, 21);
            this.numericUpDownSec.TabIndex = 10;
            this.numericUpDownSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSec.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "关机";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "定时任务:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.del,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(77, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(480, 181);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "链接设置:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "增加条目";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_change_pwd
            // 
            this.btn_change_pwd.Location = new System.Drawing.Point(76, 481);
            this.btn_change_pwd.Name = "btn_change_pwd";
            this.btn_change_pwd.Size = new System.Drawing.Size(75, 23);
            this.btn_change_pwd.TabIndex = 17;
            this.btn_change_pwd.Text = "修改密码";
            this.btn_change_pwd.UseVisualStyleBackColor = true;
            this.btn_change_pwd.Click += new System.EventHandler(this.btn_change_pwd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "安全设置:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "为了您的程序安全, 请定期修改密码";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "按钮名称";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "link";
            this.Column2.HeaderText = "对应触发连接";
            this.Column2.Name = "Column2";
            this.Column2.Width = 280;
            // 
            // del
            // 
            this.del.HeaderText = "操作";
            this.del.Name = "del";
            this.del.Text = "删除";
            this.del.UseColumnTextForButtonValue = true;
            this.del.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Width = 20;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 531);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_change_pwd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownSec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.btn_save_video_path);
            this.Controls.Add(this.btn_save_slide_path);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_video_path);
            this.Controls.Add(this.tb_slide_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_slide_path;
        private System.Windows.Forms.TextBox tb_video_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save_slide_path;
        private System.Windows.Forms.Button btn_save_video_path;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_change_pwd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}