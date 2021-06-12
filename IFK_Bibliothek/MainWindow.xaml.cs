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

namespace IFK_Bibliothek
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Buchauflistung bücher = new Buchauflistung();
        private static MainWindow instanz;
        public MainWindow()
        {
            InitializeComponent();
            instanz = this;
        }

        private void CdbVerwaltung_Click(object sender, RoutedEventArgs e)
        {
            new Verwaltung(bücher).Show();
            this.Hide();
        }

        private void CdbSchließen_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CdbAusleihe_Click(object sender, RoutedEventArgs e)
        {
            new Ausleihe(bücher).Show();
            this.Hide();
        }

        private void CdbRückgabe_Click(object sender, RoutedEventArgs e)
        {
            new Rückgabe(bücher).Show();
            this.Hide();
        }
        public static MainWindow Instanz { get { return instanz; } }
    }
}
