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
        //Variables para direcciones del checkbox
        string dir1,dir2;
        //variable para guardar el nombre radio buton
        string dist;

        public Form1()
        {
            InitializeComponent();
        }



        private void btnOk_Click(object sender, EventArgs e)
        {

            //Control de errores 
            //Valida que los campos requeridos esten ingresados correctamente, ademas valida que sea un numero en la cantidad de productos
            if (txtNombreMedicamento.Text != "" && txtCantidadProducto.Text != "" && cmbTipoMedicamento.SelectedItem != null)
            {
                                if (  chckbPrincipal.Checked != false || chkbSecunadria.Checked != false )
                                {                       
                   
                                    //Conveierte los datos en extring 
                                    string tipomedicamento = Convert.ToString(cmbTipoMedicamento.SelectedItem);                    
                                    string cantidad= Convert.ToString(txtCantidadProducto.Text);                   
                                    string nombreproducto=Convert.ToString( txtNombreMedicamento.Text);
                    

                                    //condificones para elegir en los checkbox 
                                    if (chckbPrincipal.Checked == true && chkbSecunadria.Checked == true )
                                    {
                                        dir1 = "Eloy Alfaro y Mejía";
                                        dir2 = "Av.del Pacífico y Simón Plata Torres";                                              
                                    }
                                    else if (chckbPrincipal.Checked == true)
                                    {
                                        dir1 = "Eloy Alfaro y Mejía";                                              
                                    }
                                    else if (chkbSecunadria.Checked == true)
                                    {                        
                                        dir2 = "Av.del Pacífico y Simón Plata Torres ";                                                              
                                    }

                                    //condificones para elegir en los radiobuton
                                    if (rdbCemefar.Checked==true)
                                    {
                                        dist = "Cemefar";
                                    }
                                    else if (rdbCofarma.Checked == true)
                                    {
                                        dist = "Cofarma";
                                    }
                                    else if (rdbEmpsephar.Checked == true)
                                    {
                                        dist = "Empsephar";
                                    }

                                    //Llamado al segundo formulario Form2Predido

                                    //Instanciamos la clase del segundo formulario y creamos un objeto llamado form2Pedido, este accede los componentes de la clase

                                    //llamamos al objeto y mostramos el formilario con Show();
                                    // form2Pedido.Visible = true;
                                    Form2Pedido form2Pedido = new Form2Pedido(cantidad, tipomedicamento,nombreproducto, dir1, dir2,dist);
                                    form2Pedido.Show();
                    

                                }
                                else
                                {
                                    MessageBox.Show("Escoja almenos una direccion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }







            }
            else //if (chkbSecunadria.Checked != false && chckbPrincipal.Checked != false)
            {
                MessageBox.Show("Ingrese nombre del medicamento ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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



        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Esta condicion valida que si cualquier tecla precionada es diferente a un numero o espacio en blanco, muestra un mensaje de advertencia al usuario que permite solo numeros
            if ( !( char.IsLetter(e.KeyChar) )  &&  (e.KeyChar != (char)Keys.Back)  && !(char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Ingrese solo letras y numeros en el nombre de medicamento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombreMedicamento.Text = "";
            txtCantidadProducto.Text  = "";
            dir1 = "";
            dir2 = "";
            dist = "";
            chkbSecunadria.Checked = false;
            chckbPrincipal.Checked = false;
            cmbTipoMedicamento.SelectedItem = null;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
