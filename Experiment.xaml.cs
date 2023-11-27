using System;
using System.Windows;
using System.Windows.Controls;

namespace Product1
{
    public partial class Experiment : Window
    {
        public Experiment()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //获得page1 页面活动面板
            Uri uri = new Uri("../Page1.xaml", UriKind.Relative);
            framemain.Source = uri;
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            //获得page2 页面活动面板
            Uri uri = new Uri("../Page2.xaml", UriKind.Relative);
            framemain.Source = uri;
        }
    }
}


