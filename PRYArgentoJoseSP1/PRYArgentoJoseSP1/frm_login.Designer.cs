namespace PRYArgentoJoseSP1
{
    partial class frm_login
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
            lbl_usuario = new Label();
            lbl_contrasena = new Label();
            lbl_modulo = new Label();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            cmb_modulo = new ComboBox();
            txt_usuario = new TextBox();
            txt_contrasena = new TextBox();
            lbl_error = new Label();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(41, 27);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(47, 15);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuario";
            // 
            // lbl_contrasena
            // 
            lbl_contrasena.AutoSize = true;
            lbl_contrasena.Location = new Point(23, 58);
            lbl_contrasena.Name = "lbl_contrasena";
            lbl_contrasena.Size = new Size(67, 15);
            lbl_contrasena.TabIndex = 1;
            lbl_contrasena.Text = "Contraseña";
            // 
            // lbl_modulo
            // 
            lbl_modulo.AutoSize = true;
            lbl_modulo.Location = new Point(41, 87);
            lbl_modulo.Name = "lbl_modulo";
            lbl_modulo.Size = new Size(49, 15);
            lbl_modulo.TabIndex = 2;
            lbl_modulo.Text = "Módulo";
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(281, 23);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 3;
            btn_aceptar.Text = "&Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(281, 54);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "&Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // cmb_modulo
            // 
            cmb_modulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_modulo.FormattingEnabled = true;
            cmb_modulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            cmb_modulo.Location = new Point(111, 84);
            cmb_modulo.Name = "cmb_modulo";
            cmb_modulo.Size = new Size(134, 23);
            cmb_modulo.TabIndex = 5;
            // 
            // txt_usuario
            // 
            txt_usuario.ForeColor = SystemColors.Highlight;
            txt_usuario.Location = new Point(111, 24);
            txt_usuario.MaxLength = 10;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(134, 23);
            txt_usuario.TabIndex = 6;
            // 
            // txt_contrasena
            // 
            txt_contrasena.Location = new Point(111, 55);
            txt_contrasena.MaxLength = 10;
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.PasswordChar = '#';
            txt_contrasena.Size = new Size(134, 23);
            txt_contrasena.TabIndex = 7;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_error.ForeColor = Color.IndianRed;
            lbl_error.Location = new Point(3, 115);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 15);
            lbl_error.TabIndex = 8;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 139);
            Controls.Add(lbl_error);
            Controls.Add(txt_contrasena);
            Controls.Add(txt_usuario);
            Controls.Add(cmb_modulo);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(lbl_modulo);
            Controls.Add(lbl_contrasena);
            Controls.Add(lbl_usuario);
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frm_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private Label lbl_contrasena;
        private Label lbl_modulo;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private ComboBox cmb_modulo;
        private TextBox txt_usuario;
        private TextBox txt_contrasena;
        private Label lbl_error;
    }
}
