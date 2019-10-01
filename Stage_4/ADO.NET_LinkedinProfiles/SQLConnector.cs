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
            SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder
            {
                DataSource = @"(localDB)DESKTOP-0IKC9M0",
                InitialCatalog = "Monitoring",
                IntegratedSecurity = true
            };
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionBuilder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine(connection.State);
                    string query = "select * from LinkedinProfiles";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader readData = command.ExecuteReader())
                        {
                            while (readData.Read())
                            {
                                profiles.Add(
                                    new Profiles
                                    {
                                        Id = (int)readData["ID"],
                                        Username = (string)
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
    }
}
