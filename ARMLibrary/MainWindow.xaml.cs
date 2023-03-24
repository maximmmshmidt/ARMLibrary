using ARMLibrary.Pages;
using ARMLibrary.Pages.PagesUser.Admin;
using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace ARMLibrary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isMin;

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LogPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(new MainPageAdmin());
        }

        private void RollUpButtonClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
            
        }

        private void UnwrapButtonClick(object sender, RoutedEventArgs e)
        {
            if (isMin)
            {
                WindowState = WindowState.Normal;
                isMin = false;
            }
            else
            {
                WindowState = WindowState.Maximized;
                isMin = true;
            }
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RowDefinition_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
