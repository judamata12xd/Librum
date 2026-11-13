namespace AppEscritorio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbLibrum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txContraseña = new System.Windows.Forms.TextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btIniciarSesion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLibrum
            // 
            this.lbLibrum.AutoSize = true;
            this.lbLibrum.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibrum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbLibrum.Location = new System.Drawing.Point(297, 87);
            this.lbLibrum.Name = "lbLibrum";
            this.lbLibrum.Size = new System.Drawing.Size(224, 26);
            this.lbLibrum.TabIndex = 0;
            this.lbLibrum.Text = "¡Bienvenido a Librum!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(40, 81);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(552, 20);
            this.txUsuario.TabIndex = 3;
            // 
            // txContraseña
            // 
            this.txContraseña.Location = new System.Drawing.Point(40, 172);
            this.txContraseña.Name = "txContraseña";
            this.txContraseña.PasswordChar = '*';
            this.txContraseña.Size = new System.Drawing.Size(552, 20);
            this.txContraseña.TabIndex = 4;
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.btIniciarSesion);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.txContraseña);
            this.gbLogin.Controls.Add(this.txUsuario);
            this.gbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLogin.Location = new System.Drawing.Point(89, 161);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(661, 332);
            this.gbLogin.TabIndex = 5;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(36, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // btIniciarSesion
            // 
            this.btIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIniciarSesion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btIniciarSesion.Location = new System.Drawing.Point(40, 234);
            this.btIniciarSesion.Name = "btIniciarSesion";
            this.btIniciarSesion.Size = new System.Drawing.Size(552, 42);
            this.btIniciarSesion.TabIndex = 5;
            this.btIniciarSesion.Text = "Iniciar sesión";
            this.btIniciarSesion.UseVisualStyleBackColor = false;
            this.btIniciarSesion.Click += new System.EventHandler(this.btIniciarSesion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(326, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "LIBRUM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(321, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inicia sesión para continuar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(842, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.lbLibrum);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = " ";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLibrum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txContraseña;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btIniciarSesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}