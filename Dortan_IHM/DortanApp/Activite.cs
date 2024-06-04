namespace DortanApp
{
    public class Activite
    {
        private int id;
        private string nom;

        public Activite(string nom)
        {
            this.Nom = nom;
        }

        public Activite(int id, string nom) : this(nom)
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

        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }
    }
}