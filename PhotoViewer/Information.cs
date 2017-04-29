using System;
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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        public Information(string fname)
        {
            InitializeComponent();

            Label[] lb = new Label[17];

            for(int i = 0 ; i < 17; i++)
            {
                lb[i] = new Label();
                lb[i].ForeColor = Color.White;
                lb[i].Font = new Font("Arial", 10, FontStyle.Bold);
            }

            FileInfo fi = new FileInfo(fname);
            lb[0].ForeColor = Color.Gray;
            lb[0].Text = "File Name : ";
            lb[1].Width = 300;
            lb[1].Height = 50;
            lb[1].ForeColor = Color.White;
            lb[1].Text = Path.GetFileName(fname);

            lb[2].Text = "  ";

            lb[3].ForeColor = Color.Gray;
            lb[3].Text = "File Extension : ";
            lb[4].ForeColor = Color.White;
            lb[4].Text = Path.GetExtension(fname);

            lb[5].Text = "  ";

            lb[6].ForeColor = Color.Gray;
            lb[6].Text = "File Path : ";
            lb[7].ForeColor = Color.White;
            lb[7].Width = 300;
            lb[7].Height = 50;
            lb[7].Text = fi.FullName;

            lb[8].Text = "  ";

            lb[9].ForeColor = Color.Gray;
            lb[9].Text = "Source : ";
            lb[10].ForeColor = Color.White;
            lb[10].Text = Path.GetPathRoot(fname);

            lb[11].Text = "  ";

            lb[12].ForeColor = Color.Gray;
            lb[12].Text = "File Size : ";
            lb[13].ForeColor = Color.White;
            lb[13].Text = (fi.Length/1024) + "KB";

            lb[14].Text = "  ";

            lb[15].ForeColor = Color.Gray;
            lb[15].Text = "Creation Date : ";
            lb[16].ForeColor = Color.White;
            lb[16].Text = fi.CreationTime.ToString();
            

            for (int i = 0; i < 17; i++)
            {
                flowLayoutPanel1.Controls.Add(lb[i]);
            }
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
