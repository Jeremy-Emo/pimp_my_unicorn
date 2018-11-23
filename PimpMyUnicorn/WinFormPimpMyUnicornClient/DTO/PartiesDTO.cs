namespace WinFormPimpMyUnicornClient.DTO
{
    class PartiesDTO
    {
        private int _id;
        private string _libelle;
        private int _partieOrdre;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }
        public int partieOrdre
        {
            get { return _partieOrdre; }
            set { _partieOrdre = value; }
        }
    }
}
