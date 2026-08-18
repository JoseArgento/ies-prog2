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
        }

        private void frm_gestion_farmacia_Load(object sender, EventArgs e)
        {
            cmb_tipo.SelectedIndex = 0;
        }
    }
}
