using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace REGISTRO_ESTUDIANTE
{
    class CONEXION2
    {
        public static SqlConnection CONECTAR()
        {


            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=registro;Integrated Security=True");
            cn.Open();
            return cn;
        }
    }
}
