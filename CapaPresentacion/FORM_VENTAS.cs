using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.VENTA_DEPARTAMENTO;

namespace CapaPresentacion
{
    public partial class FORM_VENTAS : Form
    {
        String FECHA_INICIAL;
        String FECHA_FINAL;
        public FORM_VENTAS()
        {
            InitializeComponent();
            fehaInicial.Value = DateTime.Today.AddDays(-0);
            fechaFinal.Value = DateTime.Today.AddDays(-0);

            FECHA_INICIAL = fehaInicial.Value.ToString("yyyy-M-d");
            FECHA_FINAL = fechaFinal.Value.ToString("yyyy-M-d");
        }

        private void FORM_VENTAS_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void fehaInicial_onValueChanged(object sender, EventArgs e)
        {
            FECHA_INICIAL = fehaInicial.Value.ToString("yyyy-M-d");

        }

        private void fechaFinal_onValueChanged(object sender, EventArgs e)
        {
            FECHA_FINAL = fechaFinal.Value.ToString("yyyy-M-d");
        }

        public void GET_VENTAS ()
        {
            try
            {

                
                if (FECHA_INICIAL == null)
                {
                    MessageBox.Show("Seleccione una feha inicial");
                    return;
                }
                if (FECHA_FINAL == null)
                {
                    MessageBox.Show("Seleccione una feha final");
                    return;
                }

                N_VENTA_DEPARTAMENTO DEPARTAMENTO = new N_VENTA_DEPARTAMENTO();
                List<CapaEntidades.E_VENTA_DEPARTAMENTO> VENTAS = DEPARTAMENTO.GET_VENTAS(FECHA_INICIAL, FECHA_FINAL);
                tablaItems.DataSource = VENTAS;
                tablaItems.Columns[0].Visible = false;
                btnVentas.Enabled = true;
                if(VENTAS.Count()==0)
                {
                    MessageBox.Show("No se encontraron registro con el rango de fecha");
                }
                
                //tablaItems.Columns[1].Width = 60;
            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught." + e);

            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            btnVentas.Enabled = false;
            GET_VENTAS();
        }
    }
}
