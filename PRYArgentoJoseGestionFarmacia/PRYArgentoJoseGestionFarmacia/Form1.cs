namespace PRYArgentoJoseGestionFarmacia
{
    public partial class frm_gestion_farmacia : Form
    {
        public frm_gestion_farmacia()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            dgv_farmacia.Rows.Add(txt_medicamento.Text, txt_precio.Text, txt_stock.Text);
            txt_medicamento.Clear();
            txt_codigo.Clear();
            txt_laboratorio.Clear();
            txt_precio.Clear();
            txt_stock.Clear();
            txt_medicamento.Focus();
        }

        private void frm_gestion_farmacia_Load(object sender, EventArgs e)
        {
            cmb_tipo.SelectedIndex = 0;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (dgv_farmacia.CurrentRow == null) return;
            if (dgv_farmacia.CurrentRow.IsNewRow) return;

            dgv_farmacia.Rows.Remove(dgv_farmacia.CurrentRow);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_farmacia.CurrentRow == null) return;
            if (dgv_farmacia.CurrentRow.IsNewRow) return;

            dgv_farmacia.CurrentRow.Cells[0].Value = txt_medicamento.Text;
            dgv_farmacia.CurrentRow.Cells[1].Value = txt_precio.Text;
            dgv_farmacia.CurrentRow.Cells[2].Value = txt_stock.Text;

            txt_medicamento.Clear();
            txt_codigo.Clear();
            txt_laboratorio.Clear();
            txt_precio.Clear();
            txt_stock.Clear();
            txt_medicamento.Focus();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string seleccion = txt_medicamento.Text;

            foreach (DataGridViewRow r in dgv_farmacia.Rows) 
            {
                if (r.Cells[0].Value.ToString() != seleccion) r.Visible = false;
                if (r.Cells[0].Value.ToString() == seleccion) r.Visible = true;
            }
        }
    }
}
