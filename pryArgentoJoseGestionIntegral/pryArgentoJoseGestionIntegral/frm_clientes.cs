using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryArgentoJoseGestionIntegral
{
    public partial class frm_clientes : Form
    {
        public frm_clientes()
        {
            InitializeComponent();
        }

        private void limpiar_form()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_dni.Clear();

            txt_nombre.Focus();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            dgv_clientes.Rows.Add(txt_nombre.Text, txt_apellido.Text, txt_dni.Text);
            limpiar_form();
            MessageBox.Show("Cliente cargado exitosamente", "Carga de datos");
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.CurrentRow == null) return;
            if (dgv_clientes.CurrentRow.IsNewRow) return;

            dgv_clientes.CurrentRow.Cells[0].Value = txt_nombre.Text;
            dgv_clientes.CurrentRow.Cells[1].Value = txt_apellido.Text;
            dgv_clientes.CurrentRow.Cells[2].Value = txt_dni.Text;

            limpiar_form();
            MessageBox.Show("Se modificaron los datos del cliente", "Modificacion de cliente");
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.CurrentRow == null) return;
            if (dgv_clientes.CurrentRow.IsNewRow) return;

            dgv_clientes.Rows.Remove(dgv_clientes.CurrentRow);
            limpiar_form();
            MessageBox.Show("Se borrò al cliente seleccionado", "Baja de cliente");
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_clientes.SelectedRows.Count == 1)
            {
                var fila_seleccionada = dgv_clientes.SelectedRows[0];

                txt_nombre.Text = fila_seleccionada.Cells[0].Value.ToString();
                txt_apellido.Text = fila_seleccionada.Cells[1].Value.ToString();
                txt_dni.Text = fila_seleccionada.Cells[2].Value.ToString();
            }
        }
    }
}
