using System.Data;
using System.Data.SqlClient;

namespace Example1;

class Program
{
    private const string dbConnectionString = "Server=localhost;Database=institute;Trusted_Connection=True;";
    static void Main(string[] args)
    {
        SqlConnection connection = new SqlConnection(dbConnectionString);

        string insertStatement = "INSERT INTO students (NAME, COUNTRY, STATE, CITY) VALUES (@NAME, @COUNTRY, @STATE, @CITY)";

        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = insertStatement;


        Console.WriteLine("Please provide institution's name");
        SqlParameter paramName = new SqlParameter();
        paramName.ParameterName = "@NAME";
        paramName.SqlDbType = SqlDbType.VarChar;
        paramName.Direction = ParameterDirection.Input;
        paramName.Value = Console.ReadLine();
        command.Parameters.Add(paramName);

        Console.WriteLine("Please provide institution's counrty");
        SqlParameter paramCountry = new SqlParameter();
        paramCountry.ParameterName = "@COUNTRY";
        paramCountry.SqlDbType = SqlDbType.VarChar;
        paramCountry.Direction = ParameterDirection.Input;
        paramCountry.Value = Console.ReadLine();
        command.Parameters.Add(paramCountry);

        Console.WriteLine("Please provide institution's state");
        SqlParameter paramState = new SqlParameter();
        paramState.ParameterName = "@STATE";
        paramState.SqlDbType = SqlDbType.VarChar;
        paramState.Direction = ParameterDirection.Input;
        paramState.Value = Console.ReadLine();
        command.Parameters.Add(paramState);

        Console.WriteLine("Please provide institution's cIty");
        SqlParameter paramCIty = new SqlParameter();
        paramCIty.ParameterName = "@CITY";
        paramCIty.SqlDbType = SqlDbType.VarChar;
        paramCIty.Direction = ParameterDirection.Input;
        paramCIty.Value = Console.ReadLine();
        command.Parameters.Add(paramCIty);

        connection.Open();
        int result = command.ExecuteNonQuery();
        Console.WriteLine(result);
        connection.Close();

    }
}
