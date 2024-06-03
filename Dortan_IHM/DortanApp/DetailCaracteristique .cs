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
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Le matériau ne peut pas être nul.");
                }
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
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "La caractéristique ne peut pas être nulle.");
                }
                caracteristique = value;
            }
        }

        public string ValeurCaracteristique
        {
            get
            {
                return valeurCaracteristique;
            }

            set
            {
                valeurCaracteristique = value;
            }
        }
    }
}