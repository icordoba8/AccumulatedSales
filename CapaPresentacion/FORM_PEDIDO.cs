
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;
using CapaEntidades.PEDIDO;
using CapaNegocio.CLIENTE;
using CapaNegocio.VENDEDOR;
using CapaNegocio.PRODUCTO;
using CapaNegocio.PEDIDO;
using CapaNegocio.ITEM;


namespace CapaPresentacion
{
    public partial class FORM_PEDIDO : Form
    {
        List<E_CLIENTE> clienets;
        List<E_VENDEDOR> vendedores;
        List<E_PRODUCTO> productos;
        String CLIENTE;
        String VENDEDOR;
        String NUMPEDIDO ;
        E_PRODUCTO PRODUCTO = new E_PRODUCTO();


        public FORM_PEDIDO()
        {
            InitializeComponent();
           
            textProducto.Enabled = false;
            textCantidad.Enabled = false;
            btnGuardarPedido.Enabled = true;
           

        }

        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    

        private void FORM_PEDIDO_Load(object sender, EventArgs e)
        {

        }



        public void MOSTRAR_CLIENTES(string SEARCH)
        {

            try
            {
                if (SEARCH.Length <= 3) return;
                N_CLIENTE CLIENTE = new N_CLIENTE();

                clienets = CLIENTE.BUSCAR_CLIENTE(SEARCH);
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

                foreach (E_CLIENTE clienet in clienets)
                {
                    coleccion.Add(clienet.NOMBRE.ToString());
                }

                textClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
                textClientes.AutoCompleteSource = AutoCompleteSource.CustomSource;
               textClientes.AutoCompleteCustomSource.Clear();
                textClientes.AutoCompleteCustomSource = coleccion;
            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught."+ e);
                Console.WriteLine("{0} Exception caught.", e);
            }

            
        }

        public void MOSTRAR_VENDEDORES(string SEARCH)
        {

            try
            {
                if (SEARCH.Length <= 3) return;
                N_VENDEDOR VENDEDOR = new N_VENDEDOR();
                
                vendedores = VENDEDOR.BUSCAR_VENDEDOR(SEARCH);
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                
                foreach (E_VENDEDOR vendedor in vendedores)
                {
                   // MessageBox.Show(vendedor.NOMBRE.ToString());
                    coleccion.Add(vendedor.NOMBRE.ToString());
                }




                textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

                textBox1.AutoCompleteCustomSource.Clear();
                textBox1.AutoCompleteCustomSource = coleccion;
            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught." + e);
                Console.WriteLine("{0} Exception caught.", e);
            }


        }

        public void MOSTRAR_PRODUCTOS(string SEARCH)
        {

            try
            {
                if (SEARCH.Length <= 3) return;
                N_PRODUCTO PRODUCTO = new N_PRODUCTO();

                productos = PRODUCTO.BUSCAR_PRODUCTO(SEARCH);
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

                foreach (E_PRODUCTO producto in productos)
                {
                   
                    coleccion.Add(producto.NOMBRE.ToString());
                }




                textProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
                textProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;

                textProducto.AutoCompleteCustomSource.Clear();
                textProducto.AutoCompleteCustomSource = coleccion;
            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught." + e);
                Console.WriteLine("{0} Exception caught.", e);
            }


        }



        private void textClientes_TextChanged(object sender, EventArgs e)
        {
            MOSTRAR_CLIENTES(textClientes.Text.ToString());
        }

        private void textClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                E_CLIENTE clienteseleccionado =  clienets.Find((E_CLIENTE cliente) => cliente.NOMBRE.ToString() == textClientes.Text.ToString());
                CLIENTE = clienteseleccionado.CODCLI.ToString();
                //MessageBox.Show(clienteseleccionado.CODCLI.ToString());
                if (CLIENTE != null && VENDEDOR !=null)
                {
                    btnGuardarPedido.Enabled = false;
                }
                textBox1.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void textProducto_TextChanged(object sender, EventArgs e)
        {
            MOSTRAR_PRODUCTOS(textProducto.Text.ToString());
        }

        private void textProducto_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyData == Keys.Enter)
            {
                E_PRODUCTO productoseleccionado = productos.Find((E_PRODUCTO producto) => producto.NOMBRE.ToString() == textProducto.Text.ToString());

                PRODUCTO.CODPROD= productoseleccionado.CODPROD.ToString();
                PRODUCTO.PRECIO = productoseleccionado.PRECIO;
                textCantidad.Focus();
                //MessageBox.Show(clienteseleccionado.CODCLI.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void GURADAR_PEDIDO()
        {

           

            try
            {
                //MessageBox.Show(CLIENTE);
                E_PEDIDO nuevopedido = new E_PEDIDO
                {
                    CLIENTE = CLIENTE.ToString(),
                    VENDEDOR = VENDEDOR.ToString()
                };

                N_PEDIDO PEDIDO = new N_PEDIDO();
                NUMPEDIDO = PEDIDO.CREAR_PEDIDO(nuevopedido);
                
                if (NUMPEDIDO != null)
                {
                    textProducto.Enabled = true;
                    textCantidad.Enabled = true;
                    MessageBox.Show("Nuevo pedido #"+ NUMPEDIDO);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught." +e);
                Console.WriteLine("{0} Exception caught.", e);
            }
           
            

        }
        public void GURADAR_ITEM(int CANTIDAD )
        {

            CapaEntidades.PEDIDO.E_ITEM nuevoitem = new CapaEntidades.PEDIDO.E_ITEM()
            {
                NUMPEDIDO = NUMPEDIDO.ToString(),
                PRODUCTO = PRODUCTO.CODPROD.ToString(),
                PRECIO = PRODUCTO.PRECIO,
                CANTIDAD = CANTIDAD
            };
           

            N_ITEM ITEM = new N_ITEM();

            try
            {
               
               
              string status =   ITEM.CREAR_ITEM(nuevoitem);
              GET_ITEMS();

                //MessageBox.Show(status);

            }
            catch (Exception e)
            {
                MessageBox.Show("{0} Exception caught."+ e);
                Console.WriteLine("{0} Exception caught.", e);
            }



        }

        public void GET_ITEMS()
        {
            try
            {
                N_ITEM ITEM = new N_ITEM();
                
               List<E_ITEM>  ITEMS  =  ITEM.GET_ITEMS(NUMPEDIDO);
               tablaItems.DataSource = ITEMS;

                if (ITEMS.Count > 0)
                {
                   
                    tablaItems.Columns[0].Visible = false;
                    
                    //tablaItems.Columns[0].Width = 390;
                    ///tablaItems.Columns[1].Width = 290;

                }

                textProducto.AutoCompleteCustomSource.Clear();
                textProducto.Text = "";
                textCantidad.Text = "";
                textProducto.Focus();


                //tablaItems.Columns[1].Width = 60;
            }
            catch (Exception e)
            {
                 MessageBox.Show("{0} Exception caught." + e);
              
            }
            
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
          
            if (CLIENTE != null && VENDEDOR != null)
            {
                GURADAR_PEDIDO();
            }
            else
            {
               MessageBox.Show("Selecciones cliente y vendedor ");
            }
            
            
        }

       

  

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                E_VENDEDOR vendedorseleccionado = vendedores.Find((E_VENDEDOR vendedor) => vendedor.NOMBRE.ToString() == textBox1.Text.ToString());

                VENDEDOR = vendedorseleccionado.CODVEND.ToString().Replace(" ", String.Empty);
                //MessageBox.Show(clienteseleccionado.CODCLI.ToString());

            }
        }

        private void textCantidad_TextChanged(object sender, EventArgs e)
        {


           
        }

        private void textCantidad_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == Keys.Enter)
            {
               
               if (NUMPEDIDO != null)
                {
                    int CANTIDAD = Convert.ToInt32(textCantidad.Text);
                    GURADAR_ITEM(CANTIDAD);
                }
            }
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            MOSTRAR_VENDEDORES(textBox1.Text.ToString());
        }

        private void textCantidad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void accionesTabla()
        {
            
           
         
            tablaItems.Columns[2].Visible = false;
            //tablaItems.Columns[1].FillWeight = 355;
            //tablaItems.Columns[2].FillWeight = 400;
           



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
