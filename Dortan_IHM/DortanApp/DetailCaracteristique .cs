using System;

namespace DortanApp
{
    public class DetailCaracteristique
    {
        private Material material;
        private Caracteristique caracteristique;
        private string valeurCaracteristique;

        public DetailCaracteristique(Material material, Caracteristique caracteristique, string valeurCaracteristique)
        {
            this.Material = material;
            this.Caracteristique = caracteristique;
            this.ValeurCaracteristique = valeurCaracteristique;
        }

        public Material Material
        {
            get
            {
                return material;
            }

            set
            {
                material = value;
            }
        }

        public Caracteristique Caracteristique
        {
            get
            {
                return caracteristique;
            }

            set
            {
                caracteristique = value;
            }
        }

        public string ValeurCaracteristique
        {
            get
            {
                return this.valeurCaracteristique;
            }

            set
            {
                this.valeurCaracteristique = value;
            }
        }
    }
}