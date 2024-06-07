using System;

namespace DortanApp
{
    public class Reservation
    {
        private int id;
        private Activite activite;
        private DateTime dateReservation;
        private int dureeReservation;

        public Reservation(Activite activite, DateTime dateReservation, int dureeReservation)
        {
            this.Activite = activite;
            this.DateReservation = dateReservation;
            this.DureeReservation = dureeReservation;
        }

        public Reservation(int id, Activite activite, DateTime dateReservation, int dureeReservation)
            : this(activite, dateReservation, dureeReservation)
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

        public Activite Activite
        {
            get
            {
                return activite;
            }

            set
            {
                activite = value;
            }
        }

        public DateTime DateReservation
        {
            get
            {
                return dateReservation;
            }

            set
            {
                if (value.Date < DateTime.Now)
                    throw new ArgumentOutOfRangeException("La date de réservation ne peut être déjà passée");

                dateReservation = value;
            }
        }

        public int DureeReservation
        {
            get
            {
                return this.dureeReservation;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("la durée ne doit pas être nulle ou négative");
                }
                dureeReservation = value;
            }
        }
    }
}