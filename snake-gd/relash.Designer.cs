namespace snake_gd
{
    partial class relash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPlay = new System.Windows.Forms.Button();
            this.btquit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bthow = new System.Windows.Forms.Button();
            this.btconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.Turquoise;
            this.btPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btPlay.ForeColor = System.Drawing.Color.Blue;
            this.btPlay.Location = new System.Drawing.Point(224, 212);
            this.btPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(82, 41);
            this.btPlay.TabIndex = 3;
            this.btPlay.Text = "Chơi";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btquit
            // 
            this.btquit.BackColor = System.Drawing.Color.Silver;
            this.btquit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btquit.ForeColor = System.Drawing.Color.Blue;
            this.btquit.Location = new System.Drawing.Point(338, 212);
            this.btquit.Margin = new System.Windows.Forms.Padding(2);
            this.btquit.Name = "btquit";
            this.btquit.Size = new System.Drawing.Size(82, 41);
            this.btquit.TabIndex = 7;
            this.btquit.Text = "Thoát";
            this.btquit.UseVisualStyleBackColor = false;
            this.btquit.Click += new System.EventHandler(this.btquit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(39, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snake";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(29, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome ";
            // 
            // bthow
            // 
            this.bthow.BackColor = System.Drawing.Color.Silver;
            this.bthow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bthow.ForeColor = System.Drawing.Color.Blue;
            this.bthow.Location = new System.Drawing.Point(86, 202);
            this.bthow.Margin = new System.Windows.Forms.Padding(2);
            this.bthow.Name = "bthow";
            this.bthow.Size = new System.Drawing.Size(27, 29);
            this.bthow.TabIndex = 10;
            this.bthow.Text = "?";
            this.bthow.UseVisualStyleBackColor = false;
            this.bthow.Click += new System.EventHandler(this.bthow_Click);
            // 
            // btconnect
            // 
            this.btconnect.BackColor = System.Drawing.Color.Silver;
            this.btconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(163)));
            this.btconnect.ForeColor = System.Drawing.Color.Blue;
            this.btconnect.Location = new System.Drawing.Point(34, 202);
            this.btconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btconnect.Name = "btconnect";
            this.btconnect.Size = new System.Drawing.Size(27, 29);
            this.btconnect.TabIndex = 11;
            this.btconnect.Text = "⟳";
            this.btconnect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btconnect.UseVisualStyleBackColor = false;
            this.btconnect.Click += new System.EventHandler(this.btconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(39, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Game";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // relash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 296);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btconnect);
            this.Controls.Add(this.bthow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btquit);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "relash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.relash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btquit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bthow;
        private System.Windows.Forms.Button btconnect;
        private System.Windows.Forms.Label label3;
    }
}

