using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace Product1.Items
{
    /// <summary>
    /// Lyrics.xaml 的交互逻辑
    /// </summary>
    public partial class Lyrics : Window
    {
        public Lyrics()
        {
            InitializeComponent();
            LoadFileContent();
        }
        private void LoadFileContent()
        {
            MyRichTextBox.Document.Blocks.Clear();
            MyRichTextBox.Document.Blocks.Add(new Paragraph(new Run(File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource", "Ultimate.txt")))
            {
                FontStyle = FontStyles.Italic,
                Foreground = Brushes.Blue,
                FontSize=16,
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
