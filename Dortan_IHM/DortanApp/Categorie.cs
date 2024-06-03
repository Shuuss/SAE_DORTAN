using System;

namespace DortanApp
{
    public class Categorie
    {
        private string nom;

        public Categorie(string nom)
        {
            this.Nom = nom;
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