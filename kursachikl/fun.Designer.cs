namespace kursachikl
{
    partial class fun
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxname1 = new System.Windows.Forms.TextBox();
            this.textBoxpass1 = new System.Windows.Forms.TextBox();
            this.voiti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.show_box = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hide_box = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kursachikl.Properties.Resources.to_grant_authorization;
            this.pictureBox1.Location = new System.Drawing.Point(14, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxname1
            // 
            this.textBoxname1.Location = new System.Drawing.Point(105, 180);
            this.textBoxname1.Name = "textBoxname1";
            this.textBoxname1.Size = new System.Drawing.Size(234, 20);
            this.textBoxname1.TabIndex = 3;
            // 
            // textBoxpass1
            // 
            this.textBoxpass1.Location = new System.Drawing.Point(105, 286);
            this.textBoxpass1.Name = "textBoxpass1";
            this.textBoxpass1.Size = new System.Drawing.Size(234, 20);
            this.textBoxpass1.TabIndex = 4;
            this.textBoxpass1.UseSystemPasswordChar = true;
            this.textBoxpass1.TextChanged += new System.EventHandler(this.textBoxpass1_TextChanged);
            // 
            // voiti
            // 
            this.voiti.Location = new System.Drawing.Point(154, 393);
            this.voiti.Name = "voiti";
            this.voiti.Size = new System.Drawing.Size(126, 57);
            this.voiti.TabIndex = 5;
            this.voiti.Text = "ВОЙТИ";
            this.voiti.UseVisualStyleBackColor = true;
            this.voiti.Click += new System.EventHandler(this.voiti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(151, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "еще нет аккаунта?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.textBoxname1);
            this.panel2.Controls.Add(this.show_box);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.hide_box);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.textBoxpass1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.voiti);
            this.panel2.Location = new System.Drawing.Point(208, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 575);
            this.panel2.TabIndex = 9;
            // 
            // show_box
            // 
            this.show_box.Image = global::kursachikl.Properties.Resources.show;
            this.show_box.Location = new System.Drawing.Point(367, 265);
            this.show_box.Name = "show_box";
            this.show_box.Size = new System.Drawing.Size(50, 50);
            this.show_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.show_box.TabIndex = 7;
            this.show_box.TabStop = false;
            this.show_box.Click += new System.EventHandler(this.show_box_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::kursachikl.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(30, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // hide_box
            // 
            this.hide_box.Image = global::kursachikl.Properties.Resources.hide;
            this.hide_box.Location = new System.Drawing.Point(367, 265);
            this.hide_box.Name = "hide_box";
            this.hide_box.Size = new System.Drawing.Size(50, 50);
            this.hide_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hide_box.TabIndex = 8;
            this.hide_box.TabStop = false;
            this.hide_box.Click += new System.EventHandler(this.hide_box_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::kursachikl.Properties.Resources.icons8_authorization_50;
            this.pictureBox3.Location = new System.Drawing.Point(30, 259);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::kursachikl.Properties.Resources.temanorm;
            this.pictureBox4.Location = new System.Drawing.Point(-21, -9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1277, 821);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // fun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(866, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Name = "fun";
            this.Text = "fun";
            this.Load += new System.EventHandler(this.fun_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxname1;
        private System.Windows.Forms.TextBox textBoxpass1;
        private System.Windows.Forms.Button voiti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox show_box;
        private System.Windows.Forms.PictureBox hide_box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}