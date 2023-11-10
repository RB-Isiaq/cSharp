using System.Data;
using System.Data.SqlClient;
using Example2.Entities;

namespace Example2.Data
{
    public class InstitutionData
    {
        private readonly string _dbConnectionString;

        public InstitutionData(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }
        public bool AddInstitution(Institution institution)
        {
            SqlConnection connection = new SqlConnection(_dbConnectionString);

            string insertStatement = "INSERT INTO students (NAME, COUNTRY, STATE, CITY) VALUES (@NAME, @COUNTRY, @STATE, @CITY)";

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = insertStatement;

            SqlParameter paramName = new SqlParameter();
            paramName.ParameterName = "@NAME";
            paramName.SqlDbType = SqlDbType.VarChar;
            paramName.Direction = ParameterDirection.Input;
            paramName.Value = institution.Name;
            command.Parameters.Add(paramName);

            SqlParameter paramCountry = new SqlParameter();
            paramCountry.ParameterName = "@COUNTRY";
            paramCountry.SqlDbType = SqlDbType.VarChar;
            paramCountry.Direction = ParameterDirection.Input;
            paramCountry.Value = institution.Country;
            command.Parameters.Add(paramCountry);

            SqlParameter paramState = new SqlParameter();
            paramState.ParameterName = "@STATE";
            paramState.SqlDbType = SqlDbType.VarChar;
            paramState.Direction = ParameterDirection.Input;
            paramState.Value = institution.State;
            command.Parameters.Add(paramState);

            SqlParameter paramCIty = new SqlParameter();
            paramCIty.ParameterName = "@CITY";
            paramCIty.SqlDbType = SqlDbType.VarChar;
            paramCIty.Direction = ParameterDirection.Input;
            paramCIty.Value = institution.City;
            command.Parameters.Add(paramCIty);

            connection.Open();
            int result = command.ExecuteNonQuery();
            Console.WriteLine(result);
            connection.Close();

            return true;
        }
        public bool UpdateInstitution(Institution institution)
        {
            SqlConnection connection = new SqlConnection(_dbConnectionString);

            string insertStatement = "UPDATE students SET NAME = @NAME,  COUNTRY = @COUNTRY,  STATE = @STATE,  CITY = @CITY WHERE ID = @ID";

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = insertStatement;

            SqlParameter paramID = new SqlParameter();
            paramID.ParameterName = "@ID";
            paramID.SqlDbType = SqlDbType.VarChar;
            paramID.Direction = ParameterDirection.Input;
            paramID.Value = institution.Id;
            command.Parameters.Add(paramID);

            SqlParameter paramName = new SqlParameter();
            paramName.ParameterName = "@NAME";
            paramName.SqlDbType = SqlDbType.VarChar;
            paramName.Direction = ParameterDirection.Input;
            paramName.Value = institution.Name;
            command.Parameters.Add(paramName);

            SqlParameter paramCountry = new SqlParameter();
            paramCountry.ParameterName = "@COUNTRY";
            paramCountry.SqlDbType = SqlDbType.VarChar;
            paramCountry.Direction = ParameterDirection.Input;
            paramCountry.Value = institution.Country;
            command.Parameters.Add(paramCountry);

            SqlParameter paramState = new SqlParameter();
            paramState.ParameterName = "@STATE";
            paramState.SqlDbType = SqlDbType.VarChar;
            paramState.Direction = ParameterDirection.Input;
            paramState.Value = institution.State;
            command.Parameters.Add(paramState);

            SqlParameter paramCIty = new SqlParameter();
            paramCIty.ParameterName = "@CITY";
            paramCIty.SqlDbType = SqlDbType.VarChar;
            paramCIty.Direction = ParameterDirection.Input;
            paramCIty.Value = institution.City;
            command.Parameters.Add(paramCIty);

            connection.Open();
            int result = command.ExecuteNonQuery();
            Console.WriteLine(result);
            connection.Close();

            return true;
        }

        public List<Institution> GetInstitutions()
        {
            SqlConnection connection = new SqlConnection(_dbConnectionString);

            List<Institution> institutions = new List<Institution>();


            string sql = "SELECT * FROM students";
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
                    institution.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                    institution.Name = reader.GetString(reader.GetOrdinal("NAME"));
                    institution.Country = reader.GetString(reader.GetOrdinal("COUNTRY"));
                    institution.State = reader.GetString(reader.GetOrdinal("STATE"));
                    institution.City = reader.GetString(reader.GetOrdinal("CITY"));

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
    }
}