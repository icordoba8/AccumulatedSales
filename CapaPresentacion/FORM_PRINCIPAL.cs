using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FORM_PRINCIPAL : Form
    {
        private Form formularioActivo = null;
        public FORM_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void wapper_Paint(object sender, PaintEventArgs e)
        {

        }
        public void PantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void FORM_PRINCIPAL_Load(object sender, EventArgs e)
        {
            PantallaOK();
        }

       
        private void SeleccionaBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(0, 99, 177);
            }
        }
        private void SeguiBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            Flecha.Top = sender.Top;
        }
        private void AbrirFormulario(Form FormHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            Wapper.Controls.Add(FormHijo);
            Wapper.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();


        }

       
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SeleccionaBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguiBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            SeleccionaBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguiBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormulario( new FORM_VENTAS());
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            SeleccionaBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguiBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormulario(new FORM_PEDIDO());
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            SeleccionaBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguiBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormulario(new FORM_COMISIONES());
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea cerrar la aplicación.", "", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
               Application.Exit();
            }
            
            
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
