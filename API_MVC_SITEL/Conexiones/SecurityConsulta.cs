using API_MVC_SITEL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API_MVC_SITEL.Conexiones
{
    public class SecurityConsulta
    {

        public static Security securitiesApp()
        {
            Security securities = new Security();

            using (SqlConnection connection = new Conexion().conectar)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("lista_seguridad", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    securities = new Security()
                    {
                        SecurityApp = dr.GetInt32(1),
                        SecurityKey = dr.GetString(2),
                    };
                }
            }
            return securities;
        }
    }
}