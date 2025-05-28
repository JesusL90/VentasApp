using System;
using System.Data.SQLite;
using System.IO;

public class SQLHelper
{
    private string dbFile = "ventas.db";//Nombre del archivo de la DB
    private string connectionString;//Cadena de conexion a la DB

    public SQLHelper()
    {
        connectionString = $"Data Source={dbFile};version=3;";//Cadena de conexion a la DB
        crearBaseDeDatosSiNoExiste();//Esta funcion crea la base de datos si no existe
    }

    public void crearBaseDeDatosSiNoExiste()
    {
        if (!File.Exists(dbFile))//Verifica si el archivo de la DB existe
        {
            SQLiteConnection.CreateFile(dbFile);//Si no existe, lo crea
        }

        using (SQLiteConnection conn = new SQLiteConnection(connectionString))//Abre conexion a DB
        {
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS ventas (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Codigo TEXT NOT NULL UNIQUE,
                Descripcion TEXT,
                Stock INTEGER DEFAULT 0
                );";
            cmd.ExecuteNonQuery();
        }
    }

    //Ejemplo de metodo para insertar una venta 
    public void InsertarVenta(string codigo, string descripcion, int stock)
    {
        using (var connection = new SQLiteConnection("Data Source=venta.db;Version=3;"))
        {
            connection.Open();
            
            string query = "INSERT INTO ventas (Codigo, Descripcion, Stock) VALUES ('codigo',' descripcion', 'stock')";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@codigo", codigo);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@stock", stock);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
    //Aquí puedes agregar más metodos para actualizar, eliminar o consultar datos de la DB
}