using MoveableListLib;
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
    public partial class FormVideoSelection : Form
    {
        private int imageindexs;
        private MListItem CurrentItem = null;

        public FormVideoSelection()
        {
            InitializeComponent();
        }

        private void FormVideoSelection_Load(object sender, EventArgs e)
        {
           // loadImage();

            LoadImages();

            //PictureBox pb_play = new PictureBox();
            //pb_play.Click += Pb_play_Click;
            //pb_play.Image = Properties.Resources.Play_Normal_128px;
            //pb_play.SizeMode = PictureBoxSizeMode.StretchImage;
            //pb_play.Location = new Point((pnlThumb.Width-pb_play.Width)/2, (pnlThumb.Height - pb_play.Height) / 2);


            //pnlThumb.Controls.Add(pb_play);
            //pb_play.BringToFront();

            btn_play_video.Location = new Point((pnlThumb.Width - btn_play_video.Width) / 2, (pnlThumb.Height - btn_play_video.Height) / 2);
            btn_play_video.BringToFront();
        }

        private void Pb_play_Click(object sender, EventArgs e)
        {
            FormPlayVideo playvideo = new FormPlayVideo();
            playvideo.Show();
            // playvideo.play("d:\\CYON_15s.avi");
            playvideo.play(CurrentItem.VideoFullName);
        }

        private void loadImage()
        {
            string imgtype = "*.BMP|*.JPG|*.GIF|*.PNG";
            string[] ImageType = imgtype.Split('|');

            string path = "";
            if (String.IsNullOrEmpty(path))
            {
                path = Environment.CurrentDirectory + "\\Pictures";
            }

            if (!Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                directoryInfo.Create();
            }

            ctrl = new PictureBox[20];
            for (int i = 0; i < ImageType.Length; i++)
            {
                string[] dirs = Directory.GetFiles(path, ImageType[i]);
                // string[] dirs = Directory.GetFiles(@"d:\\My Documents\\My Pictures", "*.jpg");
                int j = 0;
                foreach (string dir in dirs)
                {
                    //Response.Write("<p>" + dir + "</p>");
                    //lst.Add(dir);
                    addImageToPanel(dir);
                    j++;

                }
            }
        }


        public delegate void onScreenClickEventHandler(object sender, EventArgs e);
        public event onScreenClickEventHandler onScreenClickEvent;
        private void onScreenClick()
        {
            if (onScreenClickEvent != null)
            {
                onScreenClickEvent(null, null);
            }
        }


        private void onMenuClick(object sender, EventArgs e)
        {
            onScreenClick();
        }

       
        private void addImageToPanel(string imagePath)
        {

            //ctrl[imageindexs] = new PictureBox();
            //ctrl[imageindexs].Image = Image.FromFile(imagePath);
            //ctrl[imageindexs].BackColor = Color.Black;
            //ctrl[imageindexs].Location = new Point(newLocX, newLocY);
            //ctrl[imageindexs].Size = new System.Drawing.Size(sizeWidth - 30, sizeHeight - 60);
            //ctrl[imageindexs].BorderStyle = BorderStyle.None;
            //ctrl[imageindexs].SizeMode = PictureBoxSizeMode.StretchImage;
            ////  ctrl[imageindexs].MouseClick += new MouseEventHandler(control_MouseMove);
            //pnlThumb.Controls.Add(ctrl[imageindexs]);
        }

        private void loadImagestoPanel(String imageName, String ImageFullName, int newLocX, int newLocY, int imageindexs)
        {
            ctrl[imageindexs] = new PictureBox();
            ctrl[imageindexs].Click += FormVideoSelection_Click;
            ctrl[imageindexs].Image = Image.FromFile(ImageFullName);
            ctrl[imageindexs].BackColor = Color.Black;
            ctrl[imageindexs].Location = new Point(newLocX, newLocY);
            ctrl[imageindexs].Size = new System.Drawing.Size(picsizeWidth , picsizeHeight);
            ctrl[imageindexs].BorderStyle = BorderStyle.None;
            ctrl[imageindexs].SizeMode = PictureBoxSizeMode.StretchImage;
            //  ctrl[imageindexs].MouseClick += new MouseEventHandler(control_MouseMove);
            pnlThumb.Controls.Add(ctrl[imageindexs]);


        }

        private void FormVideoSelection_Click(object sender, EventArgs e)
        {
            //if (last_Select_pic != null)
            //{
            //    last_Select_pic.Location = last_Select_point;
            //    last_Select_pic.Size = new System.Drawing.Size(picsizeWidth, picsizeHeight);
            //    last_Select_pic.BorderStyle = BorderStyle.None;
            //    // new Point(newLocX, newLocY);
            //}

            //PictureBox hightlighPic = (PictureBox)sender;
            //last_Select_pic = hightlighPic;
            //last_Select_point = last_Select_pic.Location;


            //int highlighted_x = last_Select_point.X - (highlightedWidth - picsizeWidth) / 2;
            //int highlighted_y = last_Select_point.Y - (highlightedHeight - picsizeHeight) / 2;

            ////hightlighPic.Left = hightlighPic.Left - 20;
            ////hightlighPic.Top = hightlighPic.Left - 20;
            //hightlighPic.Location = new Point(highlighted_x, highlighted_y);
            //hightlighPic.Size = new System.Drawing.Size(highlightedWidth, highlightedHeight);
            //hightlighPic.BorderStyle = BorderStyle.FixedSingle;

            FormPlayVideo playvideo = new FormPlayVideo(Environment.CurrentDirectory + "\\Videos" + "\\jiu30s.avi");
            playvideo.Show();
            playvideo.play(Environment.CurrentDirectory + "\\Videos" + "\\jiu30s.avi");


        }

        private string[] AllImageFielsNames = null;
        private int locX = 40;
        private int locY = 10;
        private int CurrentIndex = 0;
        private int StartIndex = 0;
        private int LastIndex = 0;
        private PictureBox[] ctrl;
        private int sizeWidth = 130;
        private int sizeHeight = 130;


        /// <summary>
        /// 图片宽度
        /// </summary>
        private int picsizeWidth = 280;
        /// <summary>
        /// 图片高度
        /// </summary>
        private int picsizeHeight = 280;

        /// <summary>
        /// 选中图片宽度
        /// </summary>
        private int highlightedWidth = 350;
        /// <summary>
        /// 选中图片高度
        /// </summary>
        private int highlightedHeight = 350;

        /// <summary>
        /// 图片之间的距离
        /// </summary>
        private int distanceBetweenPic  = 80;

        PictureBox last_Select_pic = null;
        Point last_Select_point = new Point(0, 0);

        public void LoadImages()
        {
            string videoPath = MyAppSetting.GetInstance().GetPathOfVideo();
            if (String.IsNullOrEmpty(videoPath) && !Directory.Exists(videoPath))
            {
                videoPath = Environment.CurrentDirectory + "\\Videos";
            }

            if (!Directory.Exists(videoPath))
            {
                try
                {
                    Directory.CreateDirectory(videoPath);
                }
                catch (Exception)
                {

                    MessageBox.Show("视频文件夹创建失败。");

                    return;
                }
               
            }
            string videoImagePath = videoPath + "\\images";
            DirectoryInfo Folder;
            Folder = new DirectoryInfo(videoImagePath);

            if (!Folder.Exists)
            {
                Folder.Create();
            }
           

           // pnlThumb.Controls.Clear();

            AllImageFielsNames = Directory.GetFiles(videoImagePath);


            FileInfo[] imageFiles = Folder.GetFiles();

            int locnewX = locX;
            int locnewY = locY;

            locnewY = (pnlThumb.Height - picsizeHeight) / 2;

            ctrl = new PictureBox[AllImageFielsNames.Length];
            int imageindexs = 0;

            ArrayList piclst = new ArrayList();

            foreach (FileInfo img in imageFiles)
            {
                AllImageFielsNames[imageindexs] = img.FullName;
               // loadImagestoPanel(img.Name, img.FullName, locnewX, locnewY, imageindexs);
                locnewX = locnewX + picsizeWidth + distanceBetweenPic;
                imageindexs = imageindexs + 1;

                MListItem item = new MListItem();
                item.onItemClickEvent += Item_onItemClickEvent;
                item.ImageFullName = img.FullName;
                item.VideoFullName = videoPath + "\\" + img.Name.Replace(img.Extension, ".avi");
                item.setPicture(img.FullName);
                piclst.Add(item);
            }
            CurrentIndex = 0;
            StartIndex = 0;
            LastIndex = 0;

            //DrawImageSlideShows();

          
            moveableList1.loadItemList(piclst);

            if (piclst.Count > 0)
            {
                CurrentItem = (MListItem)piclst[0];
                picImageSlide.Image = Image.FromFile(CurrentItem.ImageFullName);
            }

        }

        private void Item_onItemClickEvent(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            CurrentItem = (MListItem)pb.Tag;
            picImageSlide.Image = Image.FromFile(CurrentItem.ImageFullName);

            MessageBox.Show("video full name:" + CurrentItem.VideoFullName);
        }
    }
}
