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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.busquedaLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoDeLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reintegrarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaLibrosToolStripMenuItem,
            this.verPrestamosToolStripMenuItem,
            this.ingresarPrestamoToolStripMenuItem,
            this.prestamoDeLibroToolStripMenuItem,
            this.reintegrarLibroToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // busquedaLibrosToolStripMenuItem
            // 
            this.busquedaLibrosToolStripMenuItem.Name = "busquedaLibrosToolStripMenuItem";
            this.busquedaLibrosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.busquedaLibrosToolStripMenuItem.Text = "Busqueda libros";
            // 
            // verPrestamosToolStripMenuItem
            // 
            this.verPrestamosToolStripMenuItem.Name = "verPrestamosToolStripMenuItem";
            this.verPrestamosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.verPrestamosToolStripMenuItem.Text = "Ver prestamos";
            // 
            // ingresarPrestamoToolStripMenuItem
            // 
            this.ingresarPrestamoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarLibrosToolStripMenuItem,
            this.eliminarLibroToolStripMenuItem,
            this.modificarLibroToolStripMenuItem});
            this.ingresarPrestamoToolStripMenuItem.Name = "ingresarPrestamoToolStripMenuItem";
            this.ingresarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.ingresarPrestamoToolStripMenuItem.Text = "Actualizacion de libros";
            this.ingresarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.ingresarPrestamoToolStripMenuItem_Click);
            // 
            // ingresarLibrosToolStripMenuItem
            // 
            this.ingresarLibrosToolStripMenuItem.Name = "ingresarLibrosToolStripMenuItem";
            this.ingresarLibrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarLibrosToolStripMenuItem.Text = "Ingresar libros";
            // 
            // eliminarLibroToolStripMenuItem
            // 
            this.eliminarLibroToolStripMenuItem.Name = "eliminarLibroToolStripMenuItem";
            this.eliminarLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarLibroToolStripMenuItem.Text = "Eliminar libro";
            // 
            // modificarLibroToolStripMenuItem
            // 
            this.modificarLibroToolStripMenuItem.Name = "modificarLibroToolStripMenuItem";
            this.modificarLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarLibroToolStripMenuItem.Text = "modificar libro";
            // 
            // prestamoDeLibroToolStripMenuItem
            // 
            this.prestamoDeLibroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamoDeLibrosToolStripMenuItem,
            this.reinToolStripMenuItem});
            this.prestamoDeLibroToolStripMenuItem.Name = "prestamoDeLibroToolStripMenuItem";
            this.prestamoDeLibroToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.prestamoDeLibroToolStripMenuItem.Text = "Gestor de prestamos";
            // 
            // reintegrarLibroToolStripMenuItem
            // 
            this.reintegrarLibroToolStripMenuItem.Name = "reintegrarLibroToolStripMenuItem";
            this.reintegrarLibroToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.reintegrarLibroToolStripMenuItem.Text = "Vista";
            this.reintegrarLibroToolStripMenuItem.Click += new System.EventHandler(this.reintegrarLibroToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.salirToolStripMenuItem.Text = "Detalle pretamos";
            // 
            // prestamoDeLibrosToolStripMenuItem
            // 
            this.prestamoDeLibrosToolStripMenuItem.Name = "prestamoDeLibrosToolStripMenuItem";
            this.prestamoDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prestamoDeLibrosToolStripMenuItem.Text = "Prestamo de libros";
            // 
            // reinToolStripMenuItem
            // 
            this.reinToolStripMenuItem.Name = "reinToolStripMenuItem";
            this.reinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reinToolStripMenuItem.Text = "Reintegrar libro";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem busquedaLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoDeLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reintegrarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
    }
}