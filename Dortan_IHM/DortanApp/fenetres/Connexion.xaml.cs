using DortanApp.config;
using System.Windows;

namespace Dortan
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string id = txtIdentifiant.Text;
            string mdp = txtMotDePasse.Password;

            DataAccess.Instance.UserId = id;
            DataAccess.Instance.Password = mdp;

            DataAccess dataAccess = DataAccess.Instance;

            dataAccess.ConnexionBD();

            if (dataAccess.Connexion != null && dataAccess.Connexion.State == System.Data.ConnectionState.Open)
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