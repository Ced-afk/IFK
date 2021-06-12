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
    /// Interaktionslogik für Verwaltung.xaml
    /// </summary>
    public partial class Verwaltung : Window
    {
        private Buchauflistung bücher;

        public Verwaltung(Buchauflistung bücher)
        {
            InitializeComponent();
            pog.ItemsSource = bücher.Buchliste;
            this.bücher = bücher;
            pog.AutoGeneratingColumn += pog_AutoGeneratingColumn; */
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

        private void CdbHinzufügen_Click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = Datum.SelectedDate;
            if (selectedDate.HasValue)
            {
                bücher.BuchHinzufügen(ID.Text, Autor.Text, Titel.Text, Signatur.Text, Person.Text, selectedDate.Value);

                CollectionViewSource.GetDefaultView(pog.ItemsSource).Refresh();
            }
        }

        private void CdbLöschen_Click(object sender, RoutedEventArgs e)
        {
            if (pog.SelectedIndex >= 0)
            { 
                bücher.Buchlöschen(pog.SelectedIndex);
            }
        }
    }
}
