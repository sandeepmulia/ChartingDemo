using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApplication3.Model;

namespace WpfApplication3.Database
{
    public sealed class DBReader
    {
        private static readonly Lazy<DBReader> _instance = new Lazy<DBReader>(() => new DBReader(), true);

        private DBReader()
        {

        }

        public static DBReader Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<Commodity> ReadFromDatabase()
        {
            var entryList = new List<Commodity>();
            try
            {
                using (SqlCeConnection connection = new SqlCeConnection(String.Concat("Data Source=", Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Database.sdf"))))
                {
                    SqlCeCommand command = connection.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM AgriCommodity";

                    command.Connection.Open();
                    using (SqlCeDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entryList.Add(new Commodity() { 
                                              CommodityName = GetValue<string>(reader["Commodity"]),
                                              HarvestedAcreage = GetValue<float>(reader["HarvestedGrainAcreage"]),
                                              PlantedAcreage = GetValue<float>(reader["PlantedAcreage"]),
                                              Production = GetValue<float>(reader["Production"]),
                                              LoanRate = GetValue<float>(reader["LoanRate"]),
                                              WeightedAvgPrice = GetValue<float>(reader["WeightedAvgPrice"]),
                                              Year = GetValue<DateTime>(reader["Year"]),
                                              YieldPerAcre = GetValue<float>(reader["YieldPerAcre"])
                                          });
                        }
                    }
                }
            }
            catch (SqlCeException exception)
            {
                Console.WriteLine("Sql Exception Caught {0}", exception.StackTrace);
            }
            return entryList;
        }

        public T GetValue<T>(object obj)
        {
            if (typeof(DBNull) != obj.GetType())
            {
                return (T)Convert.ChangeType(obj,typeof(T));
            }

            return default(T);
        }
    }
}
