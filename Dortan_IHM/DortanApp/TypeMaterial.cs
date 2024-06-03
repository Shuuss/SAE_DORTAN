using System;

namespace DortanApp
{
    public class TypeMaterial
    {
        private int id;
        private string nom;

        public TypeMaterial(string nom)
        {
            this.Nom = nom;
        }

        public TypeMaterial(int id, string nom) : this(nom)
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
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "L'identifiant doit être supérieur à zéro.");
                }
                id = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom ne peut pas être vide ou nul.", nameof(value));
                }
                nom = value;
            }
        }
    }
}