namespace CapaPresentacion
{
    partial class frmLogin
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
            this.lblLogoEmpresa = new System.Windows.Forms.Label();
            this.iconLogoEmpresa = new FontAwesome.Sharp.IconPictureBox();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtConstraseña = new System.Windows.Forms.TextBox();
            this.iconAceptar = new FontAwesome.Sharp.IconButton();
            this.iconCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogoEmpresa
            // 
            this.lblLogoEmpresa.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblLogoEmpresa.Location = new System.Drawing.Point(-2, 0);
            this.lblLogoEmpresa.Name = "lblLogoEmpresa";
            this.lblLogoEmpresa.Size = new System.Drawing.Size(168, 186);
            this.lblLogoEmpresa.TabIndex = 0;
            // 
            // iconLogoEmpresa
            // 
            this.iconLogoEmpresa.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconLogoEmpresa.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.iconLogoEmpresa.IconColor = System.Drawing.Color.White;
            this.iconLogoEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogoEmpresa.IconSize = 70;
            this.iconLogoEmpresa.Location = new System.Drawing.Point(45, 24);
            this.iconLogoEmpresa.Name = "iconLogoEmpresa";
            this.iconLogoEmpresa.Size = new System.Drawing.Size(76, 70);
            this.iconLogoEmpresa.TabIndex = 1;
            this.iconLogoEmpresa.TabStop = false;
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.ForeColor = System.Drawing.Color.White;
            this.lblTituloLogin.Location = new System.Drawing.Point(5, 108);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(150, 25);
            this.lblTituloLogin.TabIndex = 2;
            this.lblTituloLogin.Text = "Sistema POS";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(186, 24);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblIdUsuario.TabIndex = 3;
            this.lblIdUsuario.Text = "Nombre Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(189, 41);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(245, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtConstraseña
            // 
            this.txtConstraseña.Location = new System.Drawing.Point(192, 97);
            this.txtConstraseña.Name = "txtConstraseña";
            this.txtConstraseña.PasswordChar = '*';
            this.txtConstraseña.Size = new System.Drawing.Size(242, 20);
            this.txtConstraseña.TabIndex = 6;
            // 
            // iconAceptar
            // 
            this.iconAceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconAceptar.IconColor = System.Drawing.Color.Black;
            this.iconAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAceptar.Location = new System.Drawing.Point(192, 134);
            this.iconAceptar.Name = "iconAceptar";
            this.iconAceptar.Size = new System.Drawing.Size(103, 23);
            this.iconAceptar.TabIndex = 7;
            this.iconAceptar.Text = "Aceptar";
            this.iconAceptar.UseVisualStyleBackColor = true;
            this.iconAceptar.Click += new System.EventHandler(this.iconAceptar_Click);
            // 
            // iconCancelar
            // 
            this.iconCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconCancelar.IconColor = System.Drawing.Color.Black;
            this.iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCancelar.Location = new System.Drawing.Point(332, 134);
            this.iconCancelar.Name = "iconCancelar";
            this.iconCancelar.Size = new System.Drawing.Size(102, 23);
            this.iconCancelar.TabIndex = 8;
            this.iconCancelar.Text = "Cancelar";
            this.iconCancelar.UseVisualStyleBackColor = true;
            this.iconCancelar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.iconAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.iconCancelar;
            this.ClientSize = new System.Drawing.Size(467, 186);
            this.Controls.Add(this.iconCancelar);
            this.Controls.Add(this.iconAceptar);
            this.Controls.Add(this.txtConstraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.lblTituloLogin);
            this.Controls.Add(this.iconLogoEmpresa);
            this.Controls.Add(this.lblLogoEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.iconLogoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogoEmpresa;
        private FontAwesome.Sharp.IconPictureBox iconLogoEmpresa;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtConstraseña;
        private FontAwesome.Sharp.IconButton iconAceptar;
        private FontAwesome.Sharp.IconButton iconCancelar;
    }
}