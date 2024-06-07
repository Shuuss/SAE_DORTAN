using DortanApp;
using System.Windows;

namespace Dortan
{
    /// <summary>
    /// Logique d'interaction pour Materiel.xaml
    /// </summary>
    public partial class Materiel : Window
    {
        public Materiel()
        {
            InitializeComponent();
        }


        private void btValider_Click(object sender, RoutedEventArgs e)
        {
            /*if (dbMateriel.SelectedItem != null)
            {
                DortanApp.Materiel materielSelectionne = (DortanApp.Materiel)dbMateriel.SelectedItem;
                DetailsMateriel details = new DetailsMateriel();
                details.AfficherDetails(materielSelectionne);
                details.ShowDialog();

                if (details.DialogResult == false)
                {
                    details.Close();
                }
            }
            else
                MessageBox.Show(this, "Veuillez selectionner un materiels");*/

        }

        private void dbMateriel_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            
                DortanApp.Materiel materielSelectionne = (DortanApp.Materiel)dbMateriel.SelectedItem;
                DetailsMateriel details = new DetailsMateriel();
                details.AfficherDetails(materielSelectionne);
                details.ShowDialog();

                if (details.DialogResult == false)
                {
                    details.Close();
                }
        }
    }
}
