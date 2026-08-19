namespace pryArgentoJoseGestionIntegral
{
    public partial class frm_gestion_principal : Form
    {
        public frm_gestion_principal()
        {
            InitializeComponent();
        }

        private void mostrar_pantalla(Form pantalla)
        {
            pantalla.TopLevel = false;
            pantalla.FormBorderStyle = FormBorderStyle.None;
            pantalla.Dock = DockStyle.Fill;

            pnl_contenido.Controls.Clear();
            pnl_contenido.Controls.Add(pantalla);
            pantalla.Show();
        }

        private void frm_gestion_principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            mostrar_pantalla(new frm_clientes());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            frm_gestion_principal.ActiveForm.Close();
        }
    }
}
