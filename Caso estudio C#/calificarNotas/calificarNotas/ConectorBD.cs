using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificarNotas
{
    internal class ConectorBD
    {
        private string BaseDatos = "Server=SantiNh05\\NOOBMASTER; DATABASE=PolitecnicoBaseDatos;Integrated Security=True";

        //Metodo para hacer la conexion

        public SqlConnection GetConnection()
        {
            return new SqlConnection(BaseDatos);
        }
    }
    }

