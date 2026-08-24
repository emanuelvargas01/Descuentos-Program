using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descuentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtValorVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuentoD_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDescuentoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVentaFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrara la aplicación","Cerrar Aplicacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorVenta.Text = "";
            txtDescuentoD.Text = "";
            txtDescuentoP.Text = "";
            txtVentaFinal.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal ValorVentas;
            decimal DescuentoS = 0;
            decimal VentaFinal = 0;
            decimal DescuentoP = 0;
          if (decimal.TryParse(txtValorVenta.Text, out decimal valorConvertido))
            {
                ValorVentas = valorConvertido;
                if (ValorVentas >= 500)
                {
                    DescuentoP = 0.30m;
                }
                else if (ValorVentas >= 300 && ValorVentas <= 499)
                {
                    DescuentoP = 0.20m;
                }
                else if (ValorVentas >= 100 && ValorVentas <= 299)
                {
                    DescuentoP = 0.10m;
                }
                else DescuentoP = 0;
                DescuentoS = ValorVentas * DescuentoP;
                VentaFinal = ValorVentas - DescuentoS;
                txtVentaFinal.Text =VentaFinal.ToString();
                txtDescuentoP.Text = (DescuentoP*100).ToString()+"%";
                txtDescuentoD.Text = DescuentoS.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor de venta valido");
                ValorVentas = 0;
            }

        }

        private void lblValorVenta_Click(object sender, EventArgs e)
        {

        }
    }
}
