namespace pryArgentoJoseGestionIntegral
{
    partial class frm_clientes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            txt_dni = new TextBox();
            btn_nuevo = new Button();
            btn_guardar = new Button();
            btn_borrar = new Button();
            dgv_clientes = new DataGridView();
            col_nombre = new DataGridViewTextBoxColumn();
            col_apellido = new DataGridViewTextBoxColumn();
            col_dni = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 2;
            label3.Text = "Dni";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(69, 15);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(180, 23);
            txt_nombre.TabIndex = 3;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(69, 42);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(180, 23);
            txt_apellido.TabIndex = 4;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(69, 70);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(180, 23);
            txt_dni.TabIndex = 5;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Location = new Point(9, 109);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(78, 23);
            btn_nuevo.TabIndex = 6;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(90, 109);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(78, 23);
            btn_guardar.TabIndex = 7;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(171, 109);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(78, 23);
            btn_borrar.TabIndex = 8;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // dgv_clientes
            // 
            dgv_clientes.AllowUserToAddRows = false;
            dgv_clientes.AllowUserToDeleteRows = false;
            dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_clientes.Columns.AddRange(new DataGridViewColumn[] { col_nombre, col_apellido, col_dni });
            dgv_clientes.Location = new Point(9, 138);
            dgv_clientes.Name = "dgv_clientes";
            dgv_clientes.ReadOnly = true;
            dgv_clientes.RowHeadersVisible = false;
            dgv_clientes.ScrollBars = ScrollBars.Horizontal;
            dgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_clientes.Size = new Size(240, 150);
            dgv_clientes.TabIndex = 9;
            dgv_clientes.SelectionChanged += dgv_clientes_SelectionChanged;
            // 
            // col_nombre
            // 
            col_nombre.Frozen = true;
            col_nombre.HeaderText = "Nombre";
            col_nombre.Name = "col_nombre";
            col_nombre.ReadOnly = true;
            col_nombre.Resizable = DataGridViewTriState.False;
            col_nombre.Width = 80;
            // 
            // col_apellido
            // 
            col_apellido.Frozen = true;
            col_apellido.HeaderText = "Apellido";
            col_apellido.Name = "col_apellido";
            col_apellido.ReadOnly = true;
            col_apellido.Resizable = DataGridViewTriState.False;
            col_apellido.Width = 80;
            // 
            // col_dni
            // 
            col_dni.Frozen = true;
            col_dni.HeaderText = "Dni";
            col_dni.Name = "col_dni";
            col_dni.ReadOnly = true;
            col_dni.Resizable = DataGridViewTriState.False;
            // 
            // frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 298);
            Controls.Add(dgv_clientes);
            Controls.Add(btn_borrar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_nuevo);
            Controls.Add(txt_dni);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_clientes";
            Text = "Gestion Clientes";
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private TextBox txt_dni;
        private Button btn_nuevo;
        private Button btn_guardar;
        private Button btn_borrar;
        private DataGridView dgv_clientes;
        private DataGridViewTextBoxColumn col_nombre;
        private DataGridViewTextBoxColumn col_apellido;
        private DataGridViewTextBoxColumn col_dni;
    }
}