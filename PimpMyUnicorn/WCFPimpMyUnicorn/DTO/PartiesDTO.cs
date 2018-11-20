﻿using System.Runtime.Serialization;

namespace WCFPimpMyUnicorn.DTO
{
    [DataContract]
    public class PartiesDTO
    {
        private int _id;
        private string _libelle;

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
    }
}
