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

namespace ToDoListWpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Uri iconUri = new Uri("C:/Users/Kari/source/repos/ToDoListWpfApp1/img/icon.png", UriKind.RelativeOrAbsolute);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }



        //private void HandleThirdState(object sender, RoutedEventArgs e)
        //{
        //    cb1.Content = "The CheckBox is in the indeterminate state.";
        //    popup.IsOpen = false;
        //}
    }
}