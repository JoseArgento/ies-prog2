namespace PRYArgentoJoseGestor
{
    public partial class frm_gestor : Form
    {
        public frm_gestor()
        {
            InitializeComponent();
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_prioridad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_gestor_Load(object sender, EventArgs e)
        {
            cmb_prioridad.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            dgv_tareas.Rows.Add(false, txt_tarea.Text, cmb_prioridad.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_tareas.CurrentRow == null) return;
            dgv_tareas.CurrentRow.Cells[0].Value = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_tareas.CurrentRow == null) return;
            if (dgv_tareas.CurrentRow.IsNewRow) return;

            dgv_tareas.Rows.Remove(dgv_tareas.CurrentRow);
        }
    }
}
