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
    public partial class Form2Pedido : Form
    {
        public Form2Pedido()
        {
            InitializeComponent();
        }


        public Form2Pedido(String cant,  String tipomedicamento, String nombreproducto, String text, String text2, String dist)
        {
            InitializeComponent();
            this.Text = "Pedido al distribuidor:" + dist;
            txtMedicamentoSolicitado.Text = cant+ " unidades de " + tipomedicamento+ " " +nombreproducto;
            txtDireccionSolicitada.Text = "Para la farmacia situada en:" + text + text2;

        }

        

        private void Form2Pedido_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Pedido enviado");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void txtMedicamentoSolicitado_TextChanged(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

        }
    }
}
