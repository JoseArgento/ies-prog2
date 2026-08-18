namespace FRYArgentoJoseConversor
{
    public partial class frm_conversor : Form
    {
        public frm_conversor()
        {
            InitializeComponent();
        }

        private void btn_convertir_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txt_valor.Text);

            lbl_resultado.Text = "";
            lbl_resultado.Text = (cb_desde.Text == "Metros") ? (valor * 100).ToString() + " cm" : (valor / 100).ToString() + " mts";


            //if (cb_desde.SelectedText == "Metros")
            //{
            //    lbl_resultado.Text = (double.Parse(txt_valor.Text) * 100).ToString();
            //}
            //else
            //{
            //    lbl_resultado.Text = (double.Parse(txt_valor.Text) / 100).ToString();
            //}
        }
    }
}
