namespace FRYArgentoJoseConversor
{
    partial class frm_conversor
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
            label2 = new Label();
            labelsito = new Label();
            label4 = new Label();
            txt_valor = new TextBox();
            cb_desde = new ComboBox();
            cb_hasta = new ComboBox();
            btn_convertir = new Button();
            lbl_resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 69);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Desde:";
            // 
            // labelsito
            // 
            labelsito.AutoSize = true;
            labelsito.Location = new Point(12, 99);
            labelsito.Name = "labelsito";
            labelsito.Size = new Size(40, 15);
            labelsito.TabIndex = 2;
            labelsito.Text = "Hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 173);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Resultado:";
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(63, 20);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(121, 23);
            txt_valor.TabIndex = 4;
            // 
            // cb_desde
            // 
            cb_desde.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_desde.FormattingEnabled = true;
            cb_desde.Items.AddRange(new object[] { "Centimetros", "Metros" });
            cb_desde.Location = new Point(63, 66);
            cb_desde.Name = "cb_desde";
            cb_desde.Size = new Size(121, 23);
            cb_desde.TabIndex = 5;
            // 
            // cb_hasta
            // 
            cb_hasta.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_hasta.FormattingEnabled = true;
            cb_hasta.Items.AddRange(new object[] { "Metros", "Centimetros" });
            cb_hasta.Location = new Point(63, 96);
            cb_hasta.Name = "cb_hasta";
            cb_hasta.Size = new Size(121, 23);
            cb_hasta.TabIndex = 6;
            // 
            // btn_convertir
            // 
            btn_convertir.Location = new Point(63, 136);
            btn_convertir.Name = "btn_convertir";
            btn_convertir.Size = new Size(121, 23);
            btn_convertir.TabIndex = 7;
            btn_convertir.Text = "Convertir";
            btn_convertir.UseVisualStyleBackColor = true;
            btn_convertir.Click += btn_convertir_Click;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Location = new Point(79, 174);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(0, 15);
            lbl_resultado.TabIndex = 8;
            // 
            // frm_conversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 210);
            Controls.Add(lbl_resultado);
            Controls.Add(btn_convertir);
            Controls.Add(cb_hasta);
            Controls.Add(cb_desde);
            Controls.Add(txt_valor);
            Controls.Add(label4);
            Controls.Add(labelsito);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_conversor";
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelsito;
        private Label label4;
        private TextBox txt_valor;
        private ComboBox cb_desde;
        private ComboBox cb_hasta;
        private Button btn_convertir;
        private Label lbl_resultado;
    }
}
