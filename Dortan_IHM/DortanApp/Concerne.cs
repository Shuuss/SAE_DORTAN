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
                reservation = value;
            }
        }

        public Material Material
        {
            get
            {
                return this.material;
            }

            set
            {
                this.material = value;
            }
        }
    }
}