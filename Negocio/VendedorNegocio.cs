using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class VendedorNegocio
    {
        VendedorDatos obj = new VendedorDatos();
        public VendedorNegocio(){}//Constructor por default

        public List<VendedorEntidad> listarVendedor() 
        {
            try
            {
                return obj.ListarVendedor();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<VendedorEntidad> listarVendedorDni(string dni) 
        {
            try
            {
                return obj.ListarVendedorDni(dni);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public int InsertarVendedor(VendedorEntidad atr) 
        {
            int resul = 0;
            try
            {
                resul=obj.InsertarVendedor(atr);
            }
            catch (Exception)
            {
                 
                
            }
            return 1;
        }
        
        public int ActualizarVendedor(VendedorEntidad atr) 
        {
            try
            {
                return obj.ActualizarVendedor(atr);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public int eliminarVendedor(int atr) 
        {

            try
            {
                return obj.EliminarVendedor(atr);
            }
            catch (Exception ex)
            {

                throw;
               
            }
        }

    }
}
