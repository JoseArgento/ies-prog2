namespace PRYArgentoJoseLogin
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txt_usuario.Text;
            string pwd = txt_clave.Text;

            if ((user == "DoblePupi" && pwd == "Milenial_j3j3") ||
                (user == "Esmeralda" && pwd == "Esme") ||
                (user == "Safiro" && pwd == "Safi_la_mejor") ||
                (user == "ElAdmin" && pwd == "SoyUnCapo"))
            {
                lbl_mensaje.Text = "";
                MessageBox.Show("Ingreso Exitoso", "Información correcta");
            }
            else
            {
                lbl_mensaje.Text = "❌ Usuario o contraseña erróneos";
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
