using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPimpMyUnicornClient.DTO
{
    class ElementsDTO
    {
        private int _id;
        private int _partieId;
        private string _libelle;
        private string _image;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int PartieID
        {
            get { return _partieId; }
            set { _partieId = value; }
        }
        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
