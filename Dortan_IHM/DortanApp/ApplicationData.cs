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

        private NpgsqlConnection Connexion { get; set; }

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

        public ApplicationData()
        {
            LesMateriels = new ObservableCollection<Materiel>();
            LesActivites = new ObservableCollection<Activite>();

            ReaMaterield();
            ReadActivite();
        }

        public int ReaMaterield()
        {
            String sql = "SELECT num_materiel, nom_categorie, num_site, num_type, nom_materiel, lien_photo, marque, description, puissance_cv, puissance_w, cout_utilisation FROM materiel";
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, Connexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                foreach (DataRow res in dataTable.Rows)
                {
                    Materiel nouveau = new Materiel(
                        int.Parse(res["num_materiel"].ToString()),
                        new Categorie(res["nom_categorie"].ToString()),
                        new Site(int.Parse(res["num_site"].ToString())),
                        new TypeMateriel(int.Parse(res["num_type"].ToString())),
                        res["nom_materiel"].ToString(),
                        res["lien_photo"].ToString(),
                        (MarqueEnum)char.Parse(res["marque"].ToString()),
                        res["description"].ToString(),
                        int.Parse(res["puissance_cv"].ToString()),
                        int.Parse(res["puissance_w"].ToString()),
                        int.Parse(res["cout_utilisation"].ToString()));

                    LesMateriels.Add(nouveau);
                }
                return dataTable.Rows.Count;
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("Problème de requête : " + e);
                return 0;
            }
        }

        public int ReadActivite()
        {
            String sql = "SELECT num_activite, nom_activite FROM activite";
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, Connexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
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
                using (var cmd = new NpgsqlCommand(sql, Connexion))
                {
                    int nb = cmd.ExecuteNonQuery();
                    return nb; // nb permet de connaître le nb de lignes affectées par un insert, update, delete
                }
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