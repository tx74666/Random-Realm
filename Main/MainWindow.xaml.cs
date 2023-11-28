using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Product1.Main
{

    public partial class MainWindow : Window
    {
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Politics Politics = new();
            Politics.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Music Music = new();
            Music.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Tech Tech = new();
            Tech.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Game Game = new();
            Game.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Experiment Experiment = new();
            Experiment.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Ambition Ambition = new();
            Ambition.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Society Society = new();
            Society.Show();
        }
    }
}
