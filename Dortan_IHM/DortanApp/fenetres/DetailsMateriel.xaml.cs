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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DortanApp
{
    /// <summary>
    /// Logique d'interaction pour DetailsMateriel.xaml
    /// </summary>
    public partial class DetailsMateriel : Window
    {
        public DetailsMateriel()
        {
            InitializeComponent();
        }

        public void AfficherDetails(DortanApp.Materiel materiel)
        {
            if(materiel !=  null)
            {
                lbNomCategorie.Content = materiel.NomCategorie;
                lbDonneeSite.Content = materiel.Site;
                lbDonneeType.Content = materiel.Type;
                lbDonneeNomMateriel.Content = materiel.Nom;
                lbDonneeNomMarque.Content = materiel.Marque;
                lbDonneeDescritpion.Content = materiel.Description;
                lbDonneePuissanceCV.Content = materiel.PuissanceCV;
                lbDonneePuissanceW.Content = materiel.PuissanceW;
                lbDonneeCoutUtilisation.Content = materiel.CoutUtilisation;
            }
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
