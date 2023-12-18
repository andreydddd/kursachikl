namespace kursachikl
{
    partial class registren
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.show_glas = new System.Windows.Forms.PictureBox();
            this.hide_glaz = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_glas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_glaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "РЕГИСТРАЦИЯ";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(112, 177);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(234, 20);
            this.textBox.TabIndex = 3;
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(112, 291);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(234, 20);
            this.passbox.TabIndex = 4;
            this.passbox.UseSystemPasswordChar = true;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(135, 408);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(160, 47);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.register_button);
            this.panel3.Controls.Add(this.passbox);
            this.panel3.Controls.Add(this.show_glas);
            this.panel3.Controls.Add(this.textBox);
            this.panel3.Controls.Add(this.hide_glaz);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Location = new System.Drawing.Point(199, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 568);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(16, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 100);
            this.panel4.TabIndex = 0;
            // 
            // show_glas
            // 
            this.show_glas.Image = global::kursachikl.Properties.Resources.show;
            this.show_glas.Location = new System.Drawing.Point(360, 269);
            this.show_glas.Name = "show_glas";
            this.show_glas.Size = new System.Drawing.Size(57, 56);
            this.show_glas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.show_glas.TabIndex = 7;
            this.show_glas.TabStop = false;
            this.show_glas.Click += new System.EventHandler(this.show_glas_Click);
            // 
            // hide_glaz
            // 
            this.hide_glaz.Image = global::kursachikl.Properties.Resources.hide;
            this.hide_glaz.Location = new System.Drawing.Point(360, 269);
            this.hide_glaz.Name = "hide_glaz";
            this.hide_glaz.Size = new System.Drawing.Size(57, 56);
            this.hide_glaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hide_glaz.TabIndex = 6;
            this.hide_glaz.TabStop = false;
            this.hide_glaz.Click += new System.EventHandler(this.hide_glaz_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::kursachikl.Properties.Resources.user;
            this.pictureBox4.Location = new System.Drawing.Point(30, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kursachikl.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(40, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::kursachikl.Properties.Resources.icons8_authorization_50;
            this.pictureBox6.Location = new System.Drawing.Point(30, 269);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 56);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::kursachikl.Properties.Resources.temanorm;
            this.pictureBox2.Location = new System.Drawing.Point(0, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1201, 771);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // registren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(841, 671);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "registren";
            this.Text = "fun";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_glas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_glaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.PictureBox hide_glaz;
        private System.Windows.Forms.PictureBox show_glas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}