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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Product1
{
    /// <summary>
    /// Music.xaml 的交互逻辑
    /// </summary>
    public partial class Music : Window
    {
        public Music()
        {
            InitializeComponent();
        }
        readonly MediaPlayer MUSIC = new();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            MUSIC.Open(new Uri("Resource\\ULTIMATE.wav", UriKind.Relative));
            MUSIC.Play();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MUSIC.Open(new Uri("Resource\\THEWORLD.mp3", UriKind.Relative));
            MUSIC.Play();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MUSIC.Open(new Uri("Resource\\TEETH.mp3", UriKind.Relative));
            MUSIC.Play();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("可能采样不够");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MUSIC.Open(new Uri("Resource\\Never Be Alone.mp3", UriKind.Relative));
            MUSIC.Play();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Border1.Visibility = Visibility.Visible;
            Border2.Visibility = Visibility.Visible;
            Border3.Visibility = Visibility.Visible;
            Border4.Visibility = Visibility.Visible;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Border1.Visibility = Visibility.Hidden;
            Border2.Visibility = Visibility.Hidden;
            Border3.Visibility = Visibility.Hidden;
            Border4.Visibility = Visibility.Hidden;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MUSIC.Pause();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MUSIC.Play();
        }
    }
}
