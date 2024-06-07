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
    /// Logique d'interaction pour Recap.xaml
    /// </summary>
    public partial class Recap : Window
    {
        public Recap(string nomActivite, DatePicker dateDebut, string duree)
        {
            InitializeComponent();
            tbNom.Text = nomActivite;
            dpDate = dateDebut;
            tbDuree.Text = duree.ToString();
        }
    }
}
