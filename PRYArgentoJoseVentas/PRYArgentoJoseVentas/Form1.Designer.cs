namespace PRYArgentoJoseVentas
{
    partial class frm_Ventas
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
            txt_producto = new TextBox();
            txt_precio = new TextBox();
            txt_cant = new TextBox();
            btn_agregar = new Button();
            dgv_ventas = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label4 = new Label();
            lbl_total = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ventas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // txt_producto
            // 
            txt_producto.Location = new Point(83, 17);
            txt_producto.Name = "txt_producto";
            txt_producto.Size = new Size(180, 23);
            txt_producto.TabIndex = 3;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(83, 44);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(90, 23);
            txt_precio.TabIndex = 4;
            // 
            // txt_cant
            // 
            txt_cant.Location = new Point(83, 73);
            txt_cant.Name = "txt_cant";
            txt_cant.Size = new Size(45, 23);
            txt_cant.TabIndex = 5;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(12, 111);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(101, 23);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // dgv_ventas
            // 
            dgv_ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ventas.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, Total });
            dgv_ventas.Location = new Point(12, 140);
            dgv_ventas.Name = "dgv_ventas";
            dgv_ventas.RowHeadersVisible = false;
            dgv_ventas.Size = new Size(373, 150);
            dgv_ventas.TabIndex = 7;
            // 
            // Producto
            // 
            Producto.Frozen = true;
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.Frozen = true;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            Cantidad.Frozen = true;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            Total.Frozen = true;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 305);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 8;
            label4.Text = "Total:";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(314, 305);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(0, 15);
            lbl_total.TabIndex = 9;
            // 
            // frm_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 340);
            Controls.Add(lbl_total);
            Controls.Add(label4);
            Controls.Add(dgv_ventas);
            Controls.Add(btn_agregar);
            Controls.Add(txt_cant);
            Controls.Add(txt_precio);
            Controls.Add(txt_producto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_Ventas";
            Text = "Sistema de Ventas";
            ((System.ComponentModel.ISupportInitialize)dgv_ventas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_producto;
        private TextBox txt_precio;
        private TextBox txt_cant;
        private Button btn_agregar;
        private DataGridView dgv_ventas;
        private Label label4;
        private Label lbl_total;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
    }
}
