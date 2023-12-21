using Product1.Items;
using System;
using System.Windows;
using System.Windows.Media;

namespace Product1
{

    /// <summary>
    /// Music.xaml 的交互逻辑
    /// </summary>
    public partial class Music : Window
    {
        public int n;
        public Music()
        {
            InitializeComponent();
        }
        readonly MediaPlayer MUSIC = new();
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            PlayMusic("Resource\\ULTIMATE.wav", 1);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PlayMusic("Resource\\Never Be Alone.mp3", 2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PlayMusic("Resource\\THEWORLD.mp3", 3);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PlayMusic("Resource\\TEETH.mp3", 4);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            PlayMusic("Resource\\Memories.wav", 5);
        }

        private void PlayMusic(string filePath, int number)
        {
            MUSIC.Open(new Uri(filePath, UriKind.Relative));
            MUSIC.Play();
            n = number;
            ShowLyrics();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("可能采样不够");
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
        private void ShowLyrics()
        {
            Lyrics lyricsWindow = new Lyrics(n); // 将 n 作为参数传递给 Lyrics 构造函数
            lyricsWindow.Show();
        }

        
    }
}
