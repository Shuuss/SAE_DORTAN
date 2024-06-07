using DortanApp.config;
using System.Windows;

namespace Dortan
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {
        private string identifiant;
        private string mdp;

        public Connexion()
        {
            InitializeComponent();
        }

        public string Identifiant
        {
            get
            {
                return identifiant;
            }

            set
            {
                identifiant = value;
            }
        }

        public string Mdp
        {
            get
            {
                return mdp;
            }

            set
            {
                mdp = value;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Identifiant = txtIdentifiant.Text;
            this.Mdp = txtMotDePasse.Password.ToString();

            DataAccess dataAccess = DataAccess.Instance;

            dataAccess.ConnexionBD(Identifiant, Mdp);

            if (dataAccess.Connexion?.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Connexion réussie à la base de données!");
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Impossible de se connecter à la base de données.");
            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DialogResult != true)
            {
                Application.Current.Shutdown();
            }

        }
    }
}