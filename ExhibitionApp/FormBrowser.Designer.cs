namespace ExhibitionApp
{
    partial class FormBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrowser));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_go_forward = new System.Windows.Forms.ImageButton();
            this.btn_go_back = new System.Windows.Forms.ImageButton();
            this.btn_menu = new System.Windows.Forms.ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_go_forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_go_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 547);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::ExhibitionApp.Properties.Resources.NavigationBG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_go_forward);
            this.panel1.Controls.Add(this.btn_go_back);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 41);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // btn_go_forward
            // 
            this.btn_go_forward.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_go_forward.BackColor = System.Drawing.Color.Transparent;
            this.btn_go_forward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_go_forward.DownImage = null;
            this.btn_go_forward.DownImage = global::ExhibitionApp.Properties.Resources.arrowforwardDown;
            this.btn_go_forward.Location = new System.Drawing.Point(792, 8);
            this.btn_go_forward.Name = "btn_go_forward";
            this.btn_go_forward.NormalImage = global::ExhibitionApp.Properties.Resources.arrowforwardNormal;
            this.btn_go_forward.Size = new System.Drawing.Size(38, 28);
            this.btn_go_forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_go_forward.TabIndex = 1;
            this.btn_go_forward.TabStop = false;
            this.btn_go_forward.Click += new System.EventHandler(this.onClickGoForward);
            // 
            // btn_go_back
            // 
            this.btn_go_back.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_go_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_go_back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_go_back.DownImage = null;
            this.btn_go_back.DownImage = global::ExhibitionApp.Properties.Resources.arrowbackDown;
            this.btn_go_back.Location = new System.Drawing.Point(746, 8);
            this.btn_go_back.Name = "btn_go_back";
            this.btn_go_back.NormalImage = global::ExhibitionApp.Properties.Resources.arrowbackNormal;
            this.btn_go_back.Size = new System.Drawing.Size(38, 28);
            this.btn_go_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_go_back.TabIndex = 0;
            this.btn_go_back.TabStop = false;
            this.btn_go_back.Click += new System.EventHandler(this.onClickGoBack);
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_menu.DownImage = null;
            this.btn_menu.DownImage = global::ExhibitionApp.Properties.Resources.menuDown;
            this.btn_menu.Location = new System.Drawing.Point(849, 11);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.NormalImage = global::ExhibitionApp.Properties.Resources.menuNormal;
            this.btn_menu.Size = new System.Drawing.Size(28, 22);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_menu.TabIndex = 11;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.menu_option_Click);
            // 
            // FormBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 588);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBrowser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_go_forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_go_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageButton btn_menu;
        private System.Windows.Forms.ImageButton btn_go_forward;
        private System.Windows.Forms.ImageButton btn_go_back;
    }
}

