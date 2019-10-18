using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {

        /*
         * 
            
        public List<Cliente> listarClientes() {
            
            AccesoDatos datos = new AccesoDatos();
            try
            {
                String query = "SELECT Id, DNI, Nombre, Apellido, Email, Direccion, Ciudad, CodigoPostal, FechaRegistro FROM Clientes";
                datos.seterQuery(query);
                List<Cliente> listarClientes = new List<Cliente>();
                Cliente aux;
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Cliente();
                    aux.dni = (int)datos.SqlDataReader["DNI"];
                    aux.apellido = (String)datos.SqlDataReader["Apellido"].ToString();
                    aux.nombre = (String)datos.SqlDataReader["Nombre"].ToString();
                    aux.email = (String)datos.SqlDataReader["Email"].ToString();
                    aux.direccion = (String)datos.SqlDataReader["Direccion"].ToString();
                    aux.ciudad = (String)datos.SqlDataReader["Ciudad"].ToString();
                    aux.cp = (String)datos.SqlDataReader["CodigoPostal"].ToString();
                    aux.fechaRegistro = (DateTime)datos.SqlDataReader["FechaRegistro"];

                    listarClientes.Add(aux);
                }
                datos.CerrarConexionDB();
                return listarClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
         
        }

        public Cliente buscarCliente(int dni)
        {
            Cliente datosCliente=new Cliente();
            //Busco el cliente, en caso de encontrarlo, debo devolver el cliente//ESTO LO VOY A USAR CUANDO EL CLIENTE QUIERA REALIZAR EL CANJE DEL VOUCHER
            //EN CASO DE NO EXISTIR DEVUELVE UN REGISTRO NULL
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterQuery("SELECT Id, DNI, Nombre, Apellido, Email, Direccion, Ciudad, CodigoPostal, FechaRegistro FROM Clientes");

                Cliente cliente;
                datos.ejecutarLector();

                while (datos.SqlDataReader.Read())
                {
                    cliente = new Cliente
                    {
                        dni = (int)datos.SqlDataReader["DNI"]
                    };
                    if (cliente.dni == dni)
                    {
                        cliente.id = Convert.ToInt32(datos.SqlDataReader["Id"]);
                        cliente.nombre = (String)datos.SqlDataReader["Nombre"].ToString();
                        cliente.apellido = (String)datos.SqlDataReader["Apellido"].ToString();
                        cliente.email = (String)datos.SqlDataReader["Email"].ToString();
                        cliente.direccion = (String)datos.SqlDataReader["Direccion"].ToString();
                        cliente.ciudad = (String)datos.SqlDataReader["Ciudad"].ToString();
                        cliente.cp = (String)datos.SqlDataReader["CodigoPostal"].ToString();
                        cliente.fechaRegistro = (DateTime)datos.SqlDataReader["FechaRegistro"];
                        datosCliente = cliente;
                    }
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
            return datosCliente;
        }
        public void altaCliente(Cliente cliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterQuery("INSERT INTO Clientes(DNI, Nombre, Apellido, Email, Direccion, Ciudad, CodigoPostal, FechaRegistro) VALUES( @DNI, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CodigoPostal, @FechaRegistro)");

                datos.agregarParametro("@DNI", cliente.dni);
                datos.agregarParametro("@Nombre", cliente.nombre);
                datos.agregarParametro("@Apellido", cliente.apellido);
                datos.agregarParametro("@Email", cliente.email);
                datos.agregarParametro("@Direccion", cliente.direccion);
                datos.agregarParametro("@Ciudad", cliente.ciudad);
                datos.agregarParametro("@CodigoPostal", cliente.cp);
                datos.agregarParametro("@FechaRegistro", cliente.fechaRegistro);

                datos.ejecutarAccion();
     
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void actualizarCliente(Cliente cliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.seterQuery("UPDATE Clientes SET Apellido = @Apellido, Nombre =@Nombre, Email=@Email, Direccion=@Direccion, Ciudad=@Ciudad, CodigoPostal=@CodigoPostal, FechaRegistro= @FechaRegistro WHERE Id=@Id ");

                datos.agregarParametro("@Apellido", cliente.apellido);
                datos.agregarParametro("@Nombre", cliente.nombre);
                datos.agregarParametro("@Email", cliente.email);
                datos.agregarParametro("@Direccion", cliente.direccion);
                datos.agregarParametro("@Ciudad", cliente.ciudad);
                datos.agregarParametro("@CodigoPostal", cliente.cp);
                datos.agregarParametro("@FechaRegistro", cliente.fechaRegistro);
                datos.agregarParametro("@Id", cliente.id);

                datos.ejecutarAccion();
              
            }
            catch (Exception ex)
            {
               throw ex;
            }
            finally
            {
                datos.CerrarConexionDB();
            }

        }
    }



         * 
         */
    }
}
