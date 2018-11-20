using System.Runtime.Serialization;

namespace WCFPimpMyUnicorn.DTO
{
    [DataContract]
    public class ElementsDTO
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
