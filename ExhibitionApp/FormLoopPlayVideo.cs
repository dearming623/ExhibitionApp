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
    public partial class FormLoopPlayVideo : Form
    {
        public FormLoopPlayVideo()
        {
            InitializeComponent();

            axWindowsMediaPlayer1.uiMode = "None";
        }

      


        public delegate void onScreenClickEventHandler(object sender, EventArgs e);
        public event onScreenClickEventHandler onScreenClickEvent;

        private ArrayList lst = new ArrayList();

        private void Form_Load(object sender, EventArgs e)
        {
          
            string path = "";
            if (String.IsNullOrEmpty(path))
            {
                path = Environment.CurrentDirectory + "\\Videos";
            }

            if (!Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                directoryInfo.Create();
            }

            //for (int i = 0; i < ImageType.Length; i++)
            //{
                string[] dirs = Directory.GetFiles(path);
                //string[] dirs = Directory.GetFiles(path, ImageType[i]);
                // string[] dirs = Directory.GetFiles(@"d:\\My Documents\\My Pictures", "*.jpg");
                int j = 0;
                foreach (string dir in dirs)
                {
                    //Response.Write("<p>" + dir + "</p>");
                    lst.Add(dir);
                   
                    j++;

                }
            //}

            LoadVideoAndPlay();
        }

        private void onScreenClick()
        {
            if (onScreenClickEvent != null)
            {
                onScreenClickEvent(null, null);
            }
        }

        

        private void LoadVideoAndPlay()
        {
            axWindowsMediaPlayer1.uiMode = "None";
            //axWindowsMediaPlayer1.URL = "E:\\demo.avi";

            axWindowsMediaPlayer1.enableContextMenu = false;
            axWindowsMediaPlayer1.ClickEvent += AxWindowsMediaPlayer1_ClickEvent;
            axWindowsMediaPlayer1.DoubleClickEvent += AxWindowsMediaPlayer1_DoubleClickEvent;
            axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;

            this.axWindowsMediaPlayer1.currentPlaylist.clear();

            if (lst !=null && lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    this.axWindowsMediaPlayer1.currentPlaylist.appendItem(this.axWindowsMediaPlayer1.newMedia(lst[i].ToString()));
                }
                
            }

            //this.axWindowsMediaPlayer1.currentPlaylist.appendItem(this.axWindowsMediaPlayer1.newMedia("D:\\jiu30s.avi"));
            //this.axWindowsMediaPlayer1.currentPlaylist.appendItem(this.axWindowsMediaPlayer1.newMedia("D:\\jiu30s.avi"));

            if (this.axWindowsMediaPlayer1.currentPlaylist.count > 0)
            {
                axWindowsMediaPlayer1.settings.setMode("loop", true);
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else {
                MessageBox.Show("没有任何可以播放的视频，请检查视频源是否准备好。");
            }
            

        }

   

        private void AxWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            //throw new NotImplementedException();

        }

        private void AxWindowsMediaPlayer1_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            //throw new NotImplementedException();
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Test the current state of the player and display a message for each state.
            switch (e.newState)
            {
                case 0:    // Undefined
                   // currentStateLabel.Text = "Undefined";
                    break;

                case 1:    // Stopped
                   // currentStateLabel.Text = "Stopped";
                    break;

                case 2:    // Paused
                   // currentStateLabel.Text = "Paused";
                    break;

                case 3:    // Playing
                   // currentStateLabel.Text = "Playing";
                   // axWindowsMediaPlayer1.fullScreen = true;
                    break;

                case 4:    // ScanForward
                   // currentStateLabel.Text = "ScanForward";
                    break;

                case 5:    // ScanReverse
                  //  currentStateLabel.Text = "ScanReverse";
                    break;

                case 6:    // Buffering
                   // currentStateLabel.Text = "Buffering";
                    break;

                case 7:    // Waiting
                   // currentStateLabel.Text = "Waiting";
                    break;

                case 8:    // MediaEnded
                   // currentStateLabel.Text = "MediaEnded";

                    //axWindowsMediaPlayer1.Ctlcontrols.stop();
                    //this.Close();

                    break;

                case 9:    // Transitioning
                   // currentStateLabel.Text = "Transitioning";
                    break;

                case 10:   // Ready
                   // currentStateLabel.Text = "Ready";
                    break;

                case 11:   // Reconnecting
                   // currentStateLabel.Text = "Reconnecting";
                    break;

                case 12:   // Last
                   // currentStateLabel.Text = "Last";
                    break;

                default:
                   // currentStateLabel.Text = ("Unknown State: " + e.newState.ToString());
                    break;
            }

            //if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            //{
            //    axWindowsMediaPlayer1.Ctlcontrols.stop();
            //    //MessageBox.Show("播放完毕");
            //    this.Close();
            //}
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //onScreenClick();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

       
    }
}
