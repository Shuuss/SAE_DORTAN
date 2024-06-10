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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DortanApp
{
    /// <summary>
    /// Logique d'interaction pour UCReservation.xaml
    /// </summary>
    public partial class UCReservation : UserControl
    {
        public UCReservation()
        {
            InitializeComponent();
        }

        private void BtReserver_Click(object sender, RoutedEventArgs e)
        {
            if (dgActivites.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une activité.");
                return;
            }

            DateTime dateReservation = dpDate.SelectedDate ?? DateTime.MinValue;

            if (!int.TryParse(tbDuree.Text, out int dureeReservation))
            {
                MessageBox.Show("Veuillez entrer une durée valide en heures.");
                return;
            }

            if (dateReservation == DateTime.MinValue)
            {
                MessageBox.Show("Veuillez sélectionner une date.");
                return;
            }

            Activite activiteSelectionnee = dgActivites.SelectedItem as Activite;
            if (activiteSelectionnee == null)
            {
                MessageBox.Show("Erreur lors de la récupération de l'activité sélectionnée.");
                return;
            }

            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            TabControl tabControl = mainWindow.tcMain;
            tabControl.SelectedIndex = 3;

            Reservation nvReservation = new Reservation(activiteSelectionnee, dateReservation, dureeReservation);

            mainWindow.CreationReservation(nvReservation);

            dpDate.SelectedDate = null;
            dgActivites.SelectedItem = null;
            tbDuree.Text = "";
        }

        private void BtCreationActivite_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            TabControl tabControl = mainWindow.tcMain;
            tabControl.SelectedIndex = 2;
        }
    }
}
