using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WCFPimpMyUnicorn
{
    static class MySQLProvider
    {
        private static readonly string cs = ConfigurationManager.ConnectionStrings["cs_pimpmyunicorn"].ConnectionString;

        public static bool ExecuteQueries(List<string> queries)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cs))
                {
                    cn.Open();

                    foreach(string query in queries)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, cn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    cn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

    }
}
