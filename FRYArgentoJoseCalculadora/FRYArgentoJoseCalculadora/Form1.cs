namespace FRYArgentoJoseCalculadora
{
    public partial class frm_calculadora : Form
    {
        public frm_calculadora()
        {
            InitializeComponent();
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = (int.Parse(txt_num1.Text) + int.Parse(txt_num2.Text)).ToString();
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = (int.Parse(txt_num1.Text) - int.Parse(txt_num2.Text)).ToString();
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = (int.Parse(txt_num1.Text) * int.Parse(txt_num2.Text)).ToString();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = (int.Parse(txt_num1.Text) / int.Parse(txt_num2.Text)).ToString();
        }
    }
}
