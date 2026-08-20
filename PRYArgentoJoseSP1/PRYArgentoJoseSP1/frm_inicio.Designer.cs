namespace PRYArgentoJoseSP1
{
    partial class frm_inicio
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
            lbl_sistema = new Label();
            btn_aceptar = new Button();
            SuspendLayout();
            // 
            // lbl_sistema
            // 
            lbl_sistema.AutoSize = true;
            lbl_sistema.BorderStyle = BorderStyle.Fixed3D;
            lbl_sistema.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbl_sistema.Location = new Point(92, 82);
            lbl_sistema.Name = "lbl_sistema";
            lbl_sistema.Size = new Size(350, 47);
            lbl_sistema.TabIndex = 0;
            lbl_sistema.Text = "Bienvenido al Sistema";
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(231, 177);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 1;
            btn_aceptar.Text = "&Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // frm_inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 255);
            Controls.Add(btn_aceptar);
            Controls.Add(lbl_sistema);
            Name = "frm_inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frm_inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sistema;
        private Button btn_aceptar;
    }
}