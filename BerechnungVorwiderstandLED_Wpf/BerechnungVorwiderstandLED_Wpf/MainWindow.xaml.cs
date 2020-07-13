using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
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
                Ringfarben(Widerstand);
            }
            catch { MessageBox.Show("Bitte numerische Werte eintragen"); }
        }
        public double BerechneR(double Betriebsspannung, double SpannungL, double LeistungL)
        {
            double Rv, Ur;
            Ur = Betriebsspannung - SpannungL;
            Rv = (Ur*1000) / LeistungL;
            
            return Rv;
        }

        public void Ringfarben(double Widerstand)
        {
            double wid = Math.Ceiling(Widerstand);
            String zw = Convert.ToString(wid);
            char[] stellen = zw.ToCharArray();
            char[] inhalt = zw.ToCharArray();
            int laenge = stellen.Length;
            int multipl = 0;

            if (laenge > 1)
            {
                for (int n = 0; n < (laenge - 2); n++) multipl++;
                // MessageBox.Show("" + multipl);
                switch (multipl)
                {
                    case 0: lblRing3.Background = Brushes.Black; break;
                    case 1: lblRing3.Background = Brushes.Brown; break;
                    case 2: lblRing3.Background = Brushes.Red; break;
                    case 3: lblRing3.Background = Brushes.Orange; break;
                    case 4: lblRing3.Background = Brushes.Yellow; break;
                    case 5: lblRing3.Background = Brushes.Green; break;
                    case 6: lblRing3.Background = Brushes.Blue; break;
                    case 7: lblRing3.Background = Brushes.Violet; break;
                    case 8: lblRing3.Background = Brushes.Gray; break;
                    case 9: lblRing3.Background = Brushes.White; break;
                }
                switch (inhalt[1])
                {
                    case '0': lblRing2.Background = Brushes.Black; break;
                    case '1': lblRing2.Background = Brushes.Brown; break;
                    case '2': lblRing2.Background = Brushes.Red; break;
                    case '3': lblRing2.Background = Brushes.Orange; break;
                    case '4': lblRing2.Background = Brushes.Yellow; break;
                    case '5': lblRing2.Background = Brushes.Green; break;
                    case '6': lblRing2.Background = Brushes.Blue; break;
                    case '7': lblRing2.Background = Brushes.Violet; break;
                    case '8': lblRing2.Background = Brushes.Gray; break;
                    case '9': lblRing2.Background = Brushes.White; break;
                }
                switch (inhalt[0])
                {
                    case '0': lblRing1.Background = Brushes.Black; break;
                    case '1': lblRing1.Background = Brushes.Brown; break;
                    case '2': lblRing1.Background = Brushes.Red; break;
                    case '3': lblRing1.Background = Brushes.Orange; break;
                    case '4': lblRing1.Background = Brushes.Yellow; break;
                    case '5': lblRing1.Background = Brushes.Green; break;
                    case '6': lblRing1.Background = Brushes.Blue; break;
                    case '7': lblRing1.Background = Brushes.Violet; break;
                    case '8': lblRing1.Background = Brushes.Gray; break;
                    case '9': lblRing1.Background = Brushes.White; break;
                }
            }
            else {
                lblRing1.Background = Brushes.Black;
                switch (inhalt[0])
                {
                    case '0': lblRing2.Background = Brushes.Black; break;
                    case '1': lblRing2.Background = Brushes.Brown; break;
                    case '2': lblRing2.Background = Brushes.Red; break;
                    case '3': lblRing2.Background = Brushes.Orange; break;
                    case '4': lblRing2.Background = Brushes.Yellow; break;
                    case '5': lblRing2.Background = Brushes.Green; break;
                    case '6': lblRing2.Background = Brushes.Blue; break;
                    case '7': lblRing2.Background = Brushes.Violet; break;
                    case '8': lblRing2.Background = Brushes.Gray; break;
                    case '9': lblRing2.Background = Brushes.White; break;
                }
            }            
        }
    }
}
