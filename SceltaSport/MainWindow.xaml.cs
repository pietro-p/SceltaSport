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

namespace SceltaSport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rdbCalcio.IsEnabled = false;
            rdbNuoto.IsEnabled = false;
            rdbPallavolo.IsEnabled = false;
            rdbJuventus.IsEnabled = false;
            rdbInter.IsEnabled = false;
            rdbRoma.IsEnabled = false;
            rdbMilan.IsEnabled = false;
            rdbPellegrini.IsEnabled = false;
            rdbPhepls.IsEnabled = false;
            rdbThorpe.IsEnabled = false;
            rdbSpitz.IsEnabled = false;
            rdbIvan.IsEnabled = false;
            rdbTofoli.IsEnabled = false;
            rdbGravina.IsEnabled = false;
            rdbGiannelli.IsEnabled = false;
        }

        private void btnDati_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text == "" || txtCognome.Text == "" || txtEtà.Text == "")
            {
                MessageBox.Show("Non sono stati compilati tutti i campi", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                try
                {
                    int età = int.Parse(txtEtà.Text);
                    if (età < 20)
                    {
                        MessageBox.Show("Inserire un'età maggiore di 20 anni ", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                        txtEtà.Clear();

                    }
                    else
                    {
                        rdbCalcio.IsEnabled = true;
                        rdbNuoto.IsEnabled = true;
                        rdbPallavolo.IsEnabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
        }

        private void btnContinua_Click(object sender, RoutedEventArgs e)
        {
            rdbJuventus.IsEnabled = false;
            rdbInter.IsEnabled = false;
            rdbRoma.IsEnabled = false;
            rdbMilan.IsEnabled = false;
            rdbPellegrini.IsEnabled = false;
            rdbPhepls.IsEnabled = false;
            rdbThorpe.IsEnabled = false;
            rdbSpitz.IsEnabled = false;
            rdbIvan.IsEnabled = false;
            rdbTofoli.IsEnabled = false;
            rdbGravina.IsEnabled = false;
            rdbGiannelli.IsEnabled = false; 

            if (rdbCalcio.IsChecked == true)
            {
                rdbJuventus.IsEnabled = true;
                rdbInter.IsEnabled = true;
                rdbRoma.IsEnabled = true;
                rdbMilan.IsEnabled = true;
            }
            if (rdbNuoto.IsChecked == true)
            {
                rdbPellegrini.IsEnabled = true;
                rdbPhepls.IsEnabled = true;
                rdbThorpe.IsEnabled = true;
                rdbSpitz.IsEnabled = true;
            }
            if (rdbPallavolo.IsChecked == true)
            {
                rdbIvan.IsEnabled = true;
                rdbTofoli.IsEnabled = true;
                rdbGravina.IsEnabled = true;
                rdbGiannelli.IsEnabled = true;
            }
        }
    }
}




