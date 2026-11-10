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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btNuevoPrestamo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbGestionDeLibros = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDelLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btReintegrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbGestionDeLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.gbGestionDeLibros.Controls.Add(this.dataGridView1);
            this.gbGestionDeLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGestionDeLibros.Location = new System.Drawing.Point(61, 164);
            this.gbGestionDeLibros.Name = "gbGestionDeLibros";
            this.gbGestionDeLibros.Size = new System.Drawing.Size(1007, 458);
            this.gbGestionDeLibros.TabIndex = 7;
            this.gbGestionDeLibros.TabStop = false;
            this.gbGestionDeLibros.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(26)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreDelLibro,
            this.Lector,
            this.FechaPrestamo,
            this.FechaEsperada,
            this.Estado,
            this.Multa,
            this.Acciones});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dataGridView1.Location = new System.Drawing.Point(21, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 45;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(962, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(288, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Novedades: Gestión de Préstamos";
            // 
            // ID
            // 
            this.ID.FillWeight = 37.62276F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NombreDelLibro
            // 
            this.NombreDelLibro.FillWeight = 138.4146F;
            this.NombreDelLibro.HeaderText = "Nombre del Libro";
            this.NombreDelLibro.Name = "NombreDelLibro";
            this.NombreDelLibro.ReadOnly = true;
            // 
            // Lector
            // 
            this.Lector.FillWeight = 79.05368F;
            this.Lector.HeaderText = "Lector";
            this.Lector.Name = "Lector";
            this.Lector.ReadOnly = true;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.FillWeight = 121.5616F;
            this.FechaPrestamo.HeaderText = "Fecha Préstamo";
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.ReadOnly = true;
            // 
            // FechaEsperada
            // 
            this.FechaEsperada.FillWeight = 121.8273F;
            this.FechaEsperada.HeaderText = "Fecha Esperada";
            this.FechaEsperada.Name = "FechaEsperada";
            this.FechaEsperada.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 100.5065F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Multa
            // 
            this.Multa.FillWeight = 100.5065F;
            this.Multa.HeaderText = "Multa";
            this.Multa.Name = "Multa";
            this.Multa.ReadOnly = true;
            // 
            // Acciones
            // 
            this.Acciones.FillWeight = 100.5065F;
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
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
            // 
            // GestionPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1125, 647);
            this.Controls.Add(this.btReintegrar);
            this.Controls.Add(this.btNuevoPrestamo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbGestionDeLibros);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionPrestamos";
            this.Text = "GestionPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbGestionDeLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNuevoPrestamo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbGestionDeLibros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDelLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lector;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acciones;
        private System.Windows.Forms.Button btReintegrar;
    }
}