using Npgsql;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;

namespace DortanApp.config
{
    public class ApplicationData
    {
        private ObservableCollection<Employe> LesEmployes { get; set; }
        private ObservableCollection<Material> LesMateriels { get; set; }
        private ObservableCollection<Activity> LesActivites { get; set; }
        private ObservableCollection<Reservation> LesReservations { get; set; }


        private NpgsqlConnection Connexion { get; set; }

        public ApplicationData()
        {
            LesEmployes = new ObservableCollection<Employe>();
            LesMateriels = new ObservableCollection<Material>();
            LesActivites = new ObservableCollection<Activity>();
            LesReservations = new ObservableCollection<Reservation>();

            Read();
        }

        public int Read()
        {
            const string sql = "SELECT id, identifiant FROM User";
            try
            {
                using (var dataAdapter = new NpgsqlDataAdapter(sql, Connexion))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    foreach (DataRow res in dataTable.Rows)
                    {
                        Employe nouveau = new Employe(int.Parse(res["id"].ToString()), res["identifiant"].ToString());
                        LesEmployes.Add(nouveau);
                    }
                    return dataTable.Rows.Count;
                }
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

        public int Create(Employe u)
        {
            string sql = $"INSERT INTO User (identifiant, mdp) VALUES ('{u.Identifiant}', '{u.Mdp}')";
            return MethodeGenerique(sql);
        }

        public int Update(Employe u)
        {
            string sql = $"UPDATE User SET identifiant = '{u.Identifiant}', mdp = '{u.Mdp}' WHERE id = {u.Id}";
            return MethodeGenerique(sql);
        }

        public int Delete(Employe u)
        {
            string sql = $"DELETE FROM User WHERE id = {u.Id}";
            return MethodeGenerique(sql);
        }
    }
}