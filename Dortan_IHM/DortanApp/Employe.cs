using System;

namespace DortanApp
{
    public class Employe
    {
        private int id;
        private Site site;
        private string identifiant;
        private string mdp;

        public Employe(Site site, string identifiant, string mdp)
        {
            this.Site = site;
            this.Identifiant = identifiant;
            this.Mdp = mdp;
        }

        public Employe(string identifiant, string mdp)
        {
            this.Identifiant = identifiant;
            this.Mdp = mdp;
        }

        public Employe(int id, string identifiant, string mdp) : this(identifiant, mdp)
        {
            this.Id = id;
        }

        public Employe(int id, string identifiant)
        {
            this.Id = id;
            this.Identifiant = identifiant;
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

        public string Identifiant
        {
            get
            {
                return identifiant;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("L'identifiant ne peut pas être vide ou nul.", nameof(value));
                }
                identifiant = value;
            }
        }

        public string Mdp
        {
            get
            {
                return mdp;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le mot de passe ne peut pas être vide ou nul.", nameof(value));
                }
                mdp = value;
            }
        }

        public Site Site
        {
            get
            {
                return site;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Le site ne peut pas être nul.");
                }
                site = value;
            }
        }
    }
}