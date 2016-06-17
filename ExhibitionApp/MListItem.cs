using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoveableListLib
{
    public partial class MListItem : UserControl
    {
        private Point startLocation;
        private Point endLocation;
        public MListItem(string index)
        {
            InitializeComponent();
           // this.lblContent.Text += index;
        }

        public MListItem()
        {
            InitializeComponent();

            picBox.Tag = this;
        }


        public delegate void onItemClickEventHandler(object sender, EventArgs e);
        public event onItemClickEventHandler onItemClickEvent;


        public string ImageFullName = "";
        public string VideoFullName = "";

        public void setPicture(string fullName)
        {
            picBox.Image = Image.FromFile(fullName);
            ImageFullName = fullName;
           // picBox.Tag = ImageFullName;
        }

        public void setDisplayName(string name)
        {
            lbl_video_name.Text = name;
        }




        private void label1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(this.lblContent.Text +"的详细信息！");
            if (onItemClickEvent != null)
            {
                onItemClickEvent(sender, e);
            }

            setSelection(true);
        }

        private void MListItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int size = this.Parent.Controls.Count;
                startLocation = e.Location;
            }
        }

        private void MListItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (startLocation != null)
                {
                    endLocation = e.Location;
                    int xx = endLocation.Y - startLocation.Y;
                    if (Math.Abs(xx)>0.1)
                    reloadCtrlPosition(xx);
                 }
            }
        }

        public void setSelection(bool v)
        {
            if (v)
            {
                this.BackgroundImage = ExhibitionApp.Properties.Resources.video_thumbnail;
                this.lbl_video_name.BackColor = Color.Transparent;
                //this.lbl_video_name.Font =  new Font("宋体", 18, FontStyle.Bold);
            }
            else
            {
                this.BackgroundImage = null;
                this.lbl_video_name.BackColor = Color.FromArgb(0x33, 0x33, 0x33);
                // this.lbl_video_name.Font = new Font("宋体", 13, FontStyle.Bold);
            }
            
        }

        private void MListItem_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (startLocation != null)
                {
                    //考虑第一条记录
                    Control firstCtrl = this.Parent.Controls[0];
                    int firstPosition = firstCtrl.Location.Y;
                    if (firstPosition > 0)
                    {
                        reloadCtrlPosition(-firstCtrl.Location.Y);
                    }
                    else
                    {
                        MoveableList parentCtrl = (MoveableList)this.Parent;
                        int size = this.Parent.Controls.Count;
                        Control lastCtrl = parentCtrl.Controls[size - 1];
                        if (!parentCtrl.existOtherData())
                        {
                            int sumHeight=size * lastCtrl.Height;
                            int maxHeight=parentCtrl.Height;
                            if (sumHeight <parentCtrl.Height)
                            {
                                maxHeight = sumHeight;
                            }
                            int xx =maxHeight - lastCtrl.Height - lastCtrl.Location.Y;
                            if (xx > 0)
                              reloadCtrlPosition(xx);
                        }
                        else
                        {
                            parentCtrl.loadNewData(lastCtrl.Location.Y + lastCtrl.Height);
                        }
                    }

                }
            }
        }

        /// <summary>
        /// 重新计算位置
        /// </summary>
        /// <param name="xx">变化值</param>
        private void reloadCtrlPosition(int xx)
        {
            foreach (Control ctrl in this.Parent.Controls)
            {
                ctrl.Location = new Point(MoveableList.ITEM_LOCATION_X, ctrl.Location.Y + xx);
            }
            //int count=this.Parent.Controls.Count;
            ////重新计算位置
            //if (xx > 0)
            //{
            //    for (int i = count - 1; i >=0;i-- )
            //    {
            //        Control ctrl =this.Parent.Controls[i];
            //        ctrl.Location = new Point(0, ctrl.Location.Y + xx);
            //    }
            //}
            //else if (xx < 0)
            //{
            //    for (int i =0; i < count ; i++)
            //    {
            //        Control ctrl = this.Parent.Controls[i];
            //        ctrl.Location = new Point(0, ctrl.Location.Y + xx);
            //    }
            //}
        }

        }
    }
