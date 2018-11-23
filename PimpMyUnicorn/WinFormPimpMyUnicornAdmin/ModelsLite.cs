using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WinFormPimpMyUnicornAdmin
{
    public class T_elements
    {
        public int Id_element { get; set; }
        public string elementLibelle { get; set; }
        public string elementsImg { get; set; }
        public int partie_id { get; set; }
        public string partieLibelle { get; set; }
    }
    
    public class T_parties 
    {
        public int Id_partie { get; set; }
        public string partieLibelle { get; set; }
        public int ordre { get; set; }
    }
}
