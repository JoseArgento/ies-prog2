namespace PRYArgentoJoseAgenda
{
    public partial class frm_agenda : Form
    {
        public frm_agenda()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string tel = txt_tel.Text;

            dgv_datos.Rows.Add(nombre, tel);

            txt_nombre.Clear();
            txt_tel.Clear();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow != null) dgv_datos.Rows.RemoveAt(dgv_datos.CurrentRow.Index);
        }
    }
}
