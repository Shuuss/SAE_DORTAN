using DortanApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
            else
                MessageBox.Show(this, "Veuillez selectionner un materiels");

        }
    }
}
