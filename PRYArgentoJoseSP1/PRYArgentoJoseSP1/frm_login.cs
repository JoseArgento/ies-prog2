namespace PRYArgentoJoseSP1
{
    public partial class frm_login : Form
    {
        int intentos = 0;

        // Diccionario para contener usuarios y sus respectivas claves. Sí, bien seguro :D. Después le hasheamos la pass con MD5 y somos la Tamse LOL.
        Dictionary<string, string> usuarios_cargados = new Dictionary<string, string>()
        {
            {"Adm", "@1a"},
            {"John", "*2b" },
            {"Ceci", "*@3c" },
            {"God", "*@#4d" }
        };

        // Diccionario para contener los permisos de cada user.
        Dictionary<string, string[]> permisos_por_usuario = new Dictionary<string, string[]>()
        {
            {"Adm", new string[] {"ADM", "COM", "VTA" } },
            {"John", new string[] {"SIST" } },
            {"Ceci", new string[] {"ADM", "VTA" } },
            {"God", new string[] {"ADM", "SIST", "COM", "VTA" } }
        };

        // Método para limpiar los campos y poner el focus en el campo Usuario.
        private void limpiar_campos()
        {
            txt_usuario.Clear();
            txt_contrasena.Clear();

            txt_usuario.Focus();
        }

        public frm_login()
        {
            InitializeComponent();
        }

        // Carga el CMB con el valor inicial al ejecutar el programa.
        private void frm_login_Load(object sender, EventArgs e)
        {
            cmb_modulo.SelectedIndex = 0;
        }

        // Cierra el form.
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // La salsa secreta está acá.
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string user = txt_usuario.Text;
            string pass = txt_contrasena.Text;

            // Chequeamos en el diccionario de usuarios si está la key del user ingresado en el textbox, si la key existe chequeamos la pass
            // Si la pass es correcta recién ahí chequeamos si el diccionario de permisos contiene el value acorde al permiso ingresado para ese user.
            if (usuarios_cargados.ContainsKey(user) &&
                usuarios_cargados[user] == pass &&
                permisos_por_usuario[user].Contains(cmb_modulo.Text))
            {
                // Si el ingreso es correcto limpiamos los campos, el mensaje de error (de haber alguno) y mostramos el otro form en forma de dialog.
                limpiar_campos();
                lbl_error.Text = "";
                this.Hide();
                frm_inicio f_inicio = new frm_inicio();
                f_inicio.Text = user;
                f_inicio.ShowDialog();
                this.Show();
                // intentos = 0; // Reiniciamos el contador. Lo dejo comentado ya que es a discreción del profe :D
            }
            else
            {
                // Caso negativo se agrega 1 al contador de intentos y se muestra un mensaje de error. Al llegar a 2 intentos fallidos se cierra el form.
                limpiar_campos();
                intentos++;
                lbl_error.Text = "Usuario y/o contraseña incorrectos para el formulario seleccionado.";
                if (intentos >= 2) this.Close();
            }
        }
    }
}
