namespace FRYArgentoJoseRegistro
{
    public partial class frm_registrar : Form
    {
        public frm_registrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (ckb_man.Checked && ckb_tarde.Checked && ckb_noche.Checked)
            {
                MessageBox.Show("Solo se pueden elegir 2 turnos como máximo.", "Error");
                return;
            }

            string valor_sexo = rb_masc.Checked ? rb_masc.Text : rb_fem.Text;
            string valor_turno = "";
            if (ckb_man.Checked) valor_turno += ckb_man.Text + " ";
            if (ckb_tarde.Checked) valor_turno += ckb_tarde.Text + " ";
            if (ckb_noche.Checked) valor_turno += ckb_noche.Text + " ";
            string valor_carrera = cb_carrera.Text;
            MessageBox.Show("Información cargada: " + "\n" + "\nNombre: " + txt_nombre.Text + "\nApellido: " + txt_apellido.Text + "\nDni: " + txt_dni.Text
                + "\nSexo: " + valor_sexo + "\nTurno: " + valor_turno + "\nCarrera: " + valor_carrera, "Registro de Alumno Exitoso");
        }

        private void frm_registrar_Load(object sender, EventArgs e)
        {
            cb_carrera.SelectedIndex = 0;
        }
    }
}
