using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ToDoListWpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Uri iconUri = new Uri("C:/Users/karol/source/repos/ToDoListWpfApp1/img/icon.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);

            InitializeComponent();
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            cb1.Content = "The CheckBox is checked.";
            popup.IsOpen = true;
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            cb1.Content = "The CheckBox is unchecked.";
            popup.IsOpen = false;
        }

        private void ClickAddTask(object sender, RoutedEventArgs e)
        {
            var newtask = new TextBox();
            newtask.Text = "New task";
            sp.Children.Add(newtask);
            sp.UpdateLayout();
        }
    }
}