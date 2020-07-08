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

namespace BerechnungVorwiederstandLED_Wpf
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

        private void btnBerechnen_Click(object sender, RoutedEventArgs e)
        {
            if(txt_SpannungQuelle.Text !="" && txt_SpgAbfall.Text != "" && txt_Strom.Text !="")
            {
                double U_Quelle = Convert.ToDouble(txt_SpannungQuelle.Text);
                double U_Abfall = Convert.ToDouble(txt_SpgAbfall.Text);
                double I_LED = Convert.ToDouble(txt_Strom.Text);

                double U_Diff = U_Quelle - U_Abfall;

                int R = Convert.ToInt32(U_Diff * 1000 / I_LED);

                string ergebnis = R.ToString();
                lbl_Ergebnis.Content = ergebnis;

                char[] wert = ergebnis.ToCharArray();
                if(wert.Length>1)
                {
                    switch (wert[0])
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
                        default: break;
                    }
                    switch (wert[1])
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
                        default: break;
                    }
                    int S = R;
                    int zaehler = -2;
                    while(S>0)
                    {
                        zaehler++;
                        S = S / 10;
                    }
                    switch (zaehler)
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
                        default: break;
                    }
                }
            }
        }
    }
}
