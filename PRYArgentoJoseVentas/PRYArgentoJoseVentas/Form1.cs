namespace PRYArgentoJoseVentas
{
    public partial class frm_Ventas : Form
    {
        public frm_Ventas()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            double total = double.Parse(txt_precio.Text) * double.Parse(txt_cant.Text);
            dgv_ventas.Rows.Add(txt_producto.Text, txt_precio.Text, txt_cant.Text, total);

            txt_producto.Clear();
            txt_precio.Clear();
            txt_cant.Clear();
            txt_producto.Focus();

            double total_general = 0;

            foreach (DataGridViewRow fila in dgv_ventas.Rows)
            {
                if (fila.IsNewRow) continue;
                total_general += double.Parse(fila.Cells[3].Value.ToString());
            }

            lbl_total.Text = total_general.ToString("C");
        }
    }
}
