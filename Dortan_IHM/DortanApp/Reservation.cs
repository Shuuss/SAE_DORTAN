using System;

namespace DortanApp
{
    public class Reservation
    {
        private int id;
        private Activite activite;
        private DateTime dateReservation;
        private TimeSpan dureeReservation;

        public Reservation(Activite activite, DateTime dateReservation, TimeSpan dureeReservation)
        {
            this.Activite = activite;
            this.DateReservation = dateReservation;
            this.DureeReservation = dureeReservation;
        }

        public Reservation(int id, Activite activite, DateTime dateReservation, TimeSpan dureeReservation)
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
                dateReservation = value;
            }
        }

        public TimeSpan DureeReservation
        {
            get
            {
                return this.dureeReservation;
            }

            set
            {
                this.dureeReservation = value;
            }
        }
    }
}