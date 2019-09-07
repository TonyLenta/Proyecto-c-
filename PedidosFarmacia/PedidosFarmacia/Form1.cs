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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Control de errores 
            //Validad que los campos requeridos esten ingresados correctamente
            if (txtNombreMedicamento.Text != ""  && txtCantidadProducto.Text != "" && chkbSecunadria.Checked !=false  || chckbPrincipal.Checked != false)
            {

                if ( Convert.ToInt32(txtCantidadProducto.Text) < 0)

                {
                    MessageBox.Show("Ingrese una cantidad mayor a cero");
                }
                else
                {
                    MessageBox.Show("Datos ingresados correctamente");
                }


               
            }
            else
            {
                MessageBox.Show("Rellene todos los datos o ingrese correctamente");
            }
        }

       
    }
}
