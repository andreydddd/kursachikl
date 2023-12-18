namespace kursachikl
{
    partial class Meal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.одноместныеНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двухместныеНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяКВыборуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.посмотретьНаКартеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одноместныеНомераToolStripMenuItem,
            this.двухместныеНомераToolStripMenuItem,
            this.вернутьсяКВыборуToolStripMenuItem,
            this.посмотретьНаКартеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // одноместныеНомераToolStripMenuItem
            // 
            this.одноместныеНомераToolStripMenuItem.Name = "одноместныеНомераToolStripMenuItem";
            this.одноместныеНомераToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.одноместныеНомераToolStripMenuItem.Text = "Одноместные номера";
            this.одноместныеНомераToolStripMenuItem.Click += new System.EventHandler(this.одноместныеНомераToolStripMenuItem_Click);
            // 
            // двухместныеНомераToolStripMenuItem
            // 
            this.двухместныеНомераToolStripMenuItem.Name = "двухместныеНомераToolStripMenuItem";
            this.двухместныеНомераToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.двухместныеНомераToolStripMenuItem.Text = "Двухместные номера";
            this.двухместныеНомераToolStripMenuItem.Click += new System.EventHandler(this.двухместныеНомераToolStripMenuItem_Click);
            // 
            // вернутьсяКВыборуToolStripMenuItem
            // 
            this.вернутьсяКВыборуToolStripMenuItem.Name = "вернутьсяКВыборуToolStripMenuItem";
            this.вернутьсяКВыборуToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.вернутьсяКВыборуToolStripMenuItem.Text = "Вернуться к выбору";
            this.вернутьсяКВыборуToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяКВыборуToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 199);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 160);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(627, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(566, 192);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // посмотретьНаКартеToolStripMenuItem
            // 
            this.посмотретьНаКартеToolStripMenuItem.Name = "посмотретьНаКартеToolStripMenuItem";
            this.посмотретьНаКартеToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.посмотретьНаКартеToolStripMenuItem.Text = "посмотреть на карте";
            this.посмотретьНаКартеToolStripMenuItem.Click += new System.EventHandler(this.посмотретьНаКартеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kursachikl.Properties.Resources._8907545;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1283, 770);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Meal";
            this.Text = "Meal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem одноместныеНомераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двухместныеНомераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяКВыборуToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem посмотретьНаКартеToolStripMenuItem;
    }
}