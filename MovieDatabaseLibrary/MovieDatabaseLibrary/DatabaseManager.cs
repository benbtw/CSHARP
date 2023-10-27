using MySql.Data.MySqlClient;
using System.Reflection.Metadata.Ecma335;

namespace MovieDatabaseLibrary
{
    class DatabaseManager
    {
        //change datbase name
        // make sure to install mysql from tools -> packet manager
        private string myConnectionString = "server=127.0.0.1;uid=root;pwd=password;database=movie_library";
        private MySqlConnection conn = new();
        private MySqlCommand cmd;

        public DatabaseManager()
        {
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                //Console.WriteLine("Success"); // can be removed in final
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //"insert into testtable values ('varchar1', 'varchar2', 23);"  <-- example
        public void ExecuteStatement(string query)
        {
            try
            {
                cmd = new MySqlCommand(query, conn);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Success"); // can be removed in final

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadFromTable(string query)
        {
            try
            {
                MySqlDataReader dr;
                cmd = new MySqlCommand(query, conn);
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                int i = 1;
                while (dr.Read())
                {
                    //change depending on how many cols there are
                    Console.WriteLine("| " + i + " | " + dr[0] + " | " + dr[1] + " | " + dr[2] + " | " + dr[3] + " | ");
                    Console.WriteLine();
                    i++;
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Input error");
            }
        }

        ~DatabaseManager()
        {
            conn.Close();
        }
    }
}
