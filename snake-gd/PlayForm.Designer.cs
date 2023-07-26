namespace snake_gd
{
    partial class Play_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play_form));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picMap = new System.Windows.Forms.PictureBox();
            this.lbscore = new System.Windows.Forms.Label();
            this.btplay = new System.Windows.Forms.Button();
            this.btpau = new System.Windows.Forms.Button();
            this.bthowplay = new System.Windows.Forms.Button();
            this.btquit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picMap
            // 
            this.picMap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picMap.Location = new System.Drawing.Point(22, 73);
            this.picMap.Margin = new System.Windows.Forms.Padding(2);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(581, 406);
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            // 
            // lbscore
            // 
            this.lbscore.AutoSize = true;
            this.lbscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbscore.ForeColor = System.Drawing.Color.Red;
            this.lbscore.Location = new System.Drawing.Point(704, 134);
            this.lbscore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(21, 24);
            this.lbscore.TabIndex = 23;
            this.lbscore.Text = "0";
            // 
            // btplay
            // 
            this.btplay.BackColor = System.Drawing.Color.Silver;
            this.btplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btplay.ForeColor = System.Drawing.Color.Blue;
            this.btplay.Location = new System.Drawing.Point(641, 194);
            this.btplay.Margin = new System.Windows.Forms.Padding(2);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(82, 41);
            this.btplay.TabIndex = 1;
            this.btplay.Text = "Chơi";
            this.btplay.UseVisualStyleBackColor = false;
            this.btplay.Click += new System.EventHandler(this.btplay_Click);
            // 
            // btpau
            // 
            this.btpau.BackColor = System.Drawing.Color.Silver;
            this.btpau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btpau.ForeColor = System.Drawing.Color.Blue;
            this.btpau.Location = new System.Drawing.Point(628, 339);
            this.btpau.Margin = new System.Windows.Forms.Padding(2);
            this.btpau.Name = "btpau";
            this.btpau.Size = new System.Drawing.Size(39, 37);
            this.btpau.TabIndex = 5;
            this.btpau.Text = "▶";
            this.btpau.UseVisualStyleBackColor = false;
            this.btpau.Click += new System.EventHandler(this.btpau_Click);
            // 
            // bthowplay
            // 
            this.bthowplay.BackColor = System.Drawing.Color.Silver;
            this.bthowplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bthowplay.ForeColor = System.Drawing.Color.Blue;
            this.bthowplay.Location = new System.Drawing.Point(707, 339);
            this.bthowplay.Margin = new System.Windows.Forms.Padding(2);
            this.bthowplay.Name = "bthowplay";
            this.bthowplay.Size = new System.Drawing.Size(39, 37);
            this.bthowplay.TabIndex = 6;
            this.bthowplay.Text = "?";
            this.bthowplay.UseVisualStyleBackColor = false;
            this.bthowplay.Click += new System.EventHandler(this.bthowplay_Click);
            // 
            // btquit
            // 
            this.btquit.BackColor = System.Drawing.Color.Silver;
            this.btquit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btquit.ForeColor = System.Drawing.Color.Blue;
            this.btquit.Location = new System.Drawing.Point(642, 271);
            this.btquit.Margin = new System.Windows.Forms.Padding(2);
            this.btquit.Name = "btquit";
            this.btquit.Size = new System.Drawing.Size(82, 41);
            this.btquit.TabIndex = 3;
            this.btquit.Text = "Thoát";
            this.btquit.UseVisualStyleBackColor = false;
            this.btquit.Click += new System.EventHandler(this.btquit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(638, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Điểm: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(628, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(223, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Snake Game";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(628, 430);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 28);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(607, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chọn màu rắn:";
            // 
            // Play_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbscore);
            this.Controls.Add(this.btplay);
            this.Controls.Add(this.btpau);
            this.Controls.Add(this.bthowplay);
            this.Controls.Add(this.btquit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMap);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Play_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chơi";
            this.Load += new System.EventHandler(this.Play_form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Play_form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.Label lbscore;
        private System.Windows.Forms.Button btplay;
        private System.Windows.Forms.Button btpau;
        private System.Windows.Forms.Button bthowplay;
        private System.Windows.Forms.Button btquit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}