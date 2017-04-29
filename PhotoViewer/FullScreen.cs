using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class FullScreen : Form
    {
        public FullScreen()
        {
            InitializeComponent();
        }

        string[] files;
        int i = 0;
        public FullScreen(string[] files, int i)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(Form1_KeyDown);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.WindowState = FormWindowState.Maximized;
            this.files = files;
            this.i = i;

            if (files.Length > 0)
            {
                pictureBox.Image = Image.FromFile(files[i]);
            }
            else
            {
                pictureBox.Image = Properties.Resources.noimage;
            }
        }

        private void next()
        {
            if (files.Length > i)
            {
                if (files[i] != null)
                {
                    if (i == files.Length - 1)
                        i = -1;
                    i++;
                    pictureBox.Load(files[i]);
                }
            }
        }

        private void prev()
        {
            if (files.Length > i)
            {
                if (files[i] != null)
                {
                    if (i == 0)
                        i = files.Length;
                    i--;
                    if (files[i] != null && i < files.Length)
                    {
                        pictureBox.Load(files[i]);
                    }
                }
            }
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    next();
                    break;
                case Keys.Left:
                    prev();
                    break;
                case Keys.Escape:
                case Keys.F:
                    this.Close();
                    break;
                case Keys.I:
                    Information info = new Information(files[i]);
                    info.Show();
                    break;
            }
        }
    }
}
