using System;

namespace DortanApp
{
    public class Activity
    {
        private int id;
        private string nom;
        private string description;
        private DateTime dateDebut;
        private TimeSpan duree;
        private double puissance;

        public Activity()
        {
        }

        public Activity(string nom, string description, DateTime dateDebut, TimeSpan duree, double puissance)
        {
            this.Nom = nom;
            this.Description = description;
            this.DateDebut = dateDebut;
            this.Duree = duree;
            this.Puissance = puissance;
        }

        public Activity(int id, string nom, string description, DateTime dateDebut, TimeSpan duree, double puissance) : this(nom, description, dateDebut, duree, puissance)
        {
            this.Id = id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom ne peut pas être vide ou null.");
                }
                nom = value;
            }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime DateDebut
        {
            get { return dateDebut; }
            set 
            { 
                if (dateDebut >= DateTime.Today)
                    throw new ArgumentOutOfRangeException("La date début doit être avant la date d'aujourd'hui.");

                dateDebut = value; 
            }
        }

        public TimeSpan Duree
        {
            get { return duree; }
            set
            {
                if (value.TotalMinutes <= 0)
                    throw new ArgumentException("La durée doit être supérieure à zéro.");

                duree = value;
            }
        }

        public double Puissance
        {
            get { return puissance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La puissance ne peut pas être négative.");

                puissance = value;
            }
        }
    }
}