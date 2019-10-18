using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class ProductoNegocio
    {
        /*
            
    public class NProducto
    {
        public List<Producto> listarProductos() {AccesoDatos datos = new AccesoDatos();
            try
            {
                String query = "SELECT Id,Titulo,Descripcion, URLImagen FROM Productos";
                datos.seterQuery(query);
                List<Producto> listarProductos = new List<Producto>();
                Producto aux;
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Producto();
                    aux.id =Convert.ToInt32(datos.SqlDataReader["Id"]);
                    aux.titulo = (String)datos.SqlDataReader["Titulo"].ToString();
                    aux.descripcion = (String)datos.SqlDataReader["Descripcion"].ToString();
                    aux.urlImagen = (String)datos.SqlDataReader["URLImagen"].ToString();

                    listarProductos.Add(aux);
                }
                datos.CerrarConexionDB();
                return listarProductos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
       
            
        }

        public Producto elegirProducto(int id)
        {
            //Producto producto = new Producto();
            Producto aux= new Producto(); 
            Producto elegido= new Producto();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                String query = "SELECT Id, Titulo, Descripcion, URLImagen FROM Productos WHERE Id="+id;
                datos.seterQuery(query);
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                        aux.id = Convert.ToInt32(datos.SqlDataReader["Id"]);
                        aux.titulo = (String)datos.SqlDataReader["Titulo"].ToString();
                        aux.descripcion = (String)datos.SqlDataReader["Descripcion"].ToString();
                        aux.urlImagen = (String)datos.SqlDataReader["URLImagen"].ToString();
                        elegido = aux;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexionDB();
            }
            return elegido;
        }
    }

        */
    }
}
