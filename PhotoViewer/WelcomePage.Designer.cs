namespace PhotoViewer
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.done = new System.Windows.Forms.Button();
            this.currentpath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fileselect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.done);
            this.panel1.Controls.Add(this.currentpath);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.fileselect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(159, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 231);
            this.panel1.TabIndex = 0;
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.done.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.done.Image = ((System.Drawing.Image)(resources.GetObject("done.Image")));
            this.done.Location = new System.Drawing.Point(570, 189);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(59, 39);
            this.done.TabIndex = 0;
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // currentpath
            // 
            this.currentpath.AutoSize = true;
            this.currentpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentpath.Location = new System.Drawing.Point(146, 197);
            this.currentpath.Name = "currentpath";
            this.currentpath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentpath.Size = new System.Drawing.Size(112, 22);
            this.currentpath.TabIndex = 8;
            this.currentpath.Text = "Current Path";
            this.currentpath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(629, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 39);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileselect
            // 
            this.fileselect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileselect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fileselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileselect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileselect.Image = ((System.Drawing.Image)(resources.GetObject("fileselect.Image")));
            this.fileselect.Location = new System.Drawing.Point(509, 189);
            this.fileselect.Name = "fileselect";
            this.fileselect.Size = new System.Drawing.Size(54, 39);
            this.fileselect.TabIndex = 2;
            this.fileselect.UseVisualStyleBackColor = false;
            this.fileselect.Click += new System.EventHandler(this.fileselect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(596, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Version 1.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(185, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "Photo Viewer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1010, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button fileselect;
        private System.Windows.Forms.Label currentpath;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}