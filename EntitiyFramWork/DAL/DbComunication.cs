using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Specialized;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace EntitiyFramWork.DAL
{
    class DbComunication
    {
        static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString);


        public static DataTable GetInventoryTable(string query)
        {
            DataTable inventory = new DataTable();
            try
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter tableAdapter = new SqlDataAdapter(cmd);
                    tableAdapter.Fill(inventory);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                connection.Close();
            }
            return inventory;
        }

        public static void InsertNewEmployee(string lastName, string firstName, string alias, string email)
        {
            string sqlQuery = string.Format(" insert into Employees" +
                                            " (LastName, FirstName, Alias, Email) " +
                                            " VALUES " +
                                            "(@LastName, @FirstName, @Alias, @Email)");

            using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
            {
                SqlParameter param = new SqlParameter();

                param.ParameterName = "@LastName";
                param.Value = lastName;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@FirstName";
                param.Value = firstName;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Alias";
                param.Value = alias;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Email";
                param.Value = email;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Error Inserting new car: {0}", se.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void InsertNewSkill(int employeeId, string skillName, string briefDsec)
        {
            string sqlQuery = string.Format(" insert into Skills" +
                                            " (EmployeeId, SkillName, BriefDescription) " +
                                            " VALUES " +
                                            "(@EmployeeId, @SkillName, @BriefDescription)");

            using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
            {
                SqlParameter param = new SqlParameter();

                param.ParameterName = "@EmployeeId";
                param.Value = employeeId;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@SkillName";
                param.Value = skillName;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@BriefDescription";
                param.Value = briefDsec;
                param.SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.Add(param);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Error Inserting new car: {0}", se.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void InsertNewReferences(int employeeId, string lastName, string firstName, string position, string alias, string email)
        {
            string sqlQuery = string.Format(" insert into EmpReferences" +
                                            " (EmployeeId, LastName, FirstName, Position, Alias, Email) " +
                                            " VALUES " +
                                            "(@EmployeeId, @LastName, @FirstName, @Position, @Alias, @Email)");

            using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
            {
                SqlParameter param = new SqlParameter();

                param.ParameterName = "@EmployeeId";
                param.Value = employeeId;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@LastName";
                param.Value = lastName;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@FirstName";
                param.Value = firstName;
                param.Size = 50;
                param.SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Position";
                param.Value = position;
                param.Size = 50;
                param.SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Alias";
                param.Value = alias;
                param.Size = 50;
                param.SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Email";
                param.Value = email;
                param.Size = 50;
                param.SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.Add(param);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Error Inserting new car: {0}", se.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void InsertURLToSkill(int skillId, string url)
        {
            string sqlQuery = string.Format(" Update SkillsInfoes " +
                                            " (URL) " +
                                            " VALUES " +
                                            "(@URL) where SkillId = " + skillId );

            using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
            {
                SqlParameter param = new SqlParameter();

                param.ParameterName = "@URL";
                param.Value = url;
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 250;
                cmd.Parameters.Add(param);
            }
        }
    }
}
