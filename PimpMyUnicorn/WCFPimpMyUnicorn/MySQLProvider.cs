using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using WCFPimpMyUnicorn.DTO;

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

        public static List<PartiesDTO> GetParties()
        {
            DataTable _dt = new DataTable();
            List<PartiesDTO> parties = new List<PartiesDTO>();
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cs))
                {
                    cn.Open();
                    string query = "SELECT Id_partie, partieLibelle, partieOrdre FROM t_parties";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, cn))
                    {
                        da.Fill(_dt);
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (DataRow row in _dt.Rows)
            {
                PartiesDTO partie = new PartiesDTO();
                partie.ID = Convert.ToInt32(row["Id_partie"]);
                partie.Libelle = row["partieLibelle"].ToString();
                partie.Ordre = Convert.ToInt16(row["partieOrdre"]);
                parties.Add(partie);
            }
            return parties;
        }

        public static List<ElementsDTO> GetElements()
        {
            DataTable _dt = new DataTable();
            List<ElementsDTO> elements = new List<ElementsDTO>();
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cs))
                {
                    cn.Open();
                    string query = "SELECT Id_element, partie_id, elementLibelle, elementsImg FROM t_elements";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, cn))
                    {
                        da.SelectCommand.CommandTimeout = 600;
                        da.Fill(_dt);
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (DataRow row in _dt.Rows)
            {
                ElementsDTO element = new ElementsDTO();
                element.ID = Convert.ToInt32(row["Id_element"]);
                element.PartieID = Convert.ToInt32(row["partie_id"]);
                element.Libelle = row["elementLibelle"].ToString();
                element.Image = row["elementsImg"].ToString();
                elements.Add(element);
            }
            return elements;
        }
    }
}
