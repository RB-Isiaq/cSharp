using Example1.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Example1.Data
{
    public class InstitutionService : IInstitutionService
    {
        private readonly string _dbConnectionString;

        public InstitutionService(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }
        public bool AddInstitution(Institution institution)
        {
            SqlConnection connection = new SqlConnection(_dbConnectionString);

            string insertStatement = "studentInsert";

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = insertStatement;
            command.CommandType = CommandType.StoredProcedure;

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

            string insertStatement = "studentUpdate";

            SqlCommand command = new();
            command.Connection = connection;
            command.CommandText = insertStatement;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter paramID = new();
            paramID.ParameterName = "@ID";
            paramID.SqlDbType = SqlDbType.VarChar;
            paramID.Direction = ParameterDirection.Input;
            paramID.Value = institution.Id;
            command.Parameters.Add(paramID);

            SqlParameter paramName = new();
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
        public List<Institution> GetAll()
        {
            SqlConnection connection = new SqlConnection(_dbConnectionString);

            List<Institution> institutions = new List<Institution>();


            string sql = "studentGetAll";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;

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
        public Institution GetById(int institutionId)
        {
            SqlConnection connection = new SqlConnection(_dbConnectionString);

            Institution institution = new Institution();


            string sql = "studentGetById";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", institutionId);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    institution.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                    institution.Name = reader.GetString(reader.GetOrdinal("NAME"));
                    institution.Country = reader.GetString(reader.GetOrdinal("COUNTRY"));
                    institution.State = reader.GetString(reader.GetOrdinal("STATE"));
                    institution.City = reader.GetString(reader.GetOrdinal("CITY"));
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

            return institution;
        }
        public bool Delete(int institutionId)
        {
            SqlConnection connection = new SqlConnection(_dbConnectionString);

            Institution institution = new Institution();


            string sql = "studentDelete";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", institutionId);

            connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            bool result = rowsAffected > 0;
            connection.Close();

            return result;
        }
    }
}