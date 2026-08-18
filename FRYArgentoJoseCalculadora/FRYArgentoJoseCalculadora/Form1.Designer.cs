namespace FRYArgentoJoseCalculadora
{
    partial class frm_calculadora
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
            label3 = new Label();
            txt_num1 = new TextBox();
            txt_num2 = new TextBox();
            btn_suma = new Button();
            btn_resta = new Button();
            btn_multiplicar = new Button();
            btn_dividir = new Button();
            lbl_resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Nùmero 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 51);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Nùmero 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 140);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Resultado:";
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(86, 16);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(100, 23);
            txt_num1.TabIndex = 3;
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(86, 48);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(100, 23);
            txt_num2.TabIndex = 4;
            // 
            // btn_suma
            // 
            btn_suma.Location = new Point(7, 86);
            btn_suma.Name = "btn_suma";
            btn_suma.Size = new Size(60, 23);
            btn_suma.TabIndex = 5;
            btn_suma.Text = "+";
            btn_suma.UseVisualStyleBackColor = true;
            btn_suma.Click += btn_suma_Click;
            // 
            // btn_resta
            // 
            btn_resta.Location = new Point(73, 86);
            btn_resta.Name = "btn_resta";
            btn_resta.Size = new Size(60, 23);
            btn_resta.TabIndex = 6;
            btn_resta.Text = "-";
            btn_resta.UseVisualStyleBackColor = true;
            btn_resta.Click += btn_resta_Click;
            // 
            // btn_multiplicar
            // 
            btn_multiplicar.Location = new Point(139, 86);
            btn_multiplicar.Name = "btn_multiplicar";
            btn_multiplicar.Size = new Size(60, 23);
            btn_multiplicar.TabIndex = 7;
            btn_multiplicar.Text = "x";
            btn_multiplicar.UseVisualStyleBackColor = true;
            btn_multiplicar.Click += btn_multiplicar_Click;
            // 
            // btn_dividir
            // 
            btn_dividir.Location = new Point(205, 86);
            btn_dividir.Name = "btn_dividir";
            btn_dividir.Size = new Size(60, 23);
            btn_dividir.TabIndex = 8;
            btn_dividir.Text = "/";
            btn_dividir.UseVisualStyleBackColor = true;
            btn_dividir.Click += btn_dividir_Click;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Location = new Point(75, 140);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(0, 15);
            lbl_resultado.TabIndex = 9;
            // 
            // frm_calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 170);
            Controls.Add(lbl_resultado);
            Controls.Add(btn_dividir);
            Controls.Add(btn_multiplicar);
            Controls.Add(btn_resta);
            Controls.Add(btn_suma);
            Controls.Add(txt_num2);
            Controls.Add(txt_num1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "frm_calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_num1;
        private TextBox txt_num2;
        private Button btn_suma;
        private Button btn_resta;
        private Button btn_multiplicar;
        private Button btn_dividir;
        private Label lbl_resultado;
    }
}
