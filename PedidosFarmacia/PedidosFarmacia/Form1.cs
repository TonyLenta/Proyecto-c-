using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosFarmacia
{
    public partial class Form1 : Form
    {
        Validacion v = new Validacion();
        public Form1()
        {
            InitializeComponent();
        }


        
        private void btnOk_Click(object sender, EventArgs e)
        {
            //Control de errores 
            //Valida que los campos requeridos esten ingresados correctamente, ademas valida que sea un numero en la cantidad de productos
            if (txtNombreMedicamento.Text != ""  && txtCantidadProducto.Text != "" && chkbSecunadria.Checked !=false  && chckbPrincipal.Checked != false  && cmbTipoMedicamento.SelectedItem != null)
            {

                

                int selectedIndex = cmbTipoMedicamento.SelectedIndex;
                Object selectedItem = cmbTipoMedicamento.SelectedItem;

                MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                                "Index: " + selectedIndex.ToString());


                //MessageBox.Show("Datos ingresados correctamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        //Control de errores
        //Metodo que valida solo numeros mayores a cero en la caja de texto cantidad de productos 
        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Esta condicion valida que si cualquier tecla precionada es diferente a un numero o espacio en blanco, muestra un mensaje de advertencia al usuario que permite solo numeros
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Cantidad de producto debe ser un número mayor a cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        
    }
}
