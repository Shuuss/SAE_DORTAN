using System;

namespace DortanApp
{
    public class TypeMateriel
    {
        private int id;
        private string nom;

        public TypeMateriel(string nom)
        {
            this.Nom = nom;
        }

        public TypeMateriel(int id, string nom) : this(nom)
        {
            this.Id = id;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }
    }
}