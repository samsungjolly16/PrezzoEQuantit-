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

namespace PrezzoQuantitàWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMostra_Click(object sender, RoutedEventArgs e)
        {



            if (txtPrezzo.Text != "" && txtQuantità.Text != "")//txt.Prezzo.Lenght>0
                try
                {
                    double sconto;

                    if (txtSconto.Text != "")
                    {
                        sconto = double.Parse(txtSconto.Text);

                    }
                    else
                    {
                        sconto = 0;
                    }
                    if (sconto > 100 || sconto < 0)
                    {
                        MessageBox.Show("inserito un valore fuori dal range 0-100", "attenzione", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        double totale;
                        double p = double.Parse(txtPrezzo.Text);
                        double q = double.Parse(txtQuantità.Text);



                        double valoreSconto;
                        if (q >= 20)
                        {
                            totale = p * q;
                            valoreSconto = sconto * totale / 100;
                            totale = totale - valoreSconto;

                        }
                        else
                        {
                            totale = p * q;
                        }

                        lblStampa.Content = totale;
                    }

                }
                catch (Exception ex)
                {
                    lblStampa.Content = ex.Message;
                }
            else
            {
                MessageBox.Show("inserire tutti  dati richiesti", "attenzione", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}
