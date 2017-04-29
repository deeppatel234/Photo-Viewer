namespace PhotoViewer
{
    partial class SlideShow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideShow));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fatsformward = new System.Windows.Forms.Button();
            this.fast = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.slow = new System.Windows.Forms.Button();
            this.slowbackword = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.num = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.photoName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.fatsformward);
            this.flowLayoutPanel1.Controls.Add(this.fast);
            this.flowLayoutPanel1.Controls.Add(this.pause);
            this.flowLayoutPanel1.Controls.Add(this.slow);
            this.flowLayoutPanel1.Controls.Add(this.slowbackword);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 452);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 48);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // fatsformward
            // 
            this.fatsformward.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fatsformward.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fatsformward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fatsformward.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fatsformward.Image = ((System.Drawing.Image)(resources.GetObject("fatsformward.Image")));
            this.fatsformward.Location = new System.Drawing.Point(890, 3);
            this.fatsformward.Name = "fatsformward";
            this.fatsformward.Size = new System.Drawing.Size(57, 47);
            this.fatsformward.TabIndex = 1;
            this.fatsformward.UseVisualStyleBackColor = false;
            this.fatsformward.Click += new System.EventHandler(this.fatsformward_Click);
            // 
            // fast
            // 
            this.fast.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fast.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fast.Image = ((System.Drawing.Image)(resources.GetObject("fast.Image")));
            this.fast.Location = new System.Drawing.Point(827, 3);
            this.fast.Name = "fast";
            this.fast.Size = new System.Drawing.Size(57, 47);
            this.fast.TabIndex = 2;
            this.fast.UseVisualStyleBackColor = false;
            this.fast.Click += new System.EventHandler(this.fast_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(764, 3);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(57, 47);
            this.pause.TabIndex = 3;
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // slow
            // 
            this.slow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.slow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.slow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.slow.Image = ((System.Drawing.Image)(resources.GetObject("slow.Image")));
            this.slow.Location = new System.Drawing.Point(701, 3);
            this.slow.Name = "slow";
            this.slow.Size = new System.Drawing.Size(57, 47);
            this.slow.TabIndex = 4;
            this.slow.UseVisualStyleBackColor = false;
            this.slow.Click += new System.EventHandler(this.slow_Click);
            // 
            // slowbackword
            // 
            this.slowbackword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.slowbackword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.slowbackword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slowbackword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.slowbackword.Image = ((System.Drawing.Image)(resources.GetObject("slowbackword.Image")));
            this.slowbackword.Location = new System.Drawing.Point(638, 3);
            this.slowbackword.Name = "slowbackword";
            this.slowbackword.Size = new System.Drawing.Size(57, 47);
            this.slowbackword.TabIndex = 5;
            this.slowbackword.UseVisualStyleBackColor = false;
            this.slowbackword.Click += new System.EventHandler(this.slowbackword_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.num);
            this.panel2.Location = new System.Drawing.Point(141, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 39);
            this.panel2.TabIndex = 6;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num.Location = new System.Drawing.Point(-5, 7);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(210, 25);
            this.num.TabIndex = 7;
            this.num.Text = "Current Image Number";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.photoName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 30);
            this.panel1.TabIndex = 1;
            // 
            // photoName
            // 
            this.photoName.AutoSize = true;
            this.photoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.photoName.Location = new System.Drawing.Point(3, 9);
            this.photoName.Name = "photoName";
            this.photoName.Size = new System.Drawing.Size(86, 17);
            this.photoName.TabIndex = 0;
            this.photoName.Text = "Photo Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 422);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SlideShow";
            this.Text = "SlideShow";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label photoName;
        private System.Windows.Forms.Button fatsformward;
        private System.Windows.Forms.Button fast;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button slow;
        private System.Windows.Forms.Button slowbackword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}