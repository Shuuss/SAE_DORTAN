using System;

namespace DortanApp
{
    public class Reservation
    {
        private int id;
        private Activity activity;
        private DateTime date_reservation;
        private TimeSpan duree_reservation;

        public Reservation(Activity activity, DateTime date_reservation, TimeSpan duree_reservation)
        {
            this.Activity = activity;
            this.Date_reservation = date_reservation;
            this.Duree_reservation = duree_reservation;
        }

        public Reservation(int id, Activity activity, DateTime date_reservation, TimeSpan duree_reservation)
            : this(activity, date_reservation, duree_reservation)
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

        public DateTime Date_reservation
        {
            get
            {
                return date_reservation;
            }

            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La date de réservation ne peut pas être dans le passé.");
                }
                date_reservation = value;
            }
        }

        public TimeSpan Duree_reservation
        {
            get
            {
                return duree_reservation;
            }

            set
            {
                if (value <= TimeSpan.Zero)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La durée de réservation doit être supérieure à zéro.");
                }
                duree_reservation = value;
            }
        }
    }
}