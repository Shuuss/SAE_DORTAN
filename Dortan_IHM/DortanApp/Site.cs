using System;

namespace DortanApp
{
    public class Site
    {
        private int id;
        private string nom;
        private string adresseRue;
        private string nomResponsable;
        private string horaire;

        public Site(string nom, string adresseRue, string nomResponsable, string horaire)
        {
            this.Nom = nom;
            this.AdresseRue = adresseRue;
            this.NomResponsable = nomResponsable;
            this.Horaire = horaire;
        }

        public Site(int id, string nom, string adresseRue, string nomResponsable, string horaire) : this(nom, adresseRue, nomResponsable, horaire)
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

        public string AdresseRue
        {
            get
            {
                return adresseRue;
            }

            set
            {
                adresseRue = value;
            }
        }

        public string NomResponsable
        {
            get
            {
                return nomResponsable;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom du responsable ne peut pas être vide ou nul.", nameof(value));
                }
                nomResponsable = value;
            }
        }

        public string Horaire
        {
            get
            {
                return horaire;
            }

            set
            {
                horaire = value;
            }
        }
    }
}