using System;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Product1.Items
{
    /// <summary>
    /// Lyrics.xaml 的交互逻辑
    /// </summary>
    public partial class Lyrics : Window
    {
        Music MirrorMusic = new();
        int N;
        String FileName="Ultimate.txt";
        public Lyrics(int n)
        {
            InitializeComponent(); 
            N=n;
            LoadUltimate();
        }
        private void LoadUltimate()
        {
            if (N == 1)
            {
                FileName = "Ultimate.txt";
            }
            else if (N == 2)
            {
                FileName = "Alone.txt";
            }
            else if(N == 3)
            {
                FileName = "Theworld.txt";
            }
            else if(N == 4) 
            {
                FileName = "Teeth.txt";
            }
            else if (N == 5)
            {
                FileName = "Memories.txt";
            }
            MyRichTextBox.Document.Blocks.Clear();
            MyRichTextBox.Document.Blocks.Add(new Paragraph(new Run(File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource", FileName)))
            {
                FontStyle = FontStyles.Italic,
                Foreground = Brushes.Blue,
                FontSize=30,
                FontWeight = FontWeights.Bold
            }));
        }      
        Point _pressedPosition;
        bool _isDragMoved = false;
        private void Window_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _pressedPosition = e.GetPosition(this);
        }
        void Window_PreviewMouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed && _pressedPosition != e.GetPosition(this))
            {
                _isDragMoved = true;
                DragMove();
            }
        }
        void Window_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (_isDragMoved)
            {
                _isDragMoved = false;
                e.Handled = true;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Close();
        }
    }
}
