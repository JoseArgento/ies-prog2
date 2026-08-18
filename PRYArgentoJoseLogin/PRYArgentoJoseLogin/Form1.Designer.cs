namespace PRYArgentoJoseLogin
{
    partial class frm_Login
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
            txt_usuario = new TextBox();
            label1 = new Label();
            btn_ingresar = new Button();
            label2 = new Label();
            txt_clave = new TextBox();
            lbl_mensaje = new Label();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(79, 21);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(15, 104);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(164, 23);
            btn_ingresar.TabIndex = 3;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 60);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Clave";
            // 
            // txt_clave
            // 
            txt_clave.Location = new Point(79, 57);
            txt_clave.Name = "txt_clave";
            txt_clave.PasswordChar = '*';
            txt_clave.Size = new Size(100, 23);
            txt_clave.TabIndex = 2;
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.AutoSize = true;
            lbl_mensaje.Location = new Point(15, 155);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(0, 15);
            lbl_mensaje.TabIndex = 5;
            // 
            // frm_Login
            // 
            AcceptButton = btn_ingresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 193);
            Controls.Add(lbl_mensaje);
            Controls.Add(txt_clave);
            Controls.Add(label2);
            Controls.Add(btn_ingresar);
            Controls.Add(label1);
            Controls.Add(txt_usuario);
            Name = "frm_Login";
            Text = "Login";
            Load += frm_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usuario;
        private Label label1;
        private Button btn_ingresar;
        private Label label2;
        private TextBox txt_clave;
        private Label lbl_mensaje;
    }
}
