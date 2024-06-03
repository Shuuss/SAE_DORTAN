using System;

namespace DortanApp
{
    public class Concerne
    {
        private Reservation reservation;
        private Material material;

        public Concerne(Reservation reservation, Material material)
        {
            this.Reservation = reservation;
            this.Material = material;
        }

        public Reservation Reservation
        {
            get
            {
                return reservation;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "La réservation ne peut pas être nulle.");
                }
                reservation = value;
            }
        }

        public Material Material
        {
            get
            {
                return material;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Le matériau ne peut pas être nul.");
                }
                material = value;
            }
        }
    }
}