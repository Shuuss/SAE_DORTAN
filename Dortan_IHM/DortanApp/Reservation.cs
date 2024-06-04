using System;

namespace DortanApp
{
    public class Reservation
    {
        private int id;
        private Activity activity;
        private DateTime dateReservation;
        private TimeSpan dureeReservation;

        public Reservation(Activity activity, DateTime dateReservation, TimeSpan dureeReservation)
        {
            this.Activity = activity;
            this.DateReservation = dateReservation;
            this.DureeReservation = dureeReservation;
        }

        public Reservation(int id, Activity activity, DateTime dateReservation, TimeSpan dureeReservation)
            : this(activity, dateReservation, dureeReservation)
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

        public Activity Activity
        {
            get
            {
                return activity;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "L'activité ne peut pas être nulle.");
                }
                activity = value;
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
                if (value < DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La date de réservation ne peut pas être dans le passé.");
                }
                dateReservation = value;
            }
        }

        public TimeSpan DureeReservation
        {
            get
            {
                return dureeReservation;
            }

            set
            {
                if (value <= TimeSpan.Zero)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La durée de réservation doit être supérieure à zéro.");
                }
                dureeReservation = value;
            }
        }
    }
}