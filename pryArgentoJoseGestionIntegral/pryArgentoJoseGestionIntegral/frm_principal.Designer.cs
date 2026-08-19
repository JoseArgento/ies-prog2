namespace pryArgentoJoseGestionIntegral
{
    partial class frm_gestion_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_navbar = new Panel();
            btn_config = new Button();
            btn_salir = new Button();
            btn_reportes = new Button();
            btn_ventas = new Button();
            btn_productos = new Button();
            btn_clientes = new Button();
            pnl_contenido = new Panel();
            pnl_navbar.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_navbar
            // 
            pnl_navbar.BackColor = SystemColors.ActiveCaption;
            pnl_navbar.Controls.Add(btn_config);
            pnl_navbar.Controls.Add(btn_salir);
            pnl_navbar.Controls.Add(btn_reportes);
            pnl_navbar.Controls.Add(btn_ventas);
            pnl_navbar.Controls.Add(btn_productos);
            pnl_navbar.Controls.Add(btn_clientes);
            pnl_navbar.Dock = DockStyle.Left;
            pnl_navbar.Location = new Point(0, 0);
            pnl_navbar.Name = "pnl_navbar";
            pnl_navbar.Size = new Size(150, 322);
            pnl_navbar.TabIndex = 0;
            // 
            // btn_config
            // 
            btn_config.Dock = DockStyle.Bottom;
            btn_config.Location = new Point(0, 276);
            btn_config.Name = "btn_config";
            btn_config.Size = new Size(150, 23);
            btn_config.TabIndex = 5;
            btn_config.Text = "Configuraciòn";
            btn_config.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            btn_salir.Dock = DockStyle.Bottom;
            btn_salir.Location = new Point(0, 299);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(150, 23);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_reportes
            // 
            btn_reportes.Dock = DockStyle.Top;
            btn_reportes.Location = new Point(0, 69);
            btn_reportes.Name = "btn_reportes";
            btn_reportes.Size = new Size(150, 23);
            btn_reportes.TabIndex = 3;
            btn_reportes.Text = "Reportes";
            btn_reportes.UseVisualStyleBackColor = true;
            // 
            // btn_ventas
            // 
            btn_ventas.Dock = DockStyle.Top;
            btn_ventas.Location = new Point(0, 46);
            btn_ventas.Name = "btn_ventas";
            btn_ventas.Size = new Size(150, 23);
            btn_ventas.TabIndex = 2;
            btn_ventas.Text = "Ventas";
            btn_ventas.UseVisualStyleBackColor = true;
            // 
            // btn_productos
            // 
            btn_productos.Dock = DockStyle.Top;
            btn_productos.Location = new Point(0, 23);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(150, 23);
            btn_productos.TabIndex = 1;
            btn_productos.Text = "Productos";
            btn_productos.UseVisualStyleBackColor = true;
            // 
            // btn_clientes
            // 
            btn_clientes.Dock = DockStyle.Top;
            btn_clientes.Location = new Point(0, 0);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(150, 23);
            btn_clientes.TabIndex = 0;
            btn_clientes.Text = "Clientes";
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // pnl_contenido
            // 
            pnl_contenido.Dock = DockStyle.Fill;
            pnl_contenido.Location = new Point(150, 0);
            pnl_contenido.Name = "pnl_contenido";
            pnl_contenido.Size = new Size(276, 322);
            pnl_contenido.TabIndex = 1;
            // 
            // frm_gestion_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 322);
            Controls.Add(pnl_contenido);
            Controls.Add(pnl_navbar);
            Name = "frm_gestion_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestiòn";
            Load += frm_gestion_principal_Load;
            pnl_navbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_navbar;
        private Button btn_config;
        private Button btn_salir;
        private Button btn_reportes;
        private Button btn_ventas;
        private Button btn_productos;
        private Button btn_clientes;
        private Panel pnl_contenido;
    }
}
