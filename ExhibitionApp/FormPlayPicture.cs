using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ExhibitionApp
{
    public partial class FormPlayPicture : Form
    {
        public FormPlayPicture()
        {
            InitializeComponent();
        }

        public delegate void onScreenClickEventHandler(object sender, EventArgs e);
        public event onScreenClickEventHandler onScreenClickEvent;

        private ArrayList lst = new ArrayList();

        private void Form2_Load(object sender, EventArgs e)
        {
            string imgtype = "*.BMP|*.JPG|*.GIF|*.PNG";
            string[] ImageType = imgtype.Split('|');

            string path = MyAppSetting.GetInstance().GetPathOfSlide();

            if (String.IsNullOrEmpty(path) && !Directory.Exists(path) )
            {
                path = Environment.CurrentDirectory + "\\Pictures";
            }

            if (!Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);

                try
                {
                    directoryInfo.Create();
                }
                catch (Exception)
                {
                    MessageBox.Show("存放幻灯图片文件夹创建失败。");
                }
                
            }

            if (Directory.Exists(path))
            {
                for (int i = 0; i < ImageType.Length; i++)
                {
                    string[] dirs = Directory.GetFiles(path, ImageType[i]);
                    // string[] dirs = Directory.GetFiles(@"d:\\My Documents\\My Pictures", "*.jpg");
                    int j = 0;
                    foreach (string dir in dirs)
                    {
                        //Response.Write("<p>" + dir + "</p>");
                        lst.Add(dir);

                       // addPicture(dir);

                        j++;

                    }
                }


                //IComparer myComparer = new myReverserClass();
                //lst.Sort(myComparer);
            }

            if (lst == null || lst.Count == 0)
            {
                MessageBox.Show("没有可播放图片，请检查文件夹内是否有图片存在。");
            }else
            {
                PlaySlide();
            }

        }

        private SlideProjector sp;
        private void PlaySlide()
        {
            sp = new SlideProjector(pictureBox1.Width, pictureBox1.Height ); 

            sp.loadImages(lst);

            sp.Redraw += (s, e) => pictureBox1.Invalidate(e.ClipRectangle);

            sp.Start();
        }


        // 重绘
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (sp != null && sp.OutBmp != null)
            {

                // 将动画类中的内存输出位图绘制到DC上
                // e.Graphics.DrawImage(ias.OutBmp, e.ClipRectangle, e.ClipRectangle, GraphicsUnit.Pixel); // Ming发现这里经常有异常
                e.Graphics.DrawImage(sp.OutBmp, e.ClipRectangle, e.ClipRectangle, GraphicsUnit.Pixel); // Ming发现这里经常有异常

            }

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            onScreenClick();
        }

        private void onScreenClick()
        {
            if (onScreenClickEvent != null)
            {
                onScreenClickEvent(null, null);
            }
        }

        private void FormPlayPicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sp != null && sp.isPlaying())
            {
                sp.Stop();
            }
        }

        //public class myReverserClass : IComparer
        //{

        //    // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
        //    int IComparer.Compare(Object x, Object y)
        //    {
        //        return ((new CaseInsensitiveComparer()).Compare(y, x));
        //    }

        //}

    }
}
