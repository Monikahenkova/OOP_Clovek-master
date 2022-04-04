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

namespace OOP_Clovek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Clovek karel;
        Clovek jan;

        public MainWindow()
        {
            InitializeComponent();

            karel = new Clovek();
            karel.Jmeno = "Karel";
            karel.Prijmeni = "Cveček";
            karel.DatumNarozeni = new DateTime(2006, 5, 24);
            Zobraz(karel, txt1);

            jan = new Clovek();
            jan.Jmeno = "Jan";
            Zobraz(jan, txt2);
        }

        public void Zobraz(Clovek clovek, TextBox textBox)
        {
            textBox.Text = clovek.Prijmeni + " " + clovek.Jmeno + "\n";
            textBox.Text += "Datum narození: " + clovek.DatumNarozeni.ToShortDateString() + "\n";
            textBox.Text += "Život: " + clovek.Zivot.ToString() + "\n";
            textBox.Text += "Energie: " + clovek.Energie.ToString() + "\n";
            textBox.Text += "Dovednost: " + clovek.Dovednost.ToString() + "\n";
            textBox.Text += "Prohra: " + clovek.Prohra.ToString() + "\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            karel.Zestarnout();
            Zobraz(karel, txt1);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            karel.ZvysitDovednost();
            Zobraz(karel, txt1);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            karel.PridatEnergii();
            Zobraz(karel, txt1);  
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            karel.Spát();
            Zobraz(karel, txt1);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            karel.Bojuj();
            Zobraz(karel, txt1);
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            karel.Utéct();
            Zobraz(karel, txt1);
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            jan.Zestarnout();
            Zobraz(jan, txt2);
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            jan.ZvysitDovednost();
            Zobraz(jan, txt2);

        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            jan.PridatEnergii();
            Zobraz(jan, txt2);
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            jan.Spát();
            Zobraz(jan, txt2);
        }

        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            jan.Bojuj();
            Zobraz(jan, txt2);
        }

        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            jan.Utéct();
            Zobraz(jan, txt2);
        }

    }
}

