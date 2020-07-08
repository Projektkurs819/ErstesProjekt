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

namespace BerechnungVorwiderstandLED_Wpf
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double Widerstand = Math.Round(BerechneR(Convert.ToDouble(txt_SpannungQuelle.Text), Convert.ToDouble(txt_Spannungsabfall.Text), Convert.ToDouble(txt_Stromverbrauch.Text)), 3);
                lbl_Widerstand.Content = "Widerstand = " + Widerstand + " Ω";
            }
            catch { MessageBox.Show("Bitte numerische Werte eintragen"); }
        }
        public double BerechneR(double SpannungQuelle, double Spannungsabfall, double Stromverbrauch)
        {
            double R, Sp;
            Sp = SpannungQuelle - Spannungsabfall;
            R = Sp / Stromverbrauch;
            return R;
        }

        public void Ringfarben(double Widerstand)
        { }
    }
}
