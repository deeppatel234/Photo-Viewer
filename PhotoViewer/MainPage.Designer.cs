namespace PhotoViewer
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.helpbutton = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.rotate_btn = new System.Windows.Forms.Button();
            this.zoomin_btn = new System.Windows.Forms.Button();
            this.zoomout_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            this.PlaySlides_btn = new System.Windows.Forms.Button();
            this.Prev_btn = new System.Windows.Forms.Button();
            this.AlbumNamePanel = new System.Windows.Forms.Panel();
            this.AlbumName = new System.Windows.Forms.Label();
            this.ChangeFolderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentpath = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Centerbtn = new System.Windows.Forms.Button();
            this.strechbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infolabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rphotos = new System.Windows.Forms.Button();
            this.fileselect = new System.Windows.Forms.Button();
            this.PhotoNamePanel = new System.Windows.Forms.Panel();
            this.PhotoName = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.AlbumNamePanel.SuspendLayout();
            this.ChangeFolderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.PhotoNamePanel.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.ControlPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AlbumNamePanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.helpbutton);
            this.ControlPanel.Controls.Add(this.info);
            this.ControlPanel.Controls.Add(this.rotate_btn);
            this.ControlPanel.Controls.Add(this.zoomin_btn);
            this.ControlPanel.Controls.Add(this.zoomout_btn);
            this.ControlPanel.Controls.Add(this.Next_btn);
            this.ControlPanel.Controls.Add(this.PlaySlides_btn);
            this.ControlPanel.Controls.Add(this.Prev_btn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ControlPanel.Location = new System.Drawing.Point(266, 3);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(521, 43);
            this.ControlPanel.TabIndex = 0;
            // 
            // helpbutton
            // 
            this.helpbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.helpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpbutton.Image = ((System.Drawing.Image)(resources.GetObject("helpbutton.Image")));
            this.helpbutton.Location = new System.Drawing.Point(473, 3);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(45, 43);
            this.helpbutton.TabIndex = 14;
            this.helpbutton.UseVisualStyleBackColor = false;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            this.helpbutton.MouseEnter += new System.EventHandler(this.helpenter);
            this.helpbutton.MouseLeave += new System.EventHandler(this.InformationEnter);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(422, 3);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(45, 43);
            this.info.TabIndex = 7;
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            this.info.MouseEnter += new System.EventHandler(this.InformationEnter);
            this.info.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // rotate_btn
            // 
            this.rotate_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rotate_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rotate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotate_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rotate_btn.Image = ((System.Drawing.Image)(resources.GetObject("rotate_btn.Image")));
            this.rotate_btn.Location = new System.Drawing.Point(364, 3);
            this.rotate_btn.Name = "rotate_btn";
            this.rotate_btn.Size = new System.Drawing.Size(52, 43);
            this.rotate_btn.TabIndex = 8;
            this.rotate_btn.UseVisualStyleBackColor = false;
            this.rotate_btn.Click += new System.EventHandler(this.rotate_btn_Click);
            this.rotate_btn.MouseEnter += new System.EventHandler(this.RoteteEnter);
            this.rotate_btn.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // zoomin_btn
            // 
            this.zoomin_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zoomin_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zoomin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomin_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zoomin_btn.Image = ((System.Drawing.Image)(resources.GetObject("zoomin_btn.Image")));
            this.zoomin_btn.Location = new System.Drawing.Point(308, 3);
            this.zoomin_btn.Name = "zoomin_btn";
            this.zoomin_btn.Size = new System.Drawing.Size(50, 43);
            this.zoomin_btn.TabIndex = 9;
            this.zoomin_btn.UseVisualStyleBackColor = false;
            this.zoomin_btn.Click += new System.EventHandler(this.zoomin_btn_Click);
            this.zoomin_btn.MouseEnter += new System.EventHandler(this.Zoomout);
            this.zoomin_btn.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // zoomout_btn
            // 
            this.zoomout_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zoomout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zoomout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomout_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zoomout_btn.Image = ((System.Drawing.Image)(resources.GetObject("zoomout_btn.Image")));
            this.zoomout_btn.Location = new System.Drawing.Point(248, 3);
            this.zoomout_btn.Name = "zoomout_btn";
            this.zoomout_btn.Size = new System.Drawing.Size(54, 43);
            this.zoomout_btn.TabIndex = 10;
            this.zoomout_btn.UseVisualStyleBackColor = false;
            this.zoomout_btn.Click += new System.EventHandler(this.zoomout_btn_Click);
            this.zoomout_btn.MouseEnter += new System.EventHandler(this.zoominenter);
            this.zoomout_btn.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // Next_btn
            // 
            this.Next_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next_btn.Image = ((System.Drawing.Image)(resources.GetObject("Next_btn.Image")));
            this.Next_btn.Location = new System.Drawing.Point(188, 3);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(54, 43);
            this.Next_btn.TabIndex = 11;
            this.Next_btn.UseVisualStyleBackColor = false;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            this.Next_btn.MouseEnter += new System.EventHandler(this.nextimage);
            this.Next_btn.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // PlaySlides_btn
            // 
            this.PlaySlides_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlaySlides_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PlaySlides_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaySlides_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlaySlides_btn.Image = ((System.Drawing.Image)(resources.GetObject("PlaySlides_btn.Image")));
            this.PlaySlides_btn.Location = new System.Drawing.Point(134, 3);
            this.PlaySlides_btn.Name = "PlaySlides_btn";
            this.PlaySlides_btn.Size = new System.Drawing.Size(48, 43);
            this.PlaySlides_btn.TabIndex = 12;
            this.PlaySlides_btn.UseVisualStyleBackColor = false;
            this.PlaySlides_btn.Click += new System.EventHandler(this.PlaySlides_btn_Click);
            this.PlaySlides_btn.MouseEnter += new System.EventHandler(this.play);
            this.PlaySlides_btn.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // Prev_btn
            // 
            this.Prev_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prev_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Prev_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prev_btn.Image = ((System.Drawing.Image)(resources.GetObject("Prev_btn.Image")));
            this.Prev_btn.Location = new System.Drawing.Point(75, 3);
            this.Prev_btn.Name = "Prev_btn";
            this.Prev_btn.Size = new System.Drawing.Size(53, 43);
            this.Prev_btn.TabIndex = 13;
            this.Prev_btn.UseVisualStyleBackColor = false;
            this.Prev_btn.Click += new System.EventHandler(this.Prev_btn_Click);
            this.Prev_btn.MouseEnter += new System.EventHandler(this.prew);
            this.Prev_btn.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // AlbumNamePanel
            // 
            this.AlbumNamePanel.Controls.Add(this.AlbumName);
            this.AlbumNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumNamePanel.Location = new System.Drawing.Point(3, 3);
            this.AlbumNamePanel.Name = "AlbumNamePanel";
            this.AlbumNamePanel.Size = new System.Drawing.Size(257, 43);
            this.AlbumNamePanel.TabIndex = 1;
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSize = true;
            this.AlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlbumName.Location = new System.Drawing.Point(0, 6);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(169, 31);
            this.AlbumName.TabIndex = 2;
            this.AlbumName.Text = "Album Name";
            this.AlbumName.MouseEnter += new System.EventHandler(this.albumname);
            this.AlbumName.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // ChangeFolderPanel
            // 
            this.ChangeFolderPanel.ColumnCount = 5;
            this.ChangeFolderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.ChangeFolderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChangeFolderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.ChangeFolderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ChangeFolderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.ChangeFolderPanel.Controls.Add(this.panel1, 1, 0);
            this.ChangeFolderPanel.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.ChangeFolderPanel.Controls.Add(this.panel3, 4, 0);
            this.ChangeFolderPanel.Controls.Add(this.panel2, 3, 0);
            this.ChangeFolderPanel.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.ChangeFolderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChangeFolderPanel.Location = new System.Drawing.Point(0, 415);
            this.ChangeFolderPanel.Name = "ChangeFolderPanel";
            this.ChangeFolderPanel.RowCount = 1;
            this.ChangeFolderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChangeFolderPanel.Size = new System.Drawing.Size(790, 37);
            this.ChangeFolderPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentpath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(102, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 31);
            this.panel1.TabIndex = 5;
            // 
            // currentpath
            // 
            this.currentpath.AutoSize = true;
            this.currentpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentpath.Location = new System.Drawing.Point(3, 4);
            this.currentpath.Name = "currentpath";
            this.currentpath.Size = new System.Drawing.Size(88, 17);
            this.currentpath.TabIndex = 6;
            this.currentpath.Text = "Current Path";
            this.currentpath.MouseEnter += new System.EventHandler(this.pathenter);
            this.currentpath.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Centerbtn);
            this.flowLayoutPanel1.Controls.Add(this.strechbtn);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(321, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 31);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // Centerbtn
            // 
            this.Centerbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Centerbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Centerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Centerbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Centerbtn.Image = ((System.Drawing.Image)(resources.GetObject("Centerbtn.Image")));
            this.Centerbtn.Location = new System.Drawing.Point(3, 3);
            this.Centerbtn.Name = "Centerbtn";
            this.Centerbtn.Size = new System.Drawing.Size(44, 25);
            this.Centerbtn.TabIndex = 5;
            this.Centerbtn.UseVisualStyleBackColor = false;
            this.Centerbtn.Click += new System.EventHandler(this.Centerbtn_Click);
            this.Centerbtn.MouseEnter += new System.EventHandler(this.imagecenterenter);
            this.Centerbtn.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // strechbtn
            // 
            this.strechbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.strechbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.strechbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strechbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.strechbtn.Image = ((System.Drawing.Image)(resources.GetObject("strechbtn.Image")));
            this.strechbtn.Location = new System.Drawing.Point(53, 3);
            this.strechbtn.Name = "strechbtn";
            this.strechbtn.Size = new System.Drawing.Size(44, 25);
            this.strechbtn.TabIndex = 6;
            this.strechbtn.UseVisualStyleBackColor = false;
            this.strechbtn.Click += new System.EventHandler(this.strechbtn_Click);
            this.strechbtn.MouseEnter += new System.EventHandler(this.strech);
            this.strechbtn.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(103, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 25);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.normalenter);
            this.button3.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(619, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 28);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyrights © Deep Patel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.infolabel);
            this.panel2.Location = new System.Drawing.Point(479, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 28);
            this.panel2.TabIndex = 14;
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infolabel.Location = new System.Drawing.Point(3, 7);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(78, 17);
            this.infolabel.TabIndex = 0;
            this.infolabel.Text = "Information";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rphotos);
            this.flowLayoutPanel2.Controls.Add(this.fileselect);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(93, 31);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // rphotos
            // 
            this.rphotos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rphotos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rphotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rphotos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rphotos.Image = ((System.Drawing.Image)(resources.GetObject("rphotos.Image")));
            this.rphotos.Location = new System.Drawing.Point(3, 3);
            this.rphotos.Name = "rphotos";
            this.rphotos.Size = new System.Drawing.Size(39, 28);
            this.rphotos.TabIndex = 6;
            this.rphotos.UseVisualStyleBackColor = false;
            this.rphotos.Click += new System.EventHandler(this.rphotos_Click);
            // 
            // fileselect
            // 
            this.fileselect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileselect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fileselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileselect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileselect.Image = ((System.Drawing.Image)(resources.GetObject("fileselect.Image")));
            this.fileselect.Location = new System.Drawing.Point(48, 3);
            this.fileselect.Name = "fileselect";
            this.fileselect.Size = new System.Drawing.Size(39, 28);
            this.fileselect.TabIndex = 5;
            this.fileselect.UseVisualStyleBackColor = false;
            this.fileselect.Click += new System.EventHandler(this.fileselect_Click);
            // 
            // PhotoNamePanel
            // 
            this.PhotoNamePanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PhotoNamePanel.Controls.Add(this.PhotoName);
            this.PhotoNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhotoNamePanel.Location = new System.Drawing.Point(0, 49);
            this.PhotoNamePanel.Name = "PhotoNamePanel";
            this.PhotoNamePanel.Size = new System.Drawing.Size(790, 32);
            this.PhotoNamePanel.TabIndex = 2;
            // 
            // PhotoName
            // 
            this.PhotoName.AutoSize = true;
            this.PhotoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhotoName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhotoName.Location = new System.Drawing.Point(3, 4);
            this.PhotoName.Name = "PhotoName";
            this.PhotoName.Size = new System.Drawing.Size(120, 25);
            this.PhotoName.TabIndex = 1;
            this.PhotoName.Text = "Photo Name";
            this.PhotoName.MouseEnter += new System.EventHandler(this.imagenameenter);
            this.PhotoName.MouseLeave += new System.EventHandler(this.InformationExit);
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.pictureBox);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Location = new System.Drawing.Point(0, 81);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(790, 334);
            this.ImagePanel.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(787, 340);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(790, 452);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.PhotoNamePanel);
            this.Controls.Add(this.ChangeFolderPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Photo Viewer";
            this.SizeChanged += new System.EventHandler(this.sizechangeevent);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.AlbumNamePanel.ResumeLayout(false);
            this.AlbumNamePanel.PerformLayout();
            this.ChangeFolderPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.PhotoNamePanel.ResumeLayout(false);
            this.PhotoNamePanel.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel ControlPanel;
        private System.Windows.Forms.Panel AlbumNamePanel;
        private System.Windows.Forms.TableLayoutPanel ChangeFolderPanel;
        private System.Windows.Forms.Panel PhotoNamePanel;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Label PhotoName;
        private System.Windows.Forms.Label AlbumName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label currentpath;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button rotate_btn;
        private System.Windows.Forms.Button zoomin_btn;
        private System.Windows.Forms.Button zoomout_btn;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Button PlaySlides_btn;
        private System.Windows.Forms.Button Prev_btn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Centerbtn;
        private System.Windows.Forms.Button strechbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button rphotos;
        private System.Windows.Forms.Button fileselect;
        private System.Windows.Forms.Button helpbutton;
    }
}