namespace DortanApp
{
    public enum MarqueEnum
    {
        Peli,
        Euromast,
        Martinas,
        Menfire,
        Softshell,
        Haix,
        EuropaKimanche
    }

    public class Material
    {
        private int id;
        private Categorie nom_categorie;
        private Site site;
        private Type type;
        private string nom_materiel;
        private string lien_photo;
        private MarqueEnum marque;
        private string description;
        private int puissance_cv;
        private int? puissance_w;
        private int cout_utilisation;

        public Material(Categorie nom_categorie, Site site, Type type, string nom_materiel, string lien_photo, MarqueEnum marque, string description, int puissance_cv, int? puissance_w, int cout_utilisation)
        {
            this.Nom_categorie = nom_categorie;
            this.Site = site;
            this.Type = type;
            this.Nom_materiel = nom_materiel;
            this.Lien_photo = lien_photo;
            this.Marque = marque;
            this.Description = description;
            this.Puissance_cv = puissance_cv;
            this.Puissance_w = puissance_w;
            this.Cout_utilisation = cout_utilisation;
        }

        public Material(int id, Categorie nom_categorie, Site site, Type type, string nom_materiel, string lien_photo, MarqueEnum marque, string description, int puissance_cv, int? puissance_w, int cout_utilisation) : this(nom_categorie, site, type, nom_materiel, lien_photo, marque, description, puissance_cv, puissance_w, cout_utilisation)
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
                    throw new ArgumentOutOfRangeException(nameof(Id), "L'Id doit être supérieur à zéro.");
                }
                id = value;
            }
        }

        public Categorie Nom_categorie
        {
            get
            {
                return nom_categorie;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Nom_categorie), "La catégorie ne peut pas être nulle.");
                }
                nom_categorie = value;
            }
        }

        public Site Site
        {
            get
            {
                return site;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Site), "Le site ne peut pas être nul.");
                }
                site = value;
            }
        }

        public Type Type
        {
            get
            {
                return type;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Type), "Le type ne peut pas être nul.");
                }
                type = value;
            }
        }

        public string Nom_materiel
        {
            get
            {
                return nom_materiel;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom du matériel ne peut pas être nul ou vide.", nameof(Nom_materiel));
                }
                nom_materiel = value;
            }
        }

        public string Lien_photo
        {
            get
            {
                return lien_photo;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le lien de la photo ne peut pas être nul ou vide.", nameof(Lien_photo));
                }
                lien_photo = value;
            }
        }

        public MarqueEnum Marque
        {
            get
            {
                return marque;
            }

            set
            {
                marque = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int Puissance_cv
        {
            get
            {
                return puissance_cv;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Puissance_cv), "La puissance en CV ne peut pas être négative.");
                }
                puissance_cv = value;
            }
        }

        public int? Puissance_w
        {
            get
            {
                return puissance_w;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Puissance_w), "La puissance en watts ne peut pas être négative.");
                }
                puissance_w = value;
            }
        }

        public int Cout_utilisation
        {
            get
            {
                return cout_utilisation;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Cout_utilisation), "Le coût d'utilisation ne peut pas être négatif.");
                }
                cout_utilisation = value;
            }
        }
    }
}