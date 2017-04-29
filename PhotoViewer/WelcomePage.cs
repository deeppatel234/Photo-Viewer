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
    public partial class WelcomePage : Form
    {
        static string path;
        public WelcomePage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(Form1_KeyDown);

            path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            currentpath.Text = path;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
                case Keys.B:
                    fileselect.PerformClick();
                    break;
                case Keys.Enter:
                    done.PerformClick();
                    break;
            }
        }

        private void fileselect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                currentpath.Text = folderBrowserDialog1.SelectedPath;
                path = folderBrowserDialog1.SelectedPath;
            }
        }

        public static void ThreadProc()
        {
            Application.Run(new MainPage(path));
        }

        private void done_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
