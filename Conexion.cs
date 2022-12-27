using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace REGISTRO_ESTUDIANTE
{
    class Conexion
    {

        

        
            public static SqlConnection Conectar()
            {


             SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=registro;Integrated Security=True");
            cn.Open();
            return cn;
            }
        }
    }




