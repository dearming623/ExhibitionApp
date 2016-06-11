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
        private List<AnimatorImage> lst2 = new List<AnimatorImage>();
        private AnimatorImage ias; // 动画类实例引用
        private AnimateType animatorType = AnimateType.Animator01; // 动画类型
        private bool picIsPlaying = false;
        private FormMenu _FormMenu = null;

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
                        addPicture(dir);
                        j++;

                    }
                }
            }
          


            if (lst2 == null || lst2.Count == 0)
            {
                MessageBox.Show("没有可播放图片，请检查文件夹内是否有图片存在。");

            }
            else
            {
                timer1.Enabled = true;
            }

        }


        private void addPicture(string imagePath)
        {

            Bitmap bmap =  new Bitmap(imagePath, true);

            AnimatorImage image = new AnimatorImage(bmap); // 获取资源，实例化动画类

            // Invalidate()方法底层并不涉及控件界面，只是发送消息，因此可以在不同线程间调用，即它是线程安全的
            image.Redraw += (s, e) => pictureBox1.Invalidate(e.ClipRectangle);

            lst2.Add(image);
        }

        #region 动画控制

        // 重绘
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (ias != null)
            {
                // 将动画类中的内存输出位图绘制到DC上
                e.Graphics.DrawImage(ias.OutBmp, e.ClipRectangle, e.ClipRectangle, GraphicsUnit.Pixel);
            }
           
        }

        // 开始动画
        private void button1_Click_1(object sender, EventArgs e)
        {
            ias.DrawAnimator(animatorType);
        }

        // 暂停动画
        private void button2_Click(object sender, EventArgs e)
        {
            ias.PauseDraw();
        }

        // 继续动画
        private void button3_Click(object sender, EventArgs e)
        {
            ias.ResumeDraw();
        }

        // 取消动画
        private void button4_Click(object sender, EventArgs e)
        {
            ias.CancelDraw();
        }

        // 设置延时系数
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //ias.Delay = trackBar1.Value;

            ias.Delay = 1;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (lst2 == null || lst2.Count == 0)
            {
                MessageBox.Show("没有可播放图片，请检查文件夹内是否有图片存在。");
                return;
            }
            timer1.Enabled = true;
           
        }

        private void PlayPictures()
        {
            if (!picIsPlaying)
            {
                Random ran = new Random();
                int RandKey = ran.Next(0, lst2.Count);
                int type = ran.Next(1, 29);
                ias = lst2[RandKey];

                ias.DrawStarted += Ias_DrawStarted;
                ias.DrawCompleted += Ias_DrawCompleted;

                SelectAnimator(type);

                if (oldBmp == null)
                {
                    ias.DrawAnimator(animatorType);
                }
                else
                {
                    ias.DrawAnimator(animatorType, oldBmp);
                }
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            PlayPictures();
           
        }

        private void Ias_DrawCompleted(object sender, EventArgs e)
        {
            oldBmp = ias.OutBmp;
            picIsPlaying = false;
        }

        private void Ias_DrawStarted(object sender, EventArgs e)
        {
            picIsPlaying = true;
        }

        private Bitmap oldBmp = null;

        // 所有动画效果选择RadioButton的CheckedChanged事件
        private void SelectAnimator(int type)
        {
            
            switch (type)
            {
                case 1:
                    animatorType = AnimateType.Animator01; // 压缩反转
                    break;
                case 2:
                    animatorType = AnimateType.Animator02; // 垂直对接
                    break;
                case 3:
                    animatorType = AnimateType.Animator03; // 中心闭幕
                    break;
                case 4:
                    animatorType = AnimateType.Animator04; // 中心放大
                    break;
                case 5:
                    animatorType = AnimateType.Animator05; // 逐行分块
                    break;
                case 6:
                    animatorType = AnimateType.Animator06; // 交替分块
                    break;
                case 7:
                    animatorType = AnimateType.Animator07; // 交叉竖条
                    break;
                case 8:
                    animatorType = AnimateType.Animator08; // 透明淡入
                    break;
                case 9:
                    animatorType = AnimateType.Animator09; // 三色淡入
                    break;
                case 10:
                    animatorType = AnimateType.Animator10; // 水平拉幕
                    break;
                case 11:
                    animatorType = AnimateType.Animator11; // 随机竖条
                    break;
                case 12:
                    animatorType = AnimateType.Animator12; // 随机拉丝
                    break;
                case 13:
                    animatorType = AnimateType.Animator13; // 垂直对切
                    break;
                case 14:
                    animatorType = AnimateType.Animator14; // 随机分块
                    break;
                case 15:
                    animatorType = AnimateType.Animator15; // 对角闭幕
                    break;
                case 16:
                    animatorType = AnimateType.Animator16; // 垂直百叶
                    break;
                case 17:
                    animatorType = AnimateType.Animator17; // 压缩竖条
                    break;
                case 18:
                    animatorType = AnimateType.Animator18; // 水平拉入
                    break;
                case 19:
                    animatorType = AnimateType.Animator19; // 三色对接
                    break;
                case 20:
                    animatorType = AnimateType.Animator20; // 对角滑动
                    break;
                case 21:
                    animatorType = AnimateType.Animator21; // 旋转放大
                    break;
                case 22:
                    animatorType = AnimateType.Animator22; // 椭圆拉幕
                    break;
                case 23:
                    animatorType = AnimateType.Animator23; // 对角拉伸
                    break;
                case 24:
                    animatorType = AnimateType.Animator24; // 旋转扫描
                    break;
                case 25:
                    animatorType = AnimateType.Animator25; // 多径扫描
                    break;
                case 26:
                    animatorType = AnimateType.Animator26; // 随机落幕
                    break;
                case 27:
                    animatorType = AnimateType.Animator27; // 螺线内旋
                    break;
                case 28:
                    animatorType = AnimateType.Animator28; // 灰度扫描
                    break;
                case 29:
                    animatorType = AnimateType.Animator29; // 负片追踪
                    break;
                default:
                    animatorType = AnimateType.Animator30; // 水平卷轴
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //if (_FormMenu != null)
            //{
            //    _FormMenu.Activate();
            //}
            //else
            //{
            //    _FormMenu = new FormMenu();
            //    _FormMenu.Show();
            //    _FormMenu.FormClosed += FormMenu_Closed;
            //}

            onScreenClick();
        }

        private void FormMenu_Closed(object sender, EventArgs e)
        {
            _FormMenu = null;
        }

        private void onScreenClick()
        {
            if (onScreenClickEvent != null)
            {
                onScreenClickEvent(null, null);
            }
        }
    }
}
