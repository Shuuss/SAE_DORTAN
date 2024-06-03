﻿namespace DortanApp
{
    public class Activity
    {
        private int id;
        private string nom;

        public Activity(string nom)
        {
            this.Nom = nom;
        }

        public Activity(int id, string nom) : this(nom)
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
                    throw new ArgumentException("Le nom ne peut pas être vide ou null.", nameof(value));
                }
                nom = value;
            }
        }
    }
}