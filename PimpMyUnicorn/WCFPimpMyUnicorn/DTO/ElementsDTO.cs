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

        [DataMember]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember]
        public int PartieID
        {
            get { return _partieId; }
            set { _partieId = value; }
        }

        [DataMember]
        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        [DataMember]
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
