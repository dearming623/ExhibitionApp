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
            this.pnlThumb = new System.Windows.Forms.Panel();
            this.btn_play_video = new System.Windows.Forms.PictureBox();
            this.picImageSlide = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.moveableList1 = new MoveableListLib.MoveableList();
            this.pnlThumb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSlide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThumb
            // 
            this.pnlThumb.AutoScroll = true;
            this.pnlThumb.BackColor = System.Drawing.Color.Maroon;
            this.pnlThumb.Controls.Add(this.btn_play_video);
            this.pnlThumb.Controls.Add(this.picImageSlide);
            this.pnlThumb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThumb.Location = new System.Drawing.Point(0, 0);
            this.pnlThumb.Name = "pnlThumb";
            this.pnlThumb.Size = new System.Drawing.Size(813, 642);
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
            this.picImageSlide.Size = new System.Drawing.Size(813, 642);
            this.picImageSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageSlide.TabIndex = 0;
            this.picImageSlide.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ExhibitionApp.Properties.Resources.video_list;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(813, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 642);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ExhibitionApp.Properties.Resources.menu_white;
            this.pictureBox1.Location = new System.Drawing.Point(261, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.onMenuClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.moveableList1);
            this.splitContainer1.Size = new System.Drawing.Size(317, 642);
            this.splitContainer1.SplitterDistance = 54;
            this.splitContainer1.TabIndex = 0;
            // 
            // moveableList1
            // 
            this.moveableList1.BackColor = System.Drawing.Color.Transparent;
            this.moveableList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveableList1.Location = new System.Drawing.Point(0, 0);
            this.moveableList1.Name = "moveableList1";
            this.moveableList1.Size = new System.Drawing.Size(317, 584);
            this.moveableList1.TabIndex = 0;
            // 
            // FormVideoSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1130, 642);
            this.ControlBox = false;
            this.Controls.Add(this.pnlThumb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVideoSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Video Selection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVideoSelection_Load);
            this.pnlThumb.ResumeLayout(false);
            this.pnlThumb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play_video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSlide)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlThumb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MoveableListLib.MoveableList moveableList1;
        private System.Windows.Forms.PictureBox picImageSlide;
        private System.Windows.Forms.PictureBox btn_play_video;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

