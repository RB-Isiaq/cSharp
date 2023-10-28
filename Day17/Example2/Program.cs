
using System.Data.SqlClient;
using Example1.Models;

List<Institution> institutions = GetInstitutions();

ShowInstitution(institutions);


List<Institution> GetInstitutions()
{
    List<Institution> institutions = new List<Institution>();
    const string dbConnectionString = "Server=localhost;Database=institute;Trusted_Connection=True;";

    string sql = "SELECT * FROM institute.dbo.students";

    SqlConnection connection = new SqlConnection(dbConnectionString);

    SqlCommand cmd = new SqlCommand();
    cmd.Connection = connection;

    cmd.CommandText = sql;

    try
    {
        connection.Open();
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Institution institution = new Institution();
            institution.Id = reader.GetInt32(0);
            institution.Name = reader.GetString(1);
            institution.Country = reader.GetString(2);
            institution.State = reader.GetString(3);
            institution.City = reader.GetString(3);

            institutions.Add(institution);
        }
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Database operation failed: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("SOmething went wrong: " + ex.Message);
    }
    finally
    {
        connection.Close();
    }

    return institutions;
}

void ShowInstitution(List<Institution> institutions)
{

    foreach (Institution institution in institutions)
    {
        Console.WriteLine("=====================");

        Console.WriteLine($"Id: {institution.Id}");
        Console.WriteLine($"Name: {institution.Name}");
        Console.WriteLine($"City: {institution.City}");
        Console.WriteLine($"State: {institution.State}");
        Console.WriteLine($"Country: {institution.Country}");

        Console.WriteLine("=====================");
    }
}