namespace MoveableListLib
{
    partial class MListItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblContent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContent.AutoSize = true;
            this.lblContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContent.Location = new System.Drawing.Point(84, 82);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(53, 12);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "描述信息";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseDown);
            this.lblContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseMove);
            this.lblContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = ">>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.lblContent);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(317, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(0, 180);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseUp);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPanel.Controls.Add(this.picBox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(317, 180);
            this.leftPanel.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(20, 13);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(278, 156);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.label1_Click);
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseUp);
            // 
            // MListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExhibitionApp.Properties.Resources.video_thumbnail;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.DoubleBuffered = true;
            this.Name = "MListItem";
            this.Size = new System.Drawing.Size(316, 180);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MListItem_MouseUp);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox picBox;
    }
}
