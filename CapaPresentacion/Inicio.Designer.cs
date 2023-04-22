namespace CapaPresentacion
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuIconos = new System.Windows.Forms.MenuStrip();
            this.iconCompras = new FontAwesome.Sharp.IconMenuItem();
            this.iconUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.iconMantenimientos = new FontAwesome.Sharp.IconMenuItem();
            this.iconVentas = new FontAwesome.Sharp.IconMenuItem();
            this.iconClientes = new FontAwesome.Sharp.IconMenuItem();
            this.iconProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iconReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.lblTituloprincipal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuIconos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuIconos
            // 
            this.menuIconos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuIconos.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuIconos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconCompras,
            this.iconUsuarios,
            this.iconMantenimientos,
            this.iconVentas,
            this.iconClientes,
            this.iconProveedores,
            this.iconReportes});
            this.menuIconos.Location = new System.Drawing.Point(0, 60);
            this.menuIconos.Name = "menuIconos";
            this.menuIconos.Size = new System.Drawing.Size(128, 440);
            this.menuIconos.TabIndex = 0;
            this.menuIconos.Text = "menuStrip1";
            // 
            // iconCompras
            // 
            this.iconCompras.AutoSize = false;
            this.iconCompras.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.iconCompras.IconColor = System.Drawing.Color.DimGray;
            this.iconCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCompras.IconSize = 40;
            this.iconCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconCompras.Name = "iconCompras";
            this.iconCompras.Size = new System.Drawing.Size(122, 60);
            this.iconCompras.Text = "Compras";
            this.iconCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconUsuarios
            // 
            this.iconUsuarios.AutoSize = false;
            this.iconUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconUsuarios.IconColor = System.Drawing.Color.DimGray;
            this.iconUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsuarios.IconSize = 40;
            this.iconUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconUsuarios.Name = "iconUsuarios";
            this.iconUsuarios.Size = new System.Drawing.Size(104, 60);
            this.iconUsuarios.Text = "Usuarios";
            this.iconUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMantenimientos
            // 
            this.iconMantenimientos.AutoSize = false;
            this.iconMantenimientos.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconMantenimientos.IconColor = System.Drawing.Color.DimGray;
            this.iconMantenimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMantenimientos.IconSize = 40;
            this.iconMantenimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMantenimientos.Name = "iconMantenimientos";
            this.iconMantenimientos.Size = new System.Drawing.Size(122, 60);
            this.iconMantenimientos.Text = "Mantenimientos";
            this.iconMantenimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconVentas
            // 
            this.iconVentas.AutoSize = false;
            this.iconVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconVentas.IconColor = System.Drawing.Color.DimGray;
            this.iconVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVentas.IconSize = 40;
            this.iconVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconVentas.Name = "iconVentas";
            this.iconVentas.Size = new System.Drawing.Size(122, 60);
            this.iconVentas.Text = "Ventas";
            this.iconVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconVentas.Click += new System.EventHandler(this.iconMenuItem5_Click);
            // 
            // iconClientes
            // 
            this.iconClientes.AutoSize = false;
            this.iconClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconClientes.IconColor = System.Drawing.Color.DimGray;
            this.iconClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClientes.IconSize = 40;
            this.iconClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconClientes.Name = "iconClientes";
            this.iconClientes.Size = new System.Drawing.Size(122, 60);
            this.iconClientes.Text = "Clientes";
            this.iconClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconProveedores
            // 
            this.iconProveedores.AutoSize = false;
            this.iconProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconProveedores.IconColor = System.Drawing.Color.DimGray;
            this.iconProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProveedores.IconSize = 40;
            this.iconProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconProveedores.Name = "iconProveedores";
            this.iconProveedores.Size = new System.Drawing.Size(122, 60);
            this.iconProveedores.Text = "Proveedores";
            this.iconProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconReportes
            // 
            this.iconReportes.AutoSize = false;
            this.iconReportes.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.iconReportes.IconColor = System.Drawing.Color.DimGray;
            this.iconReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconReportes.IconSize = 40;
            this.iconReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconReportes.Name = "iconReportes";
            this.iconReportes.Size = new System.Drawing.Size(122, 60);
            this.iconReportes.Text = "Reportes";
            this.iconReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(802, 60);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // lblTituloprincipal
            // 
            this.lblTituloprincipal.AutoSize = true;
            this.lblTituloprincipal.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTituloprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloprincipal.ForeColor = System.Drawing.Color.White;
            this.lblTituloprincipal.Location = new System.Drawing.Point(21, 13);
            this.lblTituloprincipal.Name = "lblTituloprincipal";
            this.lblTituloprincipal.Size = new System.Drawing.Size(351, 25);
            this.lblTituloprincipal.TabIndex = 2;
            this.lblTituloprincipal.Text = "Sistema de Compras y Ventas POS";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(128, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 440);
            this.panel1.TabIndex = 3;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloprincipal);
            this.Controls.Add(this.menuIconos);
            this.Controls.Add(this.menuTitulo);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas POS";
            this.menuIconos.ResumeLayout(false);
            this.menuIconos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuIconos;
        private FontAwesome.Sharp.IconMenuItem iconUsuarios;
        private FontAwesome.Sharp.IconMenuItem iconMantenimientos;
        private FontAwesome.Sharp.IconMenuItem iconCompras;
        private FontAwesome.Sharp.IconMenuItem iconVentas;
        private FontAwesome.Sharp.IconMenuItem iconClientes;
        private FontAwesome.Sharp.IconMenuItem iconProveedores;
        private FontAwesome.Sharp.IconMenuItem iconReportes;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label lblTituloprincipal;
        private System.Windows.Forms.Panel panel1;
    }
}

