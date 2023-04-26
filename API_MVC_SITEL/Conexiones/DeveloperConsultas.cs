using API_MVC_SITEL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API_MVC_SITEL.Conexiones
{
    public class DeveloperConsultas
    {
        /// <summary>
        /// se listan los desarrolladores que estan habilitados
        /// </summary>
        /// <param name="idApp"></param>
        /// <param name="contra"></param>
        /// <returns></returns>
        public static IEnumerable<Developer> lstDevelopers(Security security)
        {
            List<Developer> developers = new List<Developer>();

            using (SqlConnection connection = new Conexion().conectar)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("lista_Developers", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Enabled", 1));
                cmd.Parameters.Add(new SqlParameter("@SecurityApp", security.SecurityApp));
                cmd.Parameters.Add(new SqlParameter("@SecurityKey", security.SecurityKey));
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    developers.Add(new Developer()
                    {
                        FirstName = dr.GetString(1),
                        SecondName = dr.GetString(2),
                        FirstSurname = dr.GetString(3),
                        SecondSurname = dr.GetString(4),
                        Phone = dr.GetString(5),
                        Email = dr.GetString(6),
                        CreatedBy = dr.GetString(7),
                        CreatedDate = dr.GetDateTime(8),
                        ModifiedBy = dr.GetString(9),
                        ModifiedDate = dr.GetDateTime(10),
                        Enabled = dr.GetByte(11),
                    });
                }
            }
            return developers;
        }

        /// <summary>
        /// se inserta un desarrollador 
        /// </summary>
        /// <param name="idApp"></param>
        /// <param name="contra"></param>
        /// <param name="developer"></param>
        /// <returns></returns>
        public static string insertarDeveloper(Developer developer, Security security)
        {
            string mensaje = "";

            using (SqlConnection connection = new Conexion().conectar)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insertar_Developer", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FirstName", developer.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@SecondName", developer.SecondName));
                    cmd.Parameters.Add(new SqlParameter("@FirstSurname", developer.FirstSurname));
                    cmd.Parameters.Add(new SqlParameter("@SecondSurname", developer.SecondSurname));
                    cmd.Parameters.Add(new SqlParameter("@Phone", developer.Phone));
                    cmd.Parameters.Add(new SqlParameter("@Email", developer.Email));
                    cmd.Parameters.Add(new SqlParameter("@CreatedBy", developer.CreatedBy));
                    cmd.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                    cmd.Parameters.Add(new SqlParameter("@ModifiedBy", developer.ModifiedBy));
                    cmd.Parameters.Add(new SqlParameter("@ModifiedDate", DateTime.Now));
                    cmd.Parameters.Add(new SqlParameter("@Enabled", 1));
                    cmd.Parameters.Add(new SqlParameter("@SecurityApp", security.SecurityApp));
                    cmd.Parameters.Add(new SqlParameter("@SecurityKey", security.SecurityKey));
                    cmd.ExecuteNonQuery();
                    mensaje = "Developer insertado correctamente";
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
                finally
                {
                    connection.Close();
                }
                
            }
            return mensaje;
        }

        /// <summary>
        /// se actualiza un desarrollador 
        /// </summary>
        /// <param name="idApp"></param>
        /// <param name="contra"></param>
        /// <param name="developer"></param>
        /// <returns></returns>
        public static string actualizarDeveloper(Developer developer, Security security)
        {
            string mensaje = "";

            using (SqlConnection connection = new Conexion().conectar)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("actualizar_Developer", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FirstName", developer.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@SecondName", developer.SecondName));
                    cmd.Parameters.Add(new SqlParameter("@FirstSurname", developer.FirstSurname));
                    cmd.Parameters.Add(new SqlParameter("@SecondSurname", developer.SecondSurname));
                    cmd.Parameters.Add(new SqlParameter("@Phone", developer.Phone));
                    cmd.Parameters.Add(new SqlParameter("@Email", developer.Email));
                    cmd.Parameters.Add(new SqlParameter("@CreatedBy", developer.CreatedBy));
                    cmd.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                    cmd.Parameters.Add(new SqlParameter("@ModifiedBy", developer.ModifiedBy));
                    cmd.Parameters.Add(new SqlParameter("@ModifiedDate", DateTime.Now));
                    cmd.Parameters.Add(new SqlParameter("@Enabled", 1));
                    cmd.Parameters.Add(new SqlParameter("@SecurityApp", security.SecurityApp));
                    cmd.Parameters.Add(new SqlParameter("@SecurityKey", security.SecurityKey));
                    cmd.ExecuteNonQuery();
                    mensaje = "Developer actualizado correctamente";
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
                finally
                {
                    connection.Close();
                }

            }
            return mensaje;
        }

        /// <summary>
        /// Se elimina un desarrollador a traves de su id se pone Enable como deshabilitado
        /// </summary>
        /// <param name="idApp"></param>
        /// <param name="contra"></param>
        /// <param name="idDeveloper"></param>
        /// <returns></returns>
        public static string eliminarDeveloper(int idDeveloper, Security security)
        {
            string mensaje = "";

            using (SqlConnection connection = new Conexion().conectar)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("eliminar_Developer", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Enabled", 0));
                    cmd.Parameters.Add(new SqlParameter("@SecurityApp", security.SecurityApp));
                    cmd.Parameters.Add(new SqlParameter("@SecurityKey", security.SecurityKey));
                    cmd.ExecuteNonQuery();
                    mensaje = "Developer eliminado correctamente";
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
                finally
                {
                    connection.Close();
                }

            }
            return mensaje;
        }
    }
}