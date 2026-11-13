namespace AppEscritorio
{
    partial class BusquedaLibros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaLibros));
            this.label1 = new System.Windows.Forms.Label();
            this.gbGestionDeLibros = new System.Windows.Forms.GroupBox();
            this.btregresar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.Codlibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txBuscarLibro = new System.Windows.Forms.TextBox();
            this.btAgregarLibro = new System.Windows.Forms.Button();
            this.gbGestionDeLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(407, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Libros";
            // 
            // gbGestionDeLibros
            // 
            this.gbGestionDeLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.gbGestionDeLibros.Controls.Add(this.btregresar);
            this.gbGestionDeLibros.Controls.Add(this.btEditar);
            this.gbGestionDeLibros.Controls.Add(this.btEliminar);
            this.gbGestionDeLibros.Controls.Add(this.dgvLibros);
            this.gbGestionDeLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGestionDeLibros.Location = new System.Drawing.Point(61, 165);
            this.gbGestionDeLibros.Name = "gbGestionDeLibros";
            this.gbGestionDeLibros.Size = new System.Drawing.Size(1007, 458);
            this.gbGestionDeLibros.TabIndex = 1;
            this.gbGestionDeLibros.TabStop = false;
            this.gbGestionDeLibros.Text = " ";
            this.gbGestionDeLibros.Enter += new System.EventHandler(this.gbGestionDeLibros_Enter);
            // 
            // btregresar
            // 
            this.btregresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.btregresar.FlatAppearance.BorderSize = 0;
            this.btregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btregresar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btregresar.Location = new System.Drawing.Point(868, 325);
            this.btregresar.Name = "btregresar";
            this.btregresar.Size = new System.Drawing.Size(107, 38);
            this.btregresar.TabIndex = 3;
            this.btregresar.Text = "Regresar";
            this.btregresar.UseVisualStyleBackColor = false;
            this.btregresar.Click += new System.EventHandler(this.btregresar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEditar.Location = new System.Drawing.Point(868, 139);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(107, 38);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btEliminar.FlatAppearance.BorderSize = 0;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(868, 237);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(107, 38);
            this.btEliminar.TabIndex = 1;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(26)))));
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibros.ColumnHeadersHeight = 45;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codlibro,
            this.Nombre,
            this.Disponible,
            this.NombreAutor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLibros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvLibros.Location = new System.Drawing.Point(20, 35);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.RowTemplate.Height = 45;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(815, 391);
            this.dgvLibros.TabIndex = 0;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codlibro
            // 
            this.Codlibro.DataPropertyName = "Codlibro";
            this.Codlibro.HeaderText = "Código";
            this.Codlibro.Name = "Codlibro";
            this.Codlibro.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Disponible
            // 
            this.Disponible.DataPropertyName = "Disponible";
            this.Disponible.HeaderText = "Disponibles";
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
            // 
            // NombreAutor
            // 
            this.NombreAutor.DataPropertyName = "NombreAutor";
            this.NombreAutor.HeaderText = "NombreAutor";
            this.NombreAutor.Name = "NombreAutor";
            this.NombreAutor.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(57, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar Libro:";
            // 
            // txBuscarLibro
            // 
            this.txBuscarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txBuscarLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txBuscarLibro.ForeColor = System.Drawing.Color.White;
            this.txBuscarLibro.Location = new System.Drawing.Point(179, 119);
            this.txBuscarLibro.Name = "txBuscarLibro";
            this.txBuscarLibro.Size = new System.Drawing.Size(678, 20);
            this.txBuscarLibro.TabIndex = 4;
            this.txBuscarLibro.TextChanged += new System.EventHandler(this.txBuscarLibro_TextChanged);
            // 
            // btAgregarLibro
            // 
            this.btAgregarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btAgregarLibro.FlatAppearance.BorderSize = 0;
            this.btAgregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarLibro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAgregarLibro.Location = new System.Drawing.Point(886, 103);
            this.btAgregarLibro.Name = "btAgregarLibro";
            this.btAgregarLibro.Size = new System.Drawing.Size(150, 45);
            this.btAgregarLibro.TabIndex = 5;
            this.btAgregarLibro.Text = "Agregar Libro";
            this.btAgregarLibro.UseVisualStyleBackColor = false;
            this.btAgregarLibro.Click += new System.EventHandler(this.btAgregarLibro_Click);
            // 
            // BusquedaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1139, 675);
            this.Controls.Add(this.btAgregarLibro);
            this.Controls.Add(this.txBuscarLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbGestionDeLibros);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusquedaLibros";
            this.Text = "BusquedaLibros";
            this.Load += new System.EventHandler(this.BusquedaLibros_Load);
            this.gbGestionDeLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGestionDeLibros;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBuscarLibro;
        private System.Windows.Forms.Button btAgregarLibro;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btregresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codlibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAutor;
    }
}