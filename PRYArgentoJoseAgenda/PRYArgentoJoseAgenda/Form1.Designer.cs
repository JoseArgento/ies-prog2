namespace PRYArgentoJoseAgenda
{
    partial class frm_agenda
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
            btn_agregar = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_nombre = new TextBox();
            txt_tel = new TextBox();
            btn_eliminar = new Button();
            dgv_datos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_datos).BeginInit();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(12, 96);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(99, 23);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 2;
            label2.Text = "Tel:";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(83, 24);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(139, 23);
            txt_nombre.TabIndex = 3;
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(83, 53);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(139, 23);
            txt_tel.TabIndex = 4;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(117, 96);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(105, 23);
            btn_eliminar.TabIndex = 5;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // dgv_datos
            // 
            dgv_datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_datos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Telefono });
            dgv_datos.Location = new Point(12, 125);
            dgv_datos.Name = "dgv_datos";
            dgv_datos.RowHeadersVisible = false;
            dgv_datos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_datos.Size = new Size(210, 150);
            dgv_datos.TabIndex = 6;
            // 
            // Nombre
            // 
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            Telefono.Frozen = true;
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.Resizable = DataGridViewTriState.True;
            Telefono.Width = 120;
            // 
            // frm_agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 290);
            Controls.Add(dgv_datos);
            Controls.Add(btn_eliminar);
            Controls.Add(txt_tel);
            Controls.Add(txt_nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_agregar);
            Name = "frm_agenda";
            Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)dgv_datos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_agregar;
        private Label label1;
        private Label label2;
        private TextBox txt_nombre;
        private TextBox txt_tel;
        private Button btn_eliminar;
        private DataGridView dgv_datos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
    }
}
