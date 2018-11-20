using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFPimpMyUnicorn.DTO;

namespace WCFPimpMyUnicorn
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
        public List<ElementsDTO> GetElements()
        {
            return MySQLProvider.GetElements();
        }

        public List<PartiesDTO> GetParties()
        {
            return MySQLProvider.GetParties();
        }

        public bool UpdateDatabase(List<string> queries)
        {
            return MySQLProvider.ExecuteQueries(queries);
        }
    }
}
