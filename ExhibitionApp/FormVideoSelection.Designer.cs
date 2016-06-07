namespace ExhibitionApp
{
    partial class FormVideoSelection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlThumb = new System.Windows.Forms.Panel();
            this.btn_play_video = new System.Windows.Forms.PictureBox();
            this.picImageSlide = new System.Windows.Forms.PictureBox();
            this.moveableList1 = new MoveableListLib.MoveableList();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlThumb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.moveableList1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 642);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1074, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 642);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExhibitionApp.Properties.Resources.menu_circle_48px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.onMenuClick);
            // 
            // pnlThumb
            // 
            this.pnlThumb.AutoScroll = true;
            this.pnlThumb.BackColor = System.Drawing.Color.Transparent;
            this.pnlThumb.Controls.Add(this.btn_play_video);
            this.pnlThumb.Controls.Add(this.picImageSlide);
            this.pnlThumb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThumb.Location = new System.Drawing.Point(338, 0);
            this.pnlThumb.Name = "pnlThumb";
            this.pnlThumb.Size = new System.Drawing.Size(736, 642);
            this.pnlThumb.TabIndex = 2;
            // 
            // btn_play_video
            // 
            this.btn_play_video.BackColor = System.Drawing.Color.Transparent;
            this.btn_play_video.Image = global::ExhibitionApp.Properties.Resources.Play_Normal_128px;
            this.btn_play_video.Location = new System.Drawing.Point(285, 236);
            this.btn_play_video.Name = "btn_play_video";
            this.btn_play_video.Size = new System.Drawing.Size(128, 128);
            this.btn_play_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_play_video.TabIndex = 8;
            this.btn_play_video.TabStop = false;
            this.btn_play_video.Click += new System.EventHandler(this.Pb_play_Click);
            // 
            // picImageSlide
            // 
            this.picImageSlide.BackColor = System.Drawing.SystemColors.Control;
            this.picImageSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImageSlide.Location = new System.Drawing.Point(0, 0);
            this.picImageSlide.Name = "picImageSlide";
            this.picImageSlide.Size = new System.Drawing.Size(736, 642);
            this.picImageSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageSlide.TabIndex = 0;
            this.picImageSlide.TabStop = false;
            // 
            // moveableList1
            // 
            this.moveableList1.Dock = System.Windows.Forms.DockStyle.Left;
            this.moveableList1.Location = new System.Drawing.Point(0, 0);
            this.moveableList1.Name = "moveableList1";
            this.moveableList1.Size = new System.Drawing.Size(340, 642);
            this.moveableList1.TabIndex = 0;
            // 
            // FormVideoSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 642);
            this.ControlBox = false;
            this.Controls.Add(this.pnlThumb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVideoSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVideoSelection_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlThumb.ResumeLayout(false);
            this.pnlThumb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play_video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlThumb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MoveableListLib.MoveableList moveableList1;
        private System.Windows.Forms.PictureBox picImageSlide;
        private System.Windows.Forms.PictureBox btn_play_video;
    }
}

