using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio.COMISION;

namespace CapaPresentacion
{
    public partial class FORM_COMISIONES : Form
    {



        List<string[]> MESES = new List<string[]>();
        String MES;
        int ANO;
        public FORM_COMISIONES()
        {
            InitializeComponent();
            GET_MESES();


        }

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fecha_onValueChanged(object sender, EventArgs e)
        {

        }

        public void GET_COMISIONES ()
        {
            try
            {

                
                if (MES == null)
                {
                    MessageBox.Show("Seleccione un mes de la lista");
                    return;
                }
               
                N_COMISION COMISION = new N_COMISION();
                List<E_COMISION> COMISIONES = COMISION.GET_COMISIONES(MES, ANO.ToString());
                tablaItems.DataSource = COMISIONES;
                tablaItems.Columns[0].Width = 390;
                tablaItems.Columns[1].Width = 290;
                if (COMISIONES.Count() == 0)
                {
                    MessageBox.Show("No se encontraron registro con el mes seleccionado");
                }

                //tablaItems.Columns[1].Width = 60;
            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught." + e);

            }
        }

        private void FORM_COMISIONES_Load(object sender, EventArgs e)
        {

        }

        public void GET_MESES()
        {

            
            MESES.Add(new string[] { "1", "Enero" });
            MESES.Add(new string[] { "2", "Febrero" });
            MESES.Add(new string[] { "3", "Marzo" });
            MESES.Add(new string[] { "4", "Abril" });
            MESES.Add(new string[] { "5", "Mayo" });
            MESES.Add(new string[] { "6", "Junio" });
            MESES.Add(new string[] { "7", "Julio" });
            MESES.Add(new string[] { "8", "Agosto" });
            MESES.Add(new string[] { "9", "Septiembre" });
            MESES.Add(new string[] { "10", "Octubre" });
            MESES.Add(new string[] { "11", "Noviembre" });
            MESES.Add(new string[] { "22", "Diciembre" });
            
            foreach (var MES in MESES)
            {
                comboxMes.Items.Add(MES[1]);
            }
            DateTime NOW = DateTime.Today;
            ANO =  Int32.Parse(NOW.ToString("yyyy"));
            MES = Int32.Parse(NOW.ToString("MM")).ToString();
            comboxAno.Items.Add(ANO.ToString());
            comboxAno.Items.Add(ANO-1);

            comboxMes.SelectedItem = MES_SELECCIONADO(0, MES.ToString());
            //MessageBox.Show(MES_SELECCIONADO(1, MES.ToString()));


        }

        private void comboxMes_SelectedIndexChanged(object sender, EventArgs e)
        {

            MES = MES_SELECCIONADO(0, comboxMes.SelectedItem.ToString());
            if (ANO.ToString()!=null)
            {
                GET_COMISIONES();
            }
           
            //MessageBox.Show(MES);
        }

        private void comboxAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ANO = Int32.Parse(comboxAno.SelectedItem.ToString());
            GET_COMISIONES();
        }

        public string  MES_SELECCIONADO (int INDEX, string TEXT)
        {
            string[] messeleccionado = MESES.Find((MES) => MES[1].ToString() == TEXT || MES[0].ToString() == TEXT);
            return messeleccionado[INDEX].ToString();
        }
    }
}
