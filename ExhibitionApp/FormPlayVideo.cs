using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ExhibitionApp
{
    public partial class FormPlayVideo : Form
    {
        public FormPlayVideo()
        {
            InitializeComponent();
        }

        public delegate void onScreenClickEventHandler(object sender, EventArgs e);
        public event onScreenClickEventHandler onScreenClickEvent;

        private void FormPlayVideo_Load(object sender, EventArgs e)
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
        }

        private void onScreenClick()
        {
            if (onScreenClickEvent != null)
            {
                onScreenClickEvent(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onScreenClick();
        }
    }
}
