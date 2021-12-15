namespace SantaIsComing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.bottomPipe = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tryagain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPipe
            // 
            this.topPipe.Image = ((System.Drawing.Image)(resources.GetObject("topPipe.Image")));
            this.topPipe.Location = new System.Drawing.Point(470, 5);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(190, 180);
            this.topPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topPipe.TabIndex = 0;
            this.topPipe.TabStop = false;
            this.topPipe.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Bird
            // 
            this.Bird.Image = ((System.Drawing.Image)(resources.GetObject("Bird.Image")));
            this.Bird.Location = new System.Drawing.Point(68, 454);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(192, 183);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            this.Bird.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(1, 795);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(738, 107);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            // 
            // bottomPipe
            // 
            this.bottomPipe.Image = ((System.Drawing.Image)(resources.GetObject("bottomPipe.Image")));
            this.bottomPipe.Location = new System.Drawing.Point(542, 563);
            this.bottomPipe.Name = "bottomPipe";
            this.bottomPipe.Size = new System.Drawing.Size(118, 250);
            this.bottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottomPipe.TabIndex = 3;
            this.bottomPipe.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1, -5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(204, 190);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.Location = new System.Drawing.Point(25, 188);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(153, 47);
            this.ScoreLabel.TabIndex = 5;
            this.ScoreLabel.Text = "Score : 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 680);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tryagain
            // 
            this.tryagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tryagain.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tryagain.Location = new System.Drawing.Point(257, 334);
            this.tryagain.Name = "tryagain";
            this.tryagain.Size = new System.Drawing.Size(309, 134);
            this.tryagain.TabIndex = 7;
            this.tryagain.Text = "haha u suck! again?";
            this.tryagain.UseVisualStyleBackColor = true;
            this.tryagain.Visible = false;
            this.tryagain.Click += new System.EventHandler(this.tryagain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(733, 894);
            this.Controls.Add(this.tryagain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.bottomPipe);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.topPipe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox bottomPipe;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button tryagain;
    }
}

