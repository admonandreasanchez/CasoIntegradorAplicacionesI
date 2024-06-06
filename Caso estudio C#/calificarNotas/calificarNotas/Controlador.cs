using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificarNotas
{
    internal class Controlador
    {
        public double CalcularNotaFinal(double nota1, double nota2, double nota3)
        {

            return (nota1 * 0.35) + (nota2 * 0.35) + (nota3 * 0.30);

        }

        public void GuardarEnBD(string nombre, double nota1, double nota2, double nota3, double notaFinal)
        {
            ConectorBD db = new ConectorBD();
            SqlConnection connection = db.GetConnection();
            try
            {
                connection.Open();
                string query = "INSERT INTO tecnologiaDesarrolloSoftware (NombreEstudiante, Nota1, Nota2, Nota3, NotaFinal) VALUES (@Nombre, @Nota1, @Nota2, @Nota3, @NotaFinal)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Nota1", nota1);
                cmd.Parameters.AddWithValue("@Nota2", nota2);
                cmd.Parameters.AddWithValue("@Nota3", nota3);
                cmd.Parameters.AddWithValue("@NotaFinal", notaFinal);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}


