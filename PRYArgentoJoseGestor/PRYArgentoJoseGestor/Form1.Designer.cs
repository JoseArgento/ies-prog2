namespace PRYArgentoJoseGestor
{
    partial class frm_gestor
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
            txt_tarea = new TextBox();
            cmb_prioridad = new ComboBox();
            dtp_fecha = new DateTimePicker();
            btn_agregar = new Button();
            dgv_tareas = new DataGridView();
            CBCol = new DataGridViewCheckBoxColumn();
            Tarea = new DataGridViewTextBoxColumn();
            Prioridad = new DataGridViewTextBoxColumn();
            btn_eliminar = new Button();
            btn_completar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_tareas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Tarea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 42);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Prioridad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 75);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha";
            // 
            // txt_tarea
            // 
            txt_tarea.Location = new Point(88, 12);
            txt_tarea.Name = "txt_tarea";
            txt_tarea.Size = new Size(228, 23);
            txt_tarea.TabIndex = 3;
            // 
            // cmb_prioridad
            // 
            cmb_prioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_prioridad.FormattingEnabled = true;
            cmb_prioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cmb_prioridad.Location = new Point(88, 39);
            cmb_prioridad.Name = "cmb_prioridad";
            cmb_prioridad.Size = new Size(121, 23);
            cmb_prioridad.TabIndex = 4;
            cmb_prioridad.SelectedIndexChanged += cmb_prioridad_SelectedIndexChanged;
            // 
            // dtp_fecha
            // 
            dtp_fecha.CustomFormat = "dd/MM/yyyy";
            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.Location = new Point(88, 68);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(121, 23);
            dtp_fecha.TabIndex = 5;
            dtp_fecha.Value = new DateTime(2026, 8, 13, 0, 0, 0, 0);
            dtp_fecha.ValueChanged += dtp_fecha_ValueChanged;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(13, 101);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(156, 23);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "Agregar Tarea";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // dgv_tareas
            // 
            dgv_tareas.AllowUserToAddRows = false;
            dgv_tareas.AllowUserToDeleteRows = false;
            dgv_tareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tareas.Columns.AddRange(new DataGridViewColumn[] { CBCol, Tarea, Prioridad });
            dgv_tareas.Location = new Point(13, 130);
            dgv_tareas.Name = "dgv_tareas";
            dgv_tareas.ReadOnly = true;
            dgv_tareas.RowHeadersVisible = false;
            dgv_tareas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_tareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_tareas.Size = new Size(303, 150);
            dgv_tareas.TabIndex = 7;
            dgv_tareas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CBCol
            // 
            CBCol.Frozen = true;
            CBCol.HeaderText = "";
            CBCol.Name = "CBCol";
            CBCol.ReadOnly = true;
            CBCol.Resizable = DataGridViewTriState.True;
            CBCol.SortMode = DataGridViewColumnSortMode.Automatic;
            CBCol.Width = 25;
            // 
            // Tarea
            // 
            Tarea.HeaderText = "Tarea";
            Tarea.Name = "Tarea";
            Tarea.ReadOnly = true;
            Tarea.Width = 200;
            // 
            // Prioridad
            // 
            Prioridad.HeaderText = "Prioridad";
            Prioridad.Name = "Prioridad";
            Prioridad.ReadOnly = true;
            Prioridad.Width = 75;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(12, 286);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 23);
            btn_eliminar.TabIndex = 8;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_completar
            // 
            btn_completar.Location = new Point(94, 286);
            btn_completar.Name = "btn_completar";
            btn_completar.Size = new Size(75, 23);
            btn_completar.TabIndex = 9;
            btn_completar.Text = "Completar";
            btn_completar.UseVisualStyleBackColor = true;
            btn_completar.Click += button2_Click;
            // 
            // frm_gestor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 317);
            Controls.Add(btn_completar);
            Controls.Add(btn_eliminar);
            Controls.Add(dgv_tareas);
            Controls.Add(btn_agregar);
            Controls.Add(dtp_fecha);
            Controls.Add(cmb_prioridad);
            Controls.Add(txt_tarea);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_gestor";
            Text = "Mis Tareas";
            Load += frm_gestor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_tareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_tarea;
        private ComboBox cmb_prioridad;
        private DateTimePicker dtp_fecha;
        private Button btn_agregar;
        private DataGridView dgv_tareas;
        private Button btn_eliminar;
        private Button btn_completar;
        private DataGridViewCheckBoxColumn CBCol;
        private DataGridViewTextBoxColumn Tarea;
        private DataGridViewTextBoxColumn Prioridad;
    }
}
