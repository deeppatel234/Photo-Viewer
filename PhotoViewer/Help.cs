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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            helptext.Text = "Photo Viewer " + '\n' +
                           "Version 1.0.0" + "\n" +
                           "Copyrights © Deep Patel" + "\n\n" +
                           "Developed By : " +
                           " Deep Patel " + '\n' +
                           "Microsoft Student Partner" + '\n' +
                           "Mail : deep.patel@studentpartner.com" + '\n' +
                           "Mobile No : +91 9624184236" +
                           "\n\n" +
                           "Microsoft Store Publisher Name : " + '\n' + "DEEPPATEL";
            keyss.Text = "";
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyboardenter(object sender, EventArgs e)
        {
            keyss.Text = "\n\n" + ": F" + '\n' +
                                  ": F11" + '\n' +
                                  ": → (RIGHT ARROW)" + '\n' +
                                  ": ← (LEFT ARROW)" + '\n' +
                                  ": R" + '\n' +
                                  ": I " + '\n' +
                                  ": P" + '\n' +
                                  ": - (Substract)" + '\n' +
                                  ": + (Addition)" + '\n' +
                                  ": B" + '\n' +
                                  ": F5" + '\n' +
                                  ": H";
            helptext.Text = "Keyboard Sortcuts " +  "\n\n" +
                            "Full Screen (Photo)     "+ '\n' +
                            "Full Screen (Photo Viewer) " + '\n' +
                            "Next Image                 " + '\n' +
                            "Previous Image             " + '\n' +
                            "Rotate Image               " + '\n' +
                            "Image Information          " + '\n' +
                            "Play Slide Show            " + '\n' +
                            "Zoom In                    " + '\n' +
                            "Zoom Out                   " + '\n' +
                            "Browse Folder              " + '\n' +
                            "Refresh Folder             " + '\n' +
                            "Help                       " ;
                            
        }

        private void Aboutenter(object sender, EventArgs e)
        {
            helptext.Text = "Photo Viewer " + '\n' + 
                            "Version 1.0.0" + "\n" +
                            "Copyrights © Deep Patel" + "\n\n" +
                            "Developed By : " +
                            " Deep Patel " +  '\n' +
                            "Microsoft Student Partner" + '\n' +
                            "Mail : deep.patel@studentpartner.com" + '\n' +
                            "Mobile No : +91 9624184236" + 
                            "\n\n" + 
                            "Microsoft Store Publisher Name : " + '\n' + "DEEPPATEL";
            keyss.Text = "";
        }

        private void sortout(object sender, EventArgs e)
        {
            keyss.Text = "";
        }
    }
}
