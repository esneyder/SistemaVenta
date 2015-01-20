using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class VendedorDatos
    {
        string Conexion = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        SqlDataReader dr;
        public VendedorDatos(){}

        //Metodo para seleccionar todos Vendedor
        public List<VendedorEntidad> ListarVendedor()
        {
            using (SqlConnection cone = new SqlConnection(Conexion))//obtiniendo y abriendo la conexion a sql 
            { 
                using(SqlCommand cmd = new SqlCommand("ListarVendedor",cone))//se crea un objeto sqlcomand el cual lleva el nombre del procedimiento y una instancia de conexion
                {
                    cmd.CommandType=CommandType.StoredProcedure;//commandType=tipo de comando es un procedimiento almacena
                    cone.Open();
                    List<VendedorEntidad> entidad = new List<VendedorEntidad>();
                    using (SqlDataReader dr = cmd.ExecuteReader())//sqldatareader se usa para guardar los resultados de consultas a Bases de Datos 
                    {
                        while (dr.Read()) 
                        {
                            VendedorEntidad obj = new VendedorEntidad();
                            obj.idVendedor =Convert.ToInt32(dr["idVendedor"].ToString());
                            obj.nombreVende = dr["nombreVende"].ToString();
                            obj.apeVende = dr["apeVende"].ToString();
                            obj.dniVende = Convert.ToInt32((dr["dniVende"].ToString()));
                            obj.direcVende = dr["direcVende"].ToString();
                            obj.celularVende = dr["celularVende"].ToString();
                            obj.telVende = dr["telVende"].ToString();
                            entidad.Add(obj);
                        }
                    }
                    return entidad;
                }
            }
        }
        //Metodo para seleccionar solo un vendedor con su dni
        public List<VendedorEntidad> ListarVendedorDni(string dni) 
        {
            using (SqlConnection cone = new SqlConnection(Conexion)) 
            {
                using (SqlCommand cmd = new SqlCommand("buscarVendeDni",cone))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dni",dni);//agregando el parametro para poder buscar
                    cone.Open();
                    List<VendedorEntidad> entidad = new List<VendedorEntidad>();
                    using (SqlDataReader dr = cmd.ExecuteReader())//DataReader es para visualizar y leer una fila 
                    {
                        while (dr.Read())//que lea todas las variables que hayan
                        {
                            VendedorEntidad obj = new VendedorEntidad();
                            obj.idVendedor = Convert.ToInt32(dr["idVendedor"].ToString());
                            obj.nombreVende = dr["nombreVende"].ToString();
                            obj.apeVende = dr["apeVende"].ToString();
                            obj.dniVende = Convert.ToInt32(dr["dniVende"].ToString());
                            obj.direcVende = dr["direcVende"].ToString();
                            obj.celularVende = dr["celularVende"].ToString();
                            obj.telVende = dr["telVende"].ToString();
                            entidad.Add(obj);   
                        }
                    }
                    return entidad;
                }
            }
        }
        //Metodo para InsertarVendedor
        public int InsertarVendedor(VendedorEntidad atr) //Accede a la clase VendedorEntidadpara poder utilizar los valores
        {
            using(SqlConnection conn = new SqlConnection(Conexion))
            {
                using (SqlCommand cmd = new SqlCommand("InsertarVendedor",conn))//sqlcommand requiere de dos parametros uno que es nomnre del procedimiento y la instancia de conexion
               {
                   cmd.CommandType = CommandType.StoredProcedure;//indica como el commandtext debe ser interpretado , y en commandtype hace que commandtext sea interpretado como procedimineto almacenado
                   cmd.Parameters.AddWithValue("@idVendedor",atr.idVendedor);
                   cmd.Parameters.AddWithValue("@nombreVende",atr.nombreVende);
                   cmd.Parameters.AddWithValue("@apeVende", atr.apeVende);
                   cmd.Parameters.AddWithValue("@dniVende", atr.dniVende);
                   cmd.Parameters.AddWithValue("@direcVende",atr.direcVende);
                   cmd.Parameters.AddWithValue("@celularVende", atr.celularVende);
                   cmd.Parameters.AddWithValue("@telVende",atr.telVende);
                   conn.Open();
                   cmd.ExecuteNonQuery();//ejecutar el procedimiento 
                   return 1;
               }
            }
           
        }
        //Metodo para validar si un usuario ya existe
        public int VerificarVendedor(int dni) 
        {
            int Contador = 0;
            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                using (SqlCommand cmd = new SqlCommand("VerificarVende", conn)) 
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dniVende",dni);
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader()) 
                    {
                        while (dr.Read()) 
                        {
                            Contador++;
                        }
                    }  
                }
                return Contador;
            }

        }
        //Metodo para Actualizar
        public int ActualizarVendedor(VendedorEntidad atr) 
        {
            
            using(SqlConnection conn = new SqlConnection(Conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ActualizaVende", conn)) 
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idVendedor", atr.idVendedor);
                    cmd.Parameters.AddWithValue("@nombreVende", atr.nombreVende);
                    cmd.Parameters.AddWithValue("@apeVende", atr.apeVende);
                    cmd.Parameters.AddWithValue("@dniVende", atr.dniVende);
                    cmd.Parameters.AddWithValue("@direcVende", atr.direcVende);
                    cmd.Parameters.AddWithValue("@celularVende", atr.celularVende);
                    cmd.Parameters.AddWithValue("@telVende", atr.telVende);
                    conn.Open();
                    cmd.ExecuteNonQuery();//ejecutar el procedimiento 
                    return 1;
                }
            }
        }
        //Metodo Eliminar


 
        public int EliminarVendedor(int atr) 
        {
            using (SqlConnection cone = new SqlConnection(Conexion)) 
            {
                using (SqlCommand cmd = new SqlCommand("eliminarVende", cone)) 
                {
                    cmd.CommandType = CommandType.StoredProcedure;//el tipo de comando que vamos a usar es un stored procedure
                    cmd.Parameters.AddWithValue("@idVendedor", atr);
                    cone.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }
            }
            
        }
    }
}
