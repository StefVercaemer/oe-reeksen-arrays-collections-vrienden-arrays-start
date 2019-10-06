using System;
using System.Windows;
using System.Windows.Input;

namespace Vrienden.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            ToonHuidigeVrienden();
        }

        void ToonHuidigeVrienden()
        {

        }

        void VulListBox()
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VulListBox();
        }
    }
}
