using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortanApp
{
    public class User
    {
        private int id;
        private string identifiant;
        private string mdp;

        public User(string identifiant, string mdp)
        {
            this.Identifiant = identifiant;
            this.Mdp = mdp;
        }

        public User(int id, string identifiant, string mdp) : this(identifiant, mdp)
        {
            this.Id = id;
        }

        public User(int id, string identifiant)
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
                return this.mdp;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le mot de passe ne peut pas être vide ou nul.", nameof(value));
                }
                this.mdp = value;
            }
        }
    }
}