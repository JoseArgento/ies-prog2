namespace FRYArgentoJoseRegistro
{
    partial class frm_registrar
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
            label1 = new Label();
            ckb_man = new CheckBox();
            cb_carrera = new ComboBox();
            btn_registrar = new Button();
            txt_nombre = new TextBox();
            rb_masc = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            txt_apellido = new TextBox();
            txt_dni = new TextBox();
            label4 = new Label();
            rb_fem = new RadioButton();
            label5 = new Label();
            ckb_tarde = new CheckBox();
            ckb_noche = new CheckBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // ckb_man
            // 
            ckb_man.AutoSize = true;
            ckb_man.Location = new Point(77, 175);
            ckb_man.Name = "ckb_man";
            ckb_man.Size = new Size(69, 19);
            ckb_man.TabIndex = 1;
            ckb_man.Text = "Mañana";
            ckb_man.UseVisualStyleBackColor = true;
            // 
            // cb_carrera
            // 
            cb_carrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_carrera.FormattingEnabled = true;
            cb_carrera.Items.AddRange(new object[] { "Programacion", "Ciberseguridad" });
            cb_carrera.Location = new Point(80, 220);
            cb_carrera.Name = "cb_carrera";
            cb_carrera.Size = new Size(121, 23);
            cb_carrera.TabIndex = 2;
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(80, 266);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(121, 23);
            btn_registrar.TabIndex = 3;
            btn_registrar.Text = "Registrar";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(82, 31);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(119, 23);
            txt_nombre.TabIndex = 4;
            // 
            // rb_masc
            // 
            rb_masc.AutoSize = true;
            rb_masc.Location = new Point(77, 141);
            rb_masc.Name = "rb_masc";
            rb_masc.Size = new Size(80, 19);
            rb_masc.TabIndex = 5;
            rb_masc.TabStop = true;
            rb_masc.Text = "Masculino";
            rb_masc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 63);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 92);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 7;
            label3.Text = "Dni:";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(82, 60);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(119, 23);
            txt_apellido.TabIndex = 8;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(82, 89);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(119, 23);
            txt_dni.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 143);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 10;
            label4.Text = "Sexo:";
            // 
            // rb_fem
            // 
            rb_fem.AutoSize = true;
            rb_fem.Location = new Point(163, 141);
            rb_fem.Name = "rb_fem";
            rb_fem.Size = new Size(78, 19);
            rb_fem.TabIndex = 11;
            rb_fem.TabStop = true;
            rb_fem.Text = "Femenino";
            rb_fem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 175);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 12;
            label5.Text = "Turno:";
            // 
            // ckb_tarde
            // 
            ckb_tarde.AutoSize = true;
            ckb_tarde.Location = new Point(163, 175);
            ckb_tarde.Name = "ckb_tarde";
            ckb_tarde.Size = new Size(54, 19);
            ckb_tarde.TabIndex = 13;
            ckb_tarde.Text = "Tarde";
            ckb_tarde.UseVisualStyleBackColor = true;
            // 
            // ckb_noche
            // 
            ckb_noche.AutoSize = true;
            ckb_noche.Location = new Point(230, 175);
            ckb_noche.Name = "ckb_noche";
            ckb_noche.Size = new Size(61, 19);
            ckb_noche.TabIndex = 14;
            ckb_noche.Text = "Noche";
            ckb_noche.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 223);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 15;
            label6.Text = "Carrera:";
            // 
            // frm_registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 306);
            Controls.Add(ckb_man);
            Controls.Add(ckb_tarde);
            Controls.Add(label6);
            Controls.Add(ckb_noche);
            Controls.Add(label5);
            Controls.Add(rb_fem);
            Controls.Add(label4);
            Controls.Add(txt_dni);
            Controls.Add(txt_apellido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rb_masc);
            Controls.Add(txt_nombre);
            Controls.Add(btn_registrar);
            Controls.Add(cb_carrera);
            Controls.Add(label1);
            Name = "frm_registrar";
            Text = "Registro de Alumno";
            Load += frm_registrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox ckb_man;
        private ComboBox cb_carrera;
        private Button btn_registrar;
        private TextBox txt_nombre;
        private RadioButton rb_masc;
        private Label label2;
        private Label label3;
        private TextBox txt_apellido;
        private TextBox txt_dni;
        private Label label4;
        private RadioButton rb_fem;
        private Label label5;
        private CheckBox ckb_tarde;
        private CheckBox ckb_noche;
        private Label label6;
    }
}
