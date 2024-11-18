using Microsoft.Data.SqlClient;
using System.Data;
namespace Ejercicio01.Models
{
    public class databaseDAL
    {
        /// <summary>
        /// Devuelve la cadena necesaria para establecer la conexion con la BD
        /// </summary>
        /// <returns>String</returns>
        static public string CadenaConexion()
        {
            SqlConnection miConexion = new SqlConnection();
            string cadena = "";
            
                cadena = "server=mreqmer.database.windows.net;" +
                                                "database=mreqmerBD;" +
                                                "uid=Usuario;" +
                                                "pwd=LaCampana123;" +
                                                "trustServerCertificate = true;";

            return cadena;
        }   

       

        
        

    }
}
