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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideoSelection));
            this.pnlThumb = new System.Windows.Forms.Panel();
            this.btn_play_video = new System.Windows.Forms.ImageButton();
            this.picImageSlide = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageButton1 = new System.Windows.Forms.ImageButton();
            this.moveableList1 = new MoveableListLib.MoveableList();
            this.pnlThumb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSlide)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlThumb
            // 
            this.pnlThumb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThumb.AutoScroll = true;
            this.pnlThumb.BackColor = System.Drawing.SystemColors.Control;
            this.pnlThumb.Controls.Add(this.btn_play_video);
            this.pnlThumb.Controls.Add(this.picImageSlide);
            this.pnlThumb.Location = new System.Drawing.Point(0, 0);
            this.pnlThumb.Name = "pnlThumb";
            this.pnlThumb.Size = new System.Drawing.Size(821, 642);
            this.pnlThumb.TabIndex = 2;
            // 
            // btn_play_video
            // 
            this.btn_play_video.BackColor = System.Drawing.Color.Transparent;
            this.btn_play_video.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_play_video.DownImage = global::ExhibitionApp.Properties.Resources.playDown;
            this.btn_play_video.HoverImage = null;
            this.btn_play_video.Location = new System.Drawing.Point(347, 295);
            this.btn_play_video.Name = "btn_play_video";
            this.btn_play_video.NormalImage = global::ExhibitionApp.Properties.Resources.playNormal;
            this.btn_play_video.Size = new System.Drawing.Size(100, 100);
            this.btn_play_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_play_video.TabIndex = 9;
            this.btn_play_video.TabStop = false;
            this.btn_play_video.Click += new System.EventHandler(this.Pb_play_Click);
            // 
            // picImageSlide
            // 
            this.picImageSlide.BackColor = System.Drawing.SystemColors.Control;
            this.picImageSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImageSlide.Location = new System.Drawing.Point(0, 0);
            this.picImageSlide.Name = "picImageSlide";
            this.picImageSlide.Size = new System.Drawing.Size(821, 642);
            this.picImageSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageSlide.TabIndex = 0;
            this.picImageSlide.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::ExhibitionApp.Properties.Resources.listbg;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.moveableList1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(821, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 642);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::ExhibitionApp.Properties.Resources.img1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.imageButton1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 49);
            this.panel1.TabIndex = 0;
            // 
            // imageButton1
            // 
            this.imageButton1.BackColor = System.Drawing.Color.Transparent;
            this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton1.DownImage = null;
            this.imageButton1.DownImage = global::ExhibitionApp.Properties.Resources.menuDown;
            this.imageButton1.Location = new System.Drawing.Point(259, 13);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.NormalImage = global::ExhibitionApp.Properties.Resources.menuNormal;
            this.imageButton1.Size = new System.Drawing.Size(28, 22);
            this.imageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageButton1.TabIndex = 10;
            this.imageButton1.TabStop = false;
            this.imageButton1.Click += new System.EventHandler(this.onMenuClick);
            // 
            // moveableList1
            // 
            this.moveableList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.moveableList1.BackColor = System.Drawing.Color.Transparent;
            this.moveableList1.Location = new System.Drawing.Point(0, 55);
            this.moveableList1.Margin = new System.Windows.Forms.Padding(0);
            this.moveableList1.Name = "moveableList1";
            this.moveableList1.Size = new System.Drawing.Size(309, 587);
            this.moveableList1.TabIndex = 0;
            // 
            // FormVideoSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1130, 642);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlThumb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlThumb;
        private System.Windows.Forms.PictureBox picImageSlide;
        private System.Windows.Forms.ImageButton btn_play_video;
        private MoveableListLib.MoveableList moveableList1;
        private System.Windows.Forms.ImageButton imageButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

