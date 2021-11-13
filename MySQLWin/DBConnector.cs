using MySql.Data.MySqlClient;
using System.Data;

namespace MySQLWin
{
    class DBConnector
    {
        #region Propiedades
        private MySqlConnection conexion;
        private string errorMsg;
        private string successMsg;

        public string ErrorMsg { get => errorMsg; set => errorMsg = value; }
        public string SuccessMsg { get => successMsg; set => successMsg = value; }
        #endregion Propiedades  

        public bool Connect(string host, string db, string username, string password)
        {
            try
            {
                conexion = new MySqlConnection();
                conexion.ConnectionString = $"server={host}; uid={username}; pwd={password}; database={db}";
                conexion.Open();
                if(conexion.State == ConnectionState.Open)
                {
                    successMsg = "¡Conexión Exitosa!";
                    conexion.Close();
                    return true;
                }
                else
                {
                    errorMsg = "Error Conectando";
                    return false;
                }
            }
            catch (MySqlException e)
            {
                errorMsg = $"No se pudo establecer conexíon a la db {db}\n{e.Message}\n\n{e.StackTrace}\n";
                conexion.Dispose();
                return false;
            }
        }
    }
}
