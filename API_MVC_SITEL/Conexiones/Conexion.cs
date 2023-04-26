using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API_MVC_SITEL.Conexiones
{
    public class Conexion
    {
        SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=DeveloperEvaluationBK;Integrated Security=True");

        public SqlConnection conectar
        {
            get { return cn; }
        }
    }
}