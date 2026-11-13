namespace AppEscritorio
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.busquedaLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoDeLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reintegrarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // busquedaLibrosToolStripMenuItem
            // 
            this.busquedaLibrosToolStripMenuItem.Name = "busquedaLibrosToolStripMenuItem";
            this.busquedaLibrosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.busquedaLibrosToolStripMenuItem.Text = "Busqueda libros";
            this.busquedaLibrosToolStripMenuItem.Click += new System.EventHandler(this.busquedaLibrosToolStripMenuItem_Click);
            // 
            // prestamoDeLibroToolStripMenuItem
            // 
            this.prestamoDeLibroToolStripMenuItem.Name = "prestamoDeLibroToolStripMenuItem";
            this.prestamoDeLibroToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.prestamoDeLibroToolStripMenuItem.Text = "Gestor de prestamos";
            this.prestamoDeLibroToolStripMenuItem.Click += new System.EventHandler(this.prestamoDeLibroToolStripMenuItem_Click);
            // 
            // reintegrarLibroToolStripMenuItem
            // 
            this.reintegrarLibroToolStripMenuItem.Name = "reintegrarLibroToolStripMenuItem";
            this.reintegrarLibroToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.reintegrarLibroToolStripMenuItem.Text = "Vista";
            this.reintegrarLibroToolStripMenuItem.Click += new System.EventHandler(this.reintegrarLibroToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaLibrosToolStripMenuItem,
            this.prestamoDeLibroToolStripMenuItem,
            this.reintegrarLibroToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.pictureBox1);
            this.gbMenu.Controls.Add(this.label2);
            this.gbMenu.Controls.Add(this.label1);
            this.gbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMenu.Location = new System.Drawing.Point(0, 27);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(691, 559);
            this.gbMenu.TabIndex = 3;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "groupBox1";
            this.gbMenu.Enter += new System.EventHandler(this.gbMenu_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(118, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecciona una opción del menú superior para comenzar.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(267, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRUM";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(691, 581);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem busquedaLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoDeLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reintegrarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}