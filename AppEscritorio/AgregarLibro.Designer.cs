namespace AppEscritorio
{
    partial class cbAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cbAutor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txCodLibro = new System.Windows.Forms.TextBox();
            this.txTitulo = new System.Windows.Forms.TextBox();
            this.txDisponibles = new System.Windows.Forms.TextBox();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(222, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestionar Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(99, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(130, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(99, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Disponibles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(130, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Autor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txCodLibro
            // 
            this.txCodLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txCodLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCodLibro.ForeColor = System.Drawing.Color.White;
            this.txCodLibro.Location = new System.Drawing.Point(236, 114);
            this.txCodLibro.Name = "txCodLibro";
            this.txCodLibro.Size = new System.Drawing.Size(208, 20);
            this.txCodLibro.TabIndex = 9;
            this.txCodLibro.TextChanged += new System.EventHandler(this.txCodLibro_TextChanged);
            // 
            // txTitulo
            // 
            this.txTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTitulo.ForeColor = System.Drawing.Color.White;
            this.txTitulo.Location = new System.Drawing.Point(236, 170);
            this.txTitulo.Name = "txTitulo";
            this.txTitulo.Size = new System.Drawing.Size(208, 20);
            this.txTitulo.TabIndex = 10;
            // 
            // txDisponibles
            // 
            this.txDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txDisponibles.ForeColor = System.Drawing.Color.White;
            this.txDisponibles.Location = new System.Drawing.Point(236, 233);
            this.txDisponibles.Name = "txDisponibles";
            this.txDisponibles.Size = new System.Drawing.Size(208, 20);
            this.txDisponibles.TabIndex = 11;
            // 
            // cmbAutor
            // 
            this.cmbAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(222, 306);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(208, 21);
            this.cmbAutor.TabIndex = 12;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btGuardar.FlatAppearance.BorderSize = 0;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGuardar.Location = new System.Drawing.Point(55, 381);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(150, 45);
            this.btGuardar.TabIndex = 13;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(351, 381);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(150, 43);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // cbAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.txDisponibles);
            this.Controls.Add(this.txTitulo);
            this.Controls.Add(this.txCodLibro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "cbAutor";
            this.Text = "AgregarLibro";
            this.Load += new System.EventHandler(this.FrmLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCodLibro;
        private System.Windows.Forms.TextBox txTitulo;
        private System.Windows.Forms.TextBox txDisponibles;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCancelar;
    }
}