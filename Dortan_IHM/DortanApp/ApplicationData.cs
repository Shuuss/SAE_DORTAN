using DortanApp.config;
using Npgsql;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;

namespace DortanApp
{
    public class ApplicationData
    {
        private ObservableCollection<Materiel> lesMateriels;
        private ObservableCollection<Activite> lesActivites;

        private NpgsqlConnection connexion;

        public ObservableCollection<Materiel> LesMateriels
        {
            get
            {
                return lesMateriels;
            }

            set
            {
                lesMateriels = value;
            }
        }

        public ObservableCollection<Activite> LesActivites
        {
            get
            {
                return lesActivites;
            }

            set
            {
                lesActivites = value;
            }
        }

        public NpgsqlConnection Connexion
        {
            get
            {
                return connexion;
            }

            set
            {
                connexion = value;

            }
        }

        public ApplicationData()
        {
            this.LesMateriels = new ObservableCollection<Materiel>();
            this.LesActivites = new ObservableCollection<Activite>();

            ReaMateriels();
            ReadActivite();
        }

        public int ReaMateriels()
        {
            string sql = "SELECT num_materiel, nom_categorie, num_site, num_type, nom_materiel, lien_photo, marque, description, puissance_cv, puissance_w, cout_utilisation FROM materiel";
            try
            {
                DataTable dataTable = DataAccess.Instance.GetData(sql);
                foreach (DataRow res in dataTable.Rows)
                {
                    int numMateriel = Convert.ToInt32(res["num_materiel"]);
                    string nomCategorie = res["nom_categorie"].ToString();
                    int numSite = Convert.ToInt32(res["num_site"]);
                    int numType = Convert.ToInt32(res["num_type"]);
                    string nomMateriel = res["nom_materiel"].ToString();
                    string lienPhoto = res["lien_photo"].ToString();
                    MarqueEnum marque = (MarqueEnum)Enum.Parse(typeof(MarqueEnum), res["marque"].ToString());
                    string description = res["description"].ToString();
                    int puissanceCv = Convert.ToInt32(res["puissance_cv"]);
                    int puissanceW = Convert.ToInt32(res["puissance_w"]);
                    int coutUtilisation = Convert.ToInt32(res["cout_utilisation"]);

                    Materiel nouveau = new Materiel(numMateriel, new Categorie(nomCategorie), new Site(numSite), new TypeMateriel(numType), nomMateriel, lienPhoto, marque, description, puissanceCv, puissanceW, coutUtilisation);

                    LesMateriels.Add(nouveau);
                }

                return dataTable.Rows.Count;
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("Problème de requête : " + e.Message);
                return 0;
            }
        }

        public int ReadActivite()
        {
            String sql = "SELECT num_activite, nom_activite FROM activite";
            try
            {
                DataTable dataTable = DataAccess.Instance.GetData(sql);
                foreach (DataRow res in dataTable.Rows)

                {
                    Activite nouveau = new Activite(int.Parse(res["num_activite"].ToString()),
                    res["nom_activite"].ToString());

                    LesActivites.Add(nouveau);
                }
                return dataTable.Rows.Count;

            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("Problème de requête : " + e);
                return 0;
            }
        }

        private int MethodeGenerique(string sql)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Connexion);
                int nb = cmd.ExecuteNonQuery();
                return nb; // nb permet de connaître le nb de lignes affectées par un insert, update, delete

            }
            catch (Exception sqlE)
            {
                MessageBox.Show("Problème de requête : " + sqlE.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }
        }

        public int CreateMateriel(Materiel m)
        {
            string sql = $"INSERT INTO Materiel (num_materiel, nom_categorie, num_site, num_type, nom_materiel, lien_photo, marque, description, puissance_cv, puissance_w, cout_utilisation) VALUES ({m.Id}, '{m.NomCategorie}', {m.Site}, {m.Type}, '{m.Nom}', '{m.LienPhoto}', '{m.Marque}', '{m.Description}', {m.PuissanceCV}, {m.PuissanceW}, {m.CoutUtilisation})";
            return MethodeGenerique(sql);
        }

        public int UpdateMateriel(Materiel m)
        {
            string sql = $"UPDATE Materiel SET nom_categorie = '{m.NomCategorie}', num_site = {m.Site}, num_type = {m.Type}, nom_materiel = '{m.Nom}', lien_photo = '{m.LienPhoto}', marque = '{m.Marque}', description = '{m.Description}', puissance_cv = {m.PuissanceCV}, puissance_w = {m.PuissanceW}, cout_utilisation = {m.CoutUtilisation} WHERE num_materiel = {m.Id}";
            return MethodeGenerique(sql);
        }

        public int DeleteMateriel(Materiel m)
        {
            string sql = $"DELETE FROM Materiel WHERE num_materiel = {m.Id}";
            return MethodeGenerique(sql);
        }


        public int CreateActivite(Activite a)
        {
            string sql = $"INSERT INTO Activite (num_activite, nom_activite) VALUES ({a.Id})";
            return MethodeGenerique(sql);
        }

        public int UpdateActivite(Activite a)
        {
            string sql = $"UPDATE Activite SET nom_activite = '{a.Nom}' WHERE num_activite = {a.Id}";
            return MethodeGenerique(sql);
        }

        public int DeleteActivite(Activite a)
        {
            string sql = $"DELETE FROM Activite WHERE num_activite = {a.Id}";
            return MethodeGenerique(sql);
        }
    }
}