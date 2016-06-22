namespace ExhibitionApp
{
    partial class ChangePwd2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePwd2));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_current_pwd = new System.Windows.Forms.TextBox();
            this.tb_new_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_confirm_new_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_popup_softkeyboard = new System.Windows.Forms.PictureBox();
            this.btn_confirm = new System.Windows.Forms.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_popup_softkeyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_confirm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前密码";
            // 
            // tb_current_pwd
            // 
            this.tb_current_pwd.Font = new System.Drawing.Font("SimHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_current_pwd.Location = new System.Drawing.Point(59, 69);
            this.tb_current_pwd.Name = "tb_current_pwd";
            this.tb_current_pwd.Size = new System.Drawing.Size(375, 41);
            this.tb_current_pwd.TabIndex = 1;
            this.tb_current_pwd.UseSystemPasswordChar = true;
            // 
            // tb_new_pwd
            // 
            this.tb_new_pwd.Font = new System.Drawing.Font("SimHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_new_pwd.Location = new System.Drawing.Point(59, 176);
            this.tb_new_pwd.Name = "tb_new_pwd";
            this.tb_new_pwd.Size = new System.Drawing.Size(375, 41);
            this.tb_new_pwd.TabIndex = 3;
            this.tb_new_pwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码";
            // 
            // tb_confirm_new_pwd
            // 
            this.tb_confirm_new_pwd.Font = new System.Drawing.Font("SimHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_confirm_new_pwd.Location = new System.Drawing.Point(59, 285);
            this.tb_confirm_new_pwd.Name = "tb_confirm_new_pwd";
            this.tb_confirm_new_pwd.Size = new System.Drawing.Size(375, 41);
            this.tb_confirm_new_pwd.TabIndex = 5;
            this.tb_confirm_new_pwd.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认新密码";
            // 
            // pb_popup_softkeyboard
            // 
            this.pb_popup_softkeyboard.BackColor = System.Drawing.Color.Transparent;
            this.pb_popup_softkeyboard.Image = global::ExhibitionApp.Properties.Resources.keyboard_48px;
            this.pb_popup_softkeyboard.Location = new System.Drawing.Point(370, 353);
            this.pb_popup_softkeyboard.Name = "pb_popup_softkeyboard";
            this.pb_popup_softkeyboard.Size = new System.Drawing.Size(64, 47);
            this.pb_popup_softkeyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_popup_softkeyboard.TabIndex = 28;
            this.pb_popup_softkeyboard.TabStop = false;
            this.pb_popup_softkeyboard.Click += new System.EventHandler(this.Softkeyboard_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_confirm.DownImage = global::ExhibitionApp.Properties.Resources.okDown;
            this.btn_confirm.HoverImage = null;
            this.btn_confirm.Location = new System.Drawing.Point(59, 353);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.NormalImage = global::ExhibitionApp.Properties.Resources.okNormal;
            this.btn_confirm.Size = new System.Drawing.Size(166, 56);
            this.btn_confirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_confirm.TabIndex = 29;
            this.btn_confirm.TabStop = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // ChangePwd2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExhibitionApp.Properties.Resources.menu_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 451);
            this.ControlBox = false;
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.pb_popup_softkeyboard);
            this.Controls.Add(this.tb_confirm_new_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_new_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_current_pwd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePwd2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.pb_popup_softkeyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_confirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_current_pwd;
        private System.Windows.Forms.TextBox tb_new_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_confirm_new_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_popup_softkeyboard;
        private System.Windows.Forms.ImageButton btn_confirm;
    }
}