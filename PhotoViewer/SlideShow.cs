using PhotoViewer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class SlideShow : Form
    {
        public SlideShow()
        {
            InitializeComponent();
        }

        int i = 0;
        string[] files;
        public SlideShow(int i,string[] files)
        {
            InitializeComponent();
            this.i = i;
            this.files = files;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            photoName.Text = Path.GetFileName(files[i]);
            num.Text = "Current Delay = 3000" + "ms" + "             "  + (i + 1) + "/" + (files.Length);
            pictureBox1.Load(files[i]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(Form1_KeyDown);
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    Next_btn();
                    break;
                case Keys.Left:
                    Prev_btn();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Space:
                    pause.PerformClick();
                    break;
            }
        }
        
        private void Next_btn()
        {
            timer1.Stop();
            if (files.Length > i)
            {
                if (files[i] != null)
                {
                    if (i == files.Length - 1)
                        i = -1;
                    i++;
                    photoName.Text = Path.GetFileName(files[i]);
                    pictureBox1.Load(files[i]);
                    num.Text = "Current Delay = " + c + "ms" + "             " + (i + 1) + "/" + (files.Length);
                }
            }
            timer1.Start();
        }

        private void Prev_btn()
        {
            timer1.Stop();
            if (files.Length > i)
            {
                if (files[i] != null)
                {
                    if (i == 0)
                        i = files.Length;
                    i--;
                    if (files[i] != null && i < files.Length)
                    {
                        photoName.Text = Path.GetFileName(files[i]);
                        pictureBox1.Load(files[i]);
                        num.Text = "Current Delay = " + c + "ms" + "             " + (i + 1) + "/" + (files.Length);
                    }
                }
            }
            timer1.Start();
        }

        int temp = 2;
        private void pause_Click(object sender, EventArgs e)
        {
            if (temp % 2 == 0)
            {
                pause.Image = Resources.play;
                timer1.Stop();
            }
            else
            {
                pause.Image = Resources.Pause;
                timer1.Start();
            }
            temp++;
        }

        int c = 3000;
        private void slow_Click(object sender, EventArgs e)
        {
            if (c < 10000)
            {
                timer1.Interval = c + 1000;
                c += 1000;
            }

            num.Text = "Current Delay = " + c + "ms"  + "             " +  (i + 1) + "/" + (files.Length);
        }

        private void fast_Click(object sender, EventArgs e)
        {
            if (c > 1000)
            {
                timer1.Interval = c - 1000;
                c -= 1000;    
            }
            num.Text = "Current Delay = " + c + "ms" + "             " + (i + 1) + "/" + (files.Length);
        }

        private void fatsformward_Click(object sender, EventArgs e)
        {
            if (c > 2000)
            {
                timer1.Interval = c - 2000;
                c -= 2000;
            }
            num.Text = "Current Delay = " + c + "ms" + "             "  + (i + 1) + "/" + (files.Length);
        }

        private void slowbackword_Click(object sender, EventArgs e)
        {
            if (c < 8001)
            {
                timer1.Interval = c + 2000;
                c += 2000;
            }
            num.Text = "Current Delay = " + c + "ms" + "             "  + (i + 1) + "/" + (files.Length);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num.Text = "Current Delay = " + c + "ms" + "             "  + (i+1) + "/" + (files.Length);
    
            if (i == files.Length)
                i = 0;
            photoName.Text = Path.GetFileName(files[i]);
            pictureBox1.Load(files[i]);
            i++;

        }
    }
}
