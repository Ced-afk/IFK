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

namespace IFK_Bibliothek
{
    /// <summary>
    /// Interaktionslogik für Ausleihe.xaml
    /// </summary>
    public partial class Ausleihe : Window
    {
        Buchauflistung bücher;
        public Ausleihe(Buchauflistung bücher)
        {
            InitializeComponent();
            pog.ItemsSource = bücher.Buchliste;
            this.bücher = bücher;
            pog.AutoGeneratingColumn += pog_AutoGeneratingColumn;
        }

        private void pog_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "Frei") e.Cancel = true;
        }

        private void CdbZurück_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.Instanz.Show();
        }
        private void CdbAusleihen_Click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = LeihDatum.SelectedDate;
            int signatur;
            if (selectedDate.HasValue && Int32.TryParse(Signatur.Text, out signatur))
            {
                bücher.Buchupdate(signatur, Ausleiher.Text, selectedDate.Value);

                CollectionViewSource.GetDefaultView(pog.ItemsSource).Refresh();
            }
        }
    }
}
