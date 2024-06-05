using Npgsql;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;

namespace DortanApp
{
    public class ApplicationData
    {
        private ObservableCollection<Employe> lesEmployes;
        private ObservableCollection<Materiel> lesMateriels;
        private ObservableCollection<Activite> lesActivites;
        private ObservableCollection<Reservation> lesReservations;


        private NpgsqlConnection Connexion { get; set; }

        public ObservableCollection<Employe> LesEmployes
        {
            get
            {
                return lesEmployes;
            }

            set
            {
                lesEmployes = value;
            }
        }

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

        public ObservableCollection<Reservation> LesReservations
        {
            get
            {
                return this.lesReservations;
            }

            set
            {
                this.lesReservations = value;
            }
        }

        public ApplicationData()
        {
            LesEmployes = new ObservableCollection<Employe>();
            LesMateriels = new ObservableCollection<Materiel>();
            LesActivites = new ObservableCollection<Activite>();
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