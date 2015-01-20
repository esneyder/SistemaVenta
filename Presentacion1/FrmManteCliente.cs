using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;
using Datos;

namespace Presentacion1
{
    public partial class FrmManteCliente : Form
    {
        public FrmManteCliente()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        //Metodos CRUD
        private void InsertarDatos() 
        {
            VendedorEntidad objE = new VendedorEntidad();
            VendedorNegocio objN = new VendedorNegocio();
            VendedorDatos objD = new VendedorDatos();
            int r = 0;
            if (objD.VerificarVendedor(Convert.ToInt32(txtdni.Text)) == 0)
            {
                objE.idVendedor = Convert.ToInt32(txtCod.Text);
                objE.nombreVende = txtnom.Text;
                objE.apeVende = txtape.Text;
                objE.dniVende = Convert.ToInt32(txtdni.Text);
                objE.direcVende = txtdire.Text;
                objE.celularVende = txtcelu.Text;
                objE.telVende = txttele.Text;
                r = objN.InsertarVendedor(objE);
                if (r > 0)
                {
                    MessageBox.Show("Usuario Registrado Corretamente");
                    CargarDatos();
                    LimpiarCampos();


                    

                }
                else
                {
                    MessageBox.Show("Error Al Guardar Los Datos.");
                }
            }
            else
            {
                MessageBox.Show("el usuario ya existe");
            }
        }
        //Mostrar Datos en el datagridview
        private void CargarDatos() 
        {
            VendedorNegocio objN = new VendedorNegocio();
            List<VendedorEntidad> listaVende;
            listaVende = objN.listarVendedor();
            dataGridView1.DataSource = listaVende;
        }
        //Metodo Actualizar
        private void ActualizarDatos() 
        {
            int r = 0;
            VendedorEntidad objE = new VendedorEntidad();
            VendedorNegocio objN = new VendedorNegocio();
            objE.idVendedor = Convert.ToInt32( txtCod.Text);
            objE.nombreVende = txtnom.Text;
            objE.apeVende = txtape.Text;
            objE.dniVende = Convert.ToInt32(txtdni.Text);
            objE.direcVende = txtdire.Text;
            objE.celularVende = txtcelu.Text;
            objE.telVende = txttele.Text;
            r = objN.ActualizarVendedor(objE);
            if (r > 0) 
            {
                MessageBox.Show("Usuario Actualizado Corretamente");
                CargarDatos();
            }
        }
        private void LimpiarCampos() 
        {
            txtCod.Clear();
            txtnom.Clear();
            txtape.Clear();
            txtdni.Clear();
            txtCelular.Clear();
            txtdire.Clear();
            txttele.Clear();
        }
        //MetodoEliminar
        private void EliminarDatos() 
        {
            VendedorEntidad objE = new VendedorEntidad();
            VendedorNegocio objN = new VendedorNegocio();
            
            
        }
        //Fin Metodos

        public void InsertarRegistro() 
        {

            InsertarDatos();

            LimpiarCampos();
            
           
        
        }

       
        private void btnInsertar_Click(object sender, EventArgs e)
        {

            InsertarRegistro();
            
        }

        //Metodo para que los datos aparezcan en datagridview
       
        private void btnBuscardni_Click(object sender, EventArgs e)
        {
            VendedorNegocio objN = new VendedorNegocio();
            List<VendedorEntidad> listaVende;
            string dni = txtBuscarDni.Text;
            listaVende = objN.listarVendedorDni(dni);
            if(listaVende.Count>0)
            {
                //Obteniendo los valores para llevarlos a las cajas
                txtCod.Text = listaVende[0].idVendedor.ToString();
                txtnom.Text = listaVende[0].nombreVende.ToString();
                txtape.Text = listaVende[0].apeVende.ToString();
                txtdni.Text = listaVende[0].dniVende.ToString();
                txtdire.Text = listaVende[0].direcVende.ToString();
                txtcelu.Text = listaVende[0].celularVende.ToString();
                txttele.Text = listaVende[0].telVende.ToString();

            }
            else 
            {
                LimpiarCampos();
            }
        }

        //Metodo para que los datos aparezcan en datagridview
        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnActul_Click(object sender, EventArgs e)
        {
            VendedorNegocio objn = new VendedorNegocio();
            List<VendedorEntidad> listaVende;
            string dni = txtdni.Text;
            listaVende = objn.listarVendedorDni(dni);
            if (listaVende.Count > 0)
            {
                ActualizarDatos();
            }
            else
            {
                LimpiarCampos();
            }


        }

        private void btnElimi_Click(object sender, EventArgs e)
        {
            VendedorEntidad objE = new VendedorEntidad();
            VendedorNegocio objN = new VendedorNegocio();

            objE.dniVende = Convert.ToInt32(txtCod.Text);

           

            if (objN.eliminarVendedor(Convert.ToInt32(txtCod.Text)) > 0) 
            {
                MessageBox.Show("Eliminado");
            }
            else 
            {
                MessageBox.Show("Error");
            }


        }

        

       
       
    }
}

