using System.Windows;
using System.Windows.Controls;

namespace DortanApp
{
    /// <summary>
    /// Logique d'interaction pour UCMateriel.xaml
    /// </summary>
    public partial class UCMateriel : UserControl
    {
        public UCMateriel()
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
            if (dbMateriel.SelectedItem != null)
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
}
