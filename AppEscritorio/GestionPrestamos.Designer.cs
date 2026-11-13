namespace AppEscritorio
{
    partial class GestionPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPrestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btNuevoPrestamo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbGestionDeLibros = new System.Windows.Forms.GroupBox();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btReintegrar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDelLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbGestionDeLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // btNuevoPrestamo
            // 
            this.btNuevoPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btNuevoPrestamo.FlatAppearance.BorderSize = 0;
            this.btNuevoPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevoPrestamo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoPrestamo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNuevoPrestamo.Location = new System.Drawing.Point(336, 99);
            this.btNuevoPrestamo.Name = "btNuevoPrestamo";
            this.btNuevoPrestamo.Size = new System.Drawing.Size(197, 45);
            this.btNuevoPrestamo.TabIndex = 11;
            this.btNuevoPrestamo.Text = "Nuevo Préstamo";
            this.btNuevoPrestamo.UseVisualStyleBackColor = false;
            this.btNuevoPrestamo.Click += new System.EventHandler(this.btNuevoPrestamo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // gbGestionDeLibros
            // 
            this.gbGestionDeLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.gbGestionDeLibros.Controls.Add(this.dgvPrestamos);
            this.gbGestionDeLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGestionDeLibros.Location = new System.Drawing.Point(61, 164);
            this.gbGestionDeLibros.Name = "gbGestionDeLibros";
            this.gbGestionDeLibros.Size = new System.Drawing.Size(1007, 458);
            this.gbGestionDeLibros.TabIndex = 7;
            this.gbGestionDeLibros.TabStop = false;
            this.gbGestionDeLibros.Text = " ";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(26)))));
            this.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPrestamos.ColumnHeadersHeight = 45;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreDelLibro,
            this.Lector,
            this.FechaPrestamo,
            this.FechaEsperada,
            this.Estado,
            this.Multa});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPrestamos.EnableHeadersVisualStyles = false;
            this.dgvPrestamos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvPrestamos.Location = new System.Drawing.Point(21, 35);
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.RowTemplate.Height = 45;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(962, 404);
            this.dgvPrestamos.TabIndex = 0;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(288, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = " Gestión de Préstamos";
            // 
            // btReintegrar
            // 
            this.btReintegrar.BackColor = System.Drawing.Color.MediumPurple;
            this.btReintegrar.FlatAppearance.BorderSize = 0;
            this.btReintegrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReintegrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReintegrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btReintegrar.Location = new System.Drawing.Point(604, 99);
            this.btReintegrar.Name = "btReintegrar";
            this.btReintegrar.Size = new System.Drawing.Size(114, 45);
            this.btReintegrar.TabIndex = 12;
            this.btReintegrar.Text = "Reintegrar";
            this.btReintegrar.UseVisualStyleBackColor = false;
            this.btReintegrar.Click += new System.EventHandler(this.btReintegrar_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Idprestamo";
            this.ID.FillWeight = 37.62276F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NombreDelLibro
            // 
            this.NombreDelLibro.DataPropertyName = "NombreLibro";
            this.NombreDelLibro.FillWeight = 138.4146F;
            this.NombreDelLibro.HeaderText = "Nombre del Libro";
            this.NombreDelLibro.Name = "NombreDelLibro";
            this.NombreDelLibro.ReadOnly = true;
            // 
            // Lector
            // 
            this.Lector.DataPropertyName = "NombreLector";
            this.Lector.FillWeight = 79.05368F;
            this.Lector.HeaderText = "Lector";
            this.Lector.Name = "Lector";
            this.Lector.ReadOnly = true;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.DataPropertyName = "FechaPrestamo";
            this.FechaPrestamo.FillWeight = 121.5616F;
            this.FechaPrestamo.HeaderText = "Fecha Préstamo";
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.ReadOnly = true;
            // 
            // FechaEsperada
            // 
            this.FechaEsperada.DataPropertyName = "FechaDevolucionE";
            this.FechaEsperada.FillWeight = 121.8273F;
            this.FechaEsperada.HeaderText = "Fecha Esperada";
            this.FechaEsperada.Name = "FechaEsperada";
            this.FechaEsperada.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.FillWeight = 100.5065F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Multa
            // 
            this.Multa.DataPropertyName = "Multa";
            this.Multa.FillWeight = 100.5065F;
            this.Multa.HeaderText = "Multa";
            this.Multa.Name = "Multa";
            this.Multa.ReadOnly = true;
            // 
            // btregresar
            // 
            this.btregresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.btregresar.FlatAppearance.BorderSize = 0;
            this.btregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btregresar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btregresar.Location = new System.Drawing.Point(798, 99);
            this.btregresar.Name = "btregresar";
            this.btregresar.Size = new System.Drawing.Size(107, 38);
            this.btregresar.TabIndex = 13;
            this.btregresar.Text = "Regresar";
            this.btregresar.UseVisualStyleBackColor = false;
            this.btregresar.Click += new System.EventHandler(this.btregresar_Click);
            // 
            // GestionPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1125, 647);
            this.Controls.Add(this.btregresar);
            this.Controls.Add(this.btReintegrar);
            this.Controls.Add(this.btNuevoPrestamo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbGestionDeLibros);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionPrestamos";
            this.Text = "GestionPrestamos";
            this.Load += new System.EventHandler(this.GestionPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbGestionDeLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNuevoPrestamo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbGestionDeLibros;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReintegrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDelLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lector;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multa;
        private System.Windows.Forms.Button btregresar;
    }
}