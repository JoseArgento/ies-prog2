namespace PRYArgentoJoseGestionFarmacia
{
    partial class frm_gestion_farmacia
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
            label4 = new Label();
            label5 = new Label();
            txt_medicamento = new TextBox();
            txt_laboratorio = new TextBox();
            txt_codigo = new TextBox();
            txt_precio = new TextBox();
            txt_stock = new TextBox();
            label6 = new Label();
            cmb_tipo = new ComboBox();
            btn_agregar = new Button();
            btn_modificar = new Button();
            btn_borrar = new Button();
            dgv_farmacia = new DataGridView();
            btn_buscar = new Button();
            col_medicamento = new DataGridViewTextBoxColumn();
            col_precio = new DataGridViewTextBoxColumn();
            col_stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_farmacia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Medicamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 46);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Laboratorio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 73);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 99);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 124);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Stock:";
            // 
            // txt_medicamento
            // 
            txt_medicamento.Location = new Point(112, 17);
            txt_medicamento.Name = "txt_medicamento";
            txt_medicamento.Size = new Size(160, 23);
            txt_medicamento.TabIndex = 5;
            // 
            // txt_laboratorio
            // 
            txt_laboratorio.Location = new Point(112, 43);
            txt_laboratorio.Name = "txt_laboratorio";
            txt_laboratorio.Size = new Size(160, 23);
            txt_laboratorio.TabIndex = 6;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(112, 70);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(160, 23);
            txt_codigo.TabIndex = 7;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(112, 96);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(160, 23);
            txt_precio.TabIndex = 8;
            // 
            // txt_stock
            // 
            txt_stock.Location = new Point(112, 121);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(160, 23);
            txt_stock.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 169);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Tipo:";
            // 
            // cmb_tipo
            // 
            cmb_tipo.FormattingEnabled = true;
            cmb_tipo.Items.AddRange(new object[] { "Venta Libre", "Receta", "Solo laboratorio" });
            cmb_tipo.Location = new Point(112, 166);
            cmb_tipo.Name = "cmb_tipo";
            cmb_tipo.Size = new Size(160, 23);
            cmb_tipo.TabIndex = 11;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(23, 204);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 12;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(112, 204);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 13;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(197, 204);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(75, 23);
            btn_borrar.TabIndex = 14;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
            // 
            // dgv_farmacia
            // 
            dgv_farmacia.AllowUserToAddRows = false;
            dgv_farmacia.AllowUserToDeleteRows = false;
            dgv_farmacia.AllowUserToResizeRows = false;
            dgv_farmacia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_farmacia.Columns.AddRange(new DataGridViewColumn[] { col_medicamento, col_precio, col_stock });
            dgv_farmacia.Location = new Point(23, 233);
            dgv_farmacia.Name = "dgv_farmacia";
            dgv_farmacia.ReadOnly = true;
            dgv_farmacia.RowHeadersVisible = false;
            dgv_farmacia.Size = new Size(249, 150);
            dgv_farmacia.TabIndex = 15;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(22, 389);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(165, 23);
            btn_buscar.TabIndex = 16;
            btn_buscar.Text = "Buscar Medicamento";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // col_medicamento
            // 
            col_medicamento.HeaderText = "Medicamento";
            col_medicamento.Name = "col_medicamento";
            col_medicamento.ReadOnly = true;
            // 
            // col_precio
            // 
            col_precio.HeaderText = "Precio";
            col_precio.Name = "col_precio";
            col_precio.ReadOnly = true;
            // 
            // col_stock
            // 
            col_stock.HeaderText = "Stock";
            col_stock.Name = "col_stock";
            col_stock.ReadOnly = true;
            // 
            // frm_gestion_farmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 421);
            Controls.Add(btn_buscar);
            Controls.Add(dgv_farmacia);
            Controls.Add(btn_borrar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_agregar);
            Controls.Add(cmb_tipo);
            Controls.Add(label6);
            Controls.Add(txt_stock);
            Controls.Add(txt_precio);
            Controls.Add(txt_codigo);
            Controls.Add(txt_laboratorio);
            Controls.Add(txt_medicamento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_gestion_farmacia";
            Text = "Gestión Farmacia";
            Load += frm_gestion_farmacia_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_farmacia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_medicamento;
        private TextBox txt_laboratorio;
        private TextBox txt_codigo;
        private TextBox txt_precio;
        private TextBox txt_stock;
        private Label label6;
        private ComboBox cmb_tipo;
        private Button btn_agregar;
        private Button btn_modificar;
        private Button btn_borrar;
        private DataGridView dgv_farmacia;
        private Button btn_buscar;
        private DataGridViewTextBoxColumn col_medicamento;
        private DataGridViewTextBoxColumn col_precio;
        private DataGridViewTextBoxColumn col_stock;
    }
}
