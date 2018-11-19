using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WinFormPimpMyUnicornAdmin
{
    [Table("t_elements")]
    public class T_elements
    {
        [PrimaryKey, AutoIncrement]
        public int Id_element { get; set; }
        [MaxLength(255)]
        public string elementLibelle { get; set; }
        public string elementsImg { get; set; }
        public int partie_id { get; set; }
    }

    [Table("t_parties")]
    public class T_parties 
    {
        [PrimaryKey, AutoIncrement]
        public int Id_partie { get; set; }
        [MaxLength(255)]
        public string partieLibelle { get; set; }
    }
}
