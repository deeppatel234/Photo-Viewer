using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class MainPage : Form
    {
        string path;
        ArrayList al = new ArrayList();
        string[] files;
        Bitmap bm;
        int i = 0;
        public MainPage(string path)
        {
            InitializeComponent();
            this.path = path;

            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(Form1_KeyDown);
            pictureBox.MouseWheel += new MouseEventHandler(this.Form1_MouseWheel);
            ImagePanel.AutoScroll = true;
            this.WindowState = FormWindowState.Normal;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loadnewimage();
            infolabel.Text = "Photo Viewer";
            
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (e.Delta > 0)
            {
                pictureBox.Height = (int)(pictureBox.Height + (pictureBox.Height / 7.25));
                pictureBox.Width = (int)(pictureBox.Width + (pictureBox.Width / 7.25));
            }
            else
            {
                pictureBox.Height = (int)(pictureBox.Height - (pictureBox.Height / 7.25));
                pictureBox.Width = (int)(pictureBox.Width - (pictureBox.Width / 7.25));
            }
        }

        private void loadnewimage()
        {
            al.Clear();
            string[] f = Directory.GetFiles(path);
            for (int k = 0; k < f.Length; k++)
            {
                if (f[k].EndsWith(".jpg") || f[k].EndsWith(".bmp") || f[k].EndsWith(".ico") || f[k].EndsWith(".emf") || f[k].EndsWith(".wmf") || f[k].EndsWith(".gif")
                    || f[k].EndsWith(".jpeg") || f[k].EndsWith(".png"))
                {
                    al.Add(f[k]);
                }
            }

            files = (string[])al.ToArray(typeof(string));

            AlbumName.Text = "Album : " + Path.GetFileName(Path.GetDirectoryName(path));

            if (files.Length > 0)
            {
                pictureBox.Size = new Size(ImagePanel.Width, ImagePanel.Height);
                pictureBox.Image = Image.FromFile(files[0]);
                currentpath.Text = path;
                PhotoName.Text = Path.GetFileName(files[0]);
                bm = (Bitmap)Bitmap.FromFile(files[0]);
            }
            else
            {

                PhotoName.Text = "Photos Not Found";
                pictureBox.Image = Properties.Resources.noimage;
                currentpath.Text = "Photo(s) Not Found             " + path;
            }
        }

        private void fileselect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                al.Clear();
                currentpath.Text = folderBrowserDialog1.SelectedPath;
                path = folderBrowserDialog1.SelectedPath;
                loadnewimage();
            }
        }

        private void PlaySlides_btn_Click(object sender, EventArgs e)
        {
            SlideShow ss = new SlideShow(i, files);
            ss.Show();
        }

        private void info_Click(object sender, EventArgs e)
        {
            Information info = new Information(files[i]);
            info.Show();
        }

        int temp = 2;
        private void rotate_btn_Click(object sender, EventArgs e)
        {
            if (temp % 2 == 0)
                bm.RotateFlip(RotateFlipType.Rotate90FlipY);
            else
                bm.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox.Image = bm;
            temp++;
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            temp = 2;
            if (files.Length > i)
            {
                //   if (files[i] != null && (ImagePanel.Width == pictureBox.Width) && (ImagePanel.Height == pictureBox.Height) )
                if (files[i] != null)
                {
              //      pictureBox.Width = ImagePanel.Width;
              //      pictureBox.Height = ImagePanel.Height;
                    if (i == files.Length - 1)
                        i = -1;
                    i++;
                    pictureBox.Load(files[i]);
                    bm = (Bitmap)Bitmap.FromFile(files[i]);
                    PhotoName.Text = Path.GetFileName(files[i]);
                }
            }

        }

        private void Prev_btn_Click(object sender, EventArgs e)
        {
            temp = 2;
            if (files.Length > i)
            {

                //  if (files[i] != null && (ImagePanel.Width == pictureBox.Width) && (ImagePanel.Height == pictureBox.Height))
                if (files[i] != null)
                {
              //      pictureBox.Width = ImagePanel.Width;
              //      pictureBox.Height = ImagePanel.Height;
                    if (i == 0)
                        i = files.Length;
                    i--;
                    if (files[i] != null && i < files.Length)
                    {
                        pictureBox.Load(files[i]);
                        bm = (Bitmap)Bitmap.FromFile(files[i]);
                        PhotoName.Text = Path.GetFileName(files[i]);
                    }
                }
            }

        }

        int fulltemp = 2;
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    Next_btn.PerformClick();
                    break;
                case Keys.Left:
                    Prev_btn.PerformClick();
                    break;
                case Keys.R:
                    rotate_btn.PerformClick();
                    break;
                case Keys.I:
                    info.PerformClick();
                    break;
                case Keys.P:
                    PlaySlides_btn.PerformClick();
                    break;
                case Keys.Subtract:
                    zoomin_btn.PerformClick();
                    break;
                case Keys.Add:
                    zoomout_btn.PerformClick();
                    break;
                case Keys.B:
                    fileselect.PerformClick();
                    break;
                case Keys.F5:
                    rphotos.PerformClick();
                    break;
                case Keys.F:
                    FullScreen fs = new FullScreen(files, i);
                    fs.Show();
                    break;
                case Keys.H:
                    helpbutton.PerformClick();
                    break;
                case Keys.F11:
                    if (fulltemp % 2 == 0)
                    {
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        this.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                        this.WindowState = FormWindowState.Normal;
                    }
                    fulltemp++;
                    break;
            }
        }
 
        private void sizechangeevent(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                pictureBox.Width = ImagePanel.Width;
                pictureBox.Height = ImagePanel.Height;
            }
        }

        private Point StartPoints;

        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                StartPoints = e.Location;
        }

        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point changePoint = new Point(e.Location.X - StartPoints.X,
                                              e.Location.Y - StartPoints.Y);
                ImagePanel.AutoScrollPosition = new Point(-ImagePanel.AutoScrollPosition.X - changePoint.X,
                                                      -ImagePanel.AutoScrollPosition.Y - changePoint.Y);
            }
        }




        private void zoomout_btn_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Height = (int)(pictureBox.Height + (pictureBox.Height / 2.25));
            pictureBox.Width = (int)(pictureBox.Width + (pictureBox.Width / 2.25));
        }

        private void zoomin_btn_Click(object sender, EventArgs e)
        {
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Height = (int)(pictureBox.Height - (pictureBox.Height / 2.25));
            pictureBox.Width = (int)(pictureBox.Width - (pictureBox.Width / 2.25));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox.Height = ImagePanel.Height;
            pictureBox.Width = ImagePanel.Width;
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void strechbtn_Click(object sender, EventArgs e)
        {
            pictureBox.Height = ImagePanel.Height;
            pictureBox.Width = ImagePanel.Width;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Centerbtn_Click(object sender, EventArgs e)
        {
            pictureBox.Height = ImagePanel.Height;
            pictureBox.Width = ImagePanel.Width;
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void InformationEnter(object sender, EventArgs e)
        {
            infolabel.Text = "Photo Details";
        }

        private void InformationExit(object sender, EventArgs e)
        {
            infolabel.Text = "Photo Viewer";
        }

        private void RoteteEnter(object sender, EventArgs e)
        {
            infolabel.Text = "Rotate Photo"; 
        }

        private void Zoomout(object sender, EventArgs e)
        {
            infolabel.Text = "Zoom Out";
        }

        private void zoominenter(object sender, EventArgs e)
        {
            infolabel.Text = "Zoom In";
        }

        private void nextimage(object sender, EventArgs e)
        {
            infolabel.Text = "Next Image";
        }

        private void play(object sender, EventArgs e)
        {
            infolabel.Text = "Play SlideShow";
        }

        private void prew(object sender, EventArgs e)
        {
            infolabel.Text = "Previous Image";
        }

        private void albumname(object sender, EventArgs e)
        {
            infolabel.Text = "Current Album";
        }

        private void imagenameenter(object sender, EventArgs e)
        {
            infolabel.Text = "Photo Name";
        }

        private void selectfileenter(object sender, EventArgs e)
        {
            infolabel.Text = "Browse Folder";
        }

        private void imagecenterenter(object sender, EventArgs e)
        {
            infolabel.Text = "SizeMode : Center";
        }

        private void strech(object sender, EventArgs e)
        {
            infolabel.Text = "SizeMode : Strech";
        }

        private void normalenter(object sender, EventArgs e)
        {
            infolabel.Text = "SizeMode : Normal";
        }

        private void pathenter(object sender, EventArgs e)
        {
            infolabel.Text = "Current Path";
        }

        private void rphotos_Click(object sender, EventArgs e)
        {
            loadnewimage();
        }

        private void helpenter(object sender, EventArgs e)
        {
            infolabel.Text = "Help";
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            Help hlp = new Help();
            hlp.Show();
        }
    }
}
