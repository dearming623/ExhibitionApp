namespace ExhibitionApp
{
    partial class ConfirmPwd
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
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.pb_popup_softkeyboard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_popup_softkeyboard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入密码：";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(81, 18);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(167, 21);
            this.tb_pwd.TabIndex = 1;
            this.tb_pwd.Text = "8888";
            this.tb_pwd.UseSystemPasswordChar = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(81, 55);
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
            this.pb_popup_softkeyboard.Location = new System.Drawing.Point(254, 12);
            this.pb_popup_softkeyboard.Name = "pb_popup_softkeyboard";
            this.pb_popup_softkeyboard.Size = new System.Drawing.Size(42, 31);
            this.pb_popup_softkeyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_popup_softkeyboard.TabIndex = 7;
            this.pb_popup_softkeyboard.TabStop = false;
            this.pb_popup_softkeyboard.Click += new System.EventHandler(this.Softkeyboard_Click);
            // 
            // ConfirmPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 89);
            this.Controls.Add(this.pb_popup_softkeyboard);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码验证";
            ((System.ComponentModel.ISupportInitialize)(this.pb_popup_softkeyboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.PictureBox pb_popup_softkeyboard;
    }
}