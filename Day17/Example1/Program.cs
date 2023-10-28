
using System.Data.SqlClient;

const string dbConnectionString = "Server=localhost;Database=institute;Trusted_Connection=True;";

string sql = "SELECT * FROM institute.dbo.students";

SqlConnection connection = new SqlConnection(dbConnectionString);

SqlCommand cmd = new SqlCommand();
cmd.Connection = connection;

cmd.CommandText = sql;

connection.Open();
SqlDataReader reader = cmd.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine("=====================");

    Console.WriteLine($"Id: {reader.GetInt32(0)}");
    Console.WriteLine($"Name: {reader.GetString(1)}");
    Console.WriteLine($"Country: {reader.GetString(2)}");
    Console.WriteLine($"State: {reader.GetString(3)}");
    Console.WriteLine($"City: {reader.GetString(4)}");

    Console.WriteLine("=====================");
}

connection.Close();