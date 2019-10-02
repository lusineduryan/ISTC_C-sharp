using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ADO.NET_LinkedinProfiles
{
    public class SQLConnector
    {
        public static List<Profiles> GetProfilesInfo()
        {
            List<Profiles> profiles = new List<Profiles>();
            SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();
            connectionBuilder["Data Source"] = "(local)";
            connectionBuilder["integrated Security"] = true;
            connectionBuilder["Initial Catalog"] = "Monitoring";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionBuilder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine(connection.State);
                    string query = "select * from LinkedinProfile";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader readData = command.ExecuteReader())
                        {
                            while (readData.Read())
                            {
                                profiles.Add(
                                    new Profiles
                                    {
                                        Id = (int)readData["Id"],
                                        Username = (string)GetNonNullValue(readData["Username"]),
                                        FullName = (string)GetNonNullValue(readData["FullName"]),
                                        Specialty = (string)GetNonNullValue(readData["Specialty"]),
                                        Location = (string)GetNonNullValue(readData["Location"]),
                                        Education = (string)GetNonNullValue(readData["Education"]),
                                        Company = (string)GetNonNullValue(readData["Company"]),
                                        ConnectionCount = (int?)GetNonNullValue(readData["ConnectionCount"]),
                                        Website = (string)GetNonNullValue(readData["Website"]),
                                        Phone = (string)GetNonNullValue(readData["Phone"]),
                                        Email = (string)GetNonNullValue(readData["Email"]),
                                        Birthday = (DateTime?)GetNonNullValue(readData["Birthday"]),
                                        Connected = (string)GetNonNullValue(readData["Connected"]),
                                        ImageUrl = (string)GetNonNullValue(readData["ImageUrl"]),
                                        LastUpdate = (DateTime?)GetNonNullValue(readData["LastUpdate"])
                                    }
                                    );
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return profiles;
        }

        public static object GetNonNullValue(object value)
        {
            if (value != DBNull.Value)
            {
                return value;
            }
            else return null;
        }

        public static void WriteOnTable(List<Profiles> profiles)
        {
            SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();
            connectionBuilder["Data Source"] = "(local)";
            connectionBuilder["integrated Security"] = true;
            connectionBuilder["Initial Catalog"] = "MyDB";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionBuilder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine(connection.State);
                    string query = "create table LinkedinInfo(Id int, Username varchar(100), FullName varchar(100), Specialty varchar(100), Location varchar(100)," +
                                                             "Education varchar(100), Company varchar(100), ConnectionCount int, Website varchar(100), Phone varchar(100)," +
                                                             "Email varchar(100), Birthday date, Connected varchar(100), ImageUrl varchar(100), LastUpdate datetime)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    foreach (var item in profiles)
                    {
                        string insertQuery = "Insert into LinkedinInfo " +
                                              $"values({item.Id}, {item.Username}, {item.FullName}, {item.Specialty}, {item.Location}, {item.Education}," +
                                                     $"{item.Company}, {item.ConnectionCount}, {item.Website}, {item.Phone}, {item.Email}, {item.Birthday}," +
                                                     $"{item.Connected}, {item.ImageUrl}, {item.LastUpdate})";
                        using (SqlCommand command2 = new SqlCommand(insertQuery, connection))
                        {
                            command2.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Table is ready!");
        }
    }
}
