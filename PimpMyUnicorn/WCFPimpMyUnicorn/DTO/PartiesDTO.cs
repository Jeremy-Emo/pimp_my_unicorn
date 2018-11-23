using System.Runtime.Serialization;

namespace WCFPimpMyUnicorn.DTO
{
    [DataContract]
    public class PartiesDTO
    {
        private int _id;
        private string _libelle;
        private int _ordre;

        [DataMember]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember]
        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        [DataMember]
        public int Ordre
        {
            get { return _ordre; }
            set { _ordre = value; }
        }
    }
}
