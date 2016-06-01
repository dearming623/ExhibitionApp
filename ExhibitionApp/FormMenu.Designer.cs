namespace ExhibitionApp
{
    partial class FormMenu
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
            this.btn_play_pic = new System.Windows.Forms.Button();
            this.btn_web_browser = new System.Windows.Forms.Button();
            this.btn_play_video = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit_system = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_play_pic
            // 
            this.btn_play_pic.Location = new System.Drawing.Point(45, 35);
            this.btn_play_pic.Name = "btn_play_pic";
            this.btn_play_pic.Size = new System.Drawing.Size(136, 87);
            this.btn_play_pic.TabIndex = 0;
            this.btn_play_pic.Text = "图片浏览";
            this.btn_play_pic.UseVisualStyleBackColor = true;
            this.btn_play_pic.Click += new System.EventHandler(this.btn_play_pic_Click);
            // 
            // btn_web_browser
            // 
            this.btn_web_browser.Location = new System.Drawing.Point(218, 35);
            this.btn_web_browser.Name = "btn_web_browser";
            this.btn_web_browser.Size = new System.Drawing.Size(136, 87);
            this.btn_web_browser.TabIndex = 1;
            this.btn_web_browser.Text = "网页浏览";
            this.btn_web_browser.UseVisualStyleBackColor = true;
            this.btn_web_browser.Click += new System.EventHandler(this.btn_web_browser_Click);
            // 
            // btn_play_video
            // 
            this.btn_play_video.Location = new System.Drawing.Point(45, 161);
            this.btn_play_video.Name = "btn_play_video";
            this.btn_play_video.Size = new System.Drawing.Size(136, 87);
            this.btn_play_video.TabIndex = 2;
            this.btn_play_video.Text = "视频浏览";
            this.btn_play_video.UseVisualStyleBackColor = true;
            this.btn_play_video.Click += new System.EventHandler(this.btn_play_video_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(218, 161);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(136, 87);
            this.btn_setting.TabIndex = 3;
            this.btn_setting.Text = "选项设置";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(218, 294);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(136, 87);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit_system
            // 
            this.btn_exit_system.Location = new System.Drawing.Point(45, 294);
            this.btn_exit_system.Name = "btn_exit_system";
            this.btn_exit_system.Size = new System.Drawing.Size(136, 87);
            this.btn_exit_system.TabIndex = 5;
            this.btn_exit_system.Text = "退出系统";
            this.btn_exit_system.UseVisualStyleBackColor = true;
            this.btn_exit_system.Click += new System.EventHandler(this.btn_exit_system_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit_system);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_play_video);
            this.Controls.Add(this.btn_web_browser);
            this.Controls.Add(this.btn_play_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_play_pic;
        private System.Windows.Forms.Button btn_web_browser;
        private System.Windows.Forms.Button btn_play_video;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit_system;
    }
}

