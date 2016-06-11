namespace ExhibitionApp
{
    partial class ChangePwd
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
            this.tb_current_pwd = new System.Windows.Forms.TextBox();
            this.tb_new_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_confirm_new_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.pb_popup_softkeyboard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_popup_softkeyboard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前密码：";
            // 
            // tb_current_pwd
            // 
            this.tb_current_pwd.Location = new System.Drawing.Point(99, 18);
            this.tb_current_pwd.Name = "tb_current_pwd";
            this.tb_current_pwd.Size = new System.Drawing.Size(167, 21);
            this.tb_current_pwd.TabIndex = 1;
            this.tb_current_pwd.UseSystemPasswordChar = true;
            // 
            // tb_new_pwd
            // 
            this.tb_new_pwd.Location = new System.Drawing.Point(99, 45);
            this.tb_new_pwd.Name = "tb_new_pwd";
            this.tb_new_pwd.Size = new System.Drawing.Size(167, 21);
            this.tb_new_pwd.TabIndex = 3;
            this.tb_new_pwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码：";
            // 
            // tb_confirm_new_pwd
            // 
            this.tb_confirm_new_pwd.Location = new System.Drawing.Point(99, 72);
            this.tb_confirm_new_pwd.Name = "tb_confirm_new_pwd";
            this.tb_confirm_new_pwd.Size = new System.Drawing.Size(167, 21);
            this.tb_confirm_new_pwd.TabIndex = 5;
            this.tb_confirm_new_pwd.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认新密码：";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(99, 108);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "确认";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // pb_popup_softkeyboard
            // 
            this.pb_popup_softkeyboard.Image = global::ExhibitionApp.Properties.Resources.keyboard_32px;
            this.pb_popup_softkeyboard.Location = new System.Drawing.Point(224, 100);
            this.pb_popup_softkeyboard.Name = "pb_popup_softkeyboard";
            this.pb_popup_softkeyboard.Size = new System.Drawing.Size(42, 31);
            this.pb_popup_softkeyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_popup_softkeyboard.TabIndex = 28;
            this.pb_popup_softkeyboard.TabStop = false;
            this.pb_popup_softkeyboard.Click += new System.EventHandler(this.Softkeyboard_Click);
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.pb_popup_softkeyboard);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tb_confirm_new_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_new_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_current_pwd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.pb_popup_softkeyboard)).EndInit();
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
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.PictureBox pb_popup_softkeyboard;
    }
}