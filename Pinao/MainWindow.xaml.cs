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

namespace Pinao
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        
        SolidColorBrush backgroundColorDown = Brushes.GreenYellow;
        SolidColorBrush backgroundColorLeft = Brushes.LightGray;
        SolidColorBrush backgroundColorRight = Brushes.White;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            MediaPlayer mp = new MediaPlayer();
            Uri uri = null;
            

            switch (e.Key)
            {
                case Key.A:
                    key_1_Low.Background = backgroundColorDown;
                     uri = new Uri(Environment.CurrentDirectory + "\\music\\c-1.mp3" );
                    mp.Open(uri);
                     mp.Play();
                    break;
                case Key.B:
                    key_2_Low.Background = backgroundColorDown;
                     uri = new Uri(Environment.CurrentDirectory + "\\music\\d-1.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.C:
                    key_3_Low.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\e-1.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.D:
                    key_4_Low.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\f-#1.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.E:
                    key_5_Low.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\g-#1.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.F:
                    key_6_Low.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\a-#1.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.G:
                    key_7_Low.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\b-1.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.H:
                    key_1_High.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\c-2.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.I:
                    key_2_High.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\d-2.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.J:
                    key_3_High.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\e-2.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.K:
                    key_4_High.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\f-#2.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.L:
                    key_5_High.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\g-#2.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.M:
                    key_6_High.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\a-#2.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;
                case Key.N:
                    key_7_High.Background = backgroundColorDown;
                    uri = new Uri(Environment.CurrentDirectory + "\\music\\b-2.mp3");
                    mp.Open(uri);
                    mp.Play();
                    break;

                default:
                    break;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.A:
                    key_1_Low.Background = backgroundColorLeft;
                    break;
                case Key.B:
                    key_2_Low.Background = backgroundColorLeft;
                    break;
                case Key.C:
                    key_3_Low.Background = backgroundColorLeft;
                    break;
                case Key.D:
                    key_4_Low.Background = backgroundColorLeft;
                    break;
                case Key.E:
                    key_5_Low.Background = backgroundColorLeft;
                    break;
                case Key.F:
                    key_6_Low.Background = backgroundColorLeft;
                    break;
                case Key.G:
                    key_7_Low.Background = backgroundColorLeft;
                    break;

                case Key.H:
                    key_1_High.Background = backgroundColorRight;
                    break;
                case Key.I:
                    key_2_High.Background = backgroundColorRight;
                    break;
                case Key.J:
                    key_3_High.Background = backgroundColorRight;
                    break;
                case Key.K:
                    key_4_High.Background = backgroundColorRight;
                    break;
                case Key.L:
                    key_5_High.Background = backgroundColorRight;
                    break;
                case Key.M:
                    key_6_High.Background = backgroundColorRight;
                    break;
                case Key.N:
                    key_7_High.Background = backgroundColorRight;
                    break;

                default:
                    break;
            }

        }
    }
}
