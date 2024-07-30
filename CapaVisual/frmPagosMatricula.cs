using CapaNegocio;
using CapaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class frmPagosMatricula : Form
    {
        EVehiculo EntidadVehiculo = new EVehiculo();
        NVehiculo NegocioVehiculo = new NVehiculo();
        public frmPagosMatricula()
        {
            InitializeComponent();
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                EntidadVehiculo.Placa = Matriculatxt.Text;

                var resultado = NegocioVehiculo.BuscarDeuda(EntidadVehiculo);
                if (resultado.Rows.Count > 0)
                {
                    DataRow row = resultado.Rows[0];
                    Anotxt.Text = row["AÑO"].ToString();
                    Modelotxt.Text = row["MODELO"].ToString();
                    Colortxt.Text = row["COLOR"].ToString();
                    Deudatxt.Text = row["DEUDA"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para la placa proporcionada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmPagosMatricula_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                 NegocioVehiculo.PagarMatricula(EntidadVehiculo);
                 MessageBox.Show("Pago realizado con exito");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
