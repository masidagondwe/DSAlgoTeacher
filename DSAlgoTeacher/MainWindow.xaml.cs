using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DSAlgoTeacher.Views;

namespace DSAlgoTeacher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;

            GridBody.Margin = new Thickness(201, 61, 0, 0);
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;

            GridBody.Margin = new Thickness(71, 61, 0, 0);
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl? usc = null;
            GridBody.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "Home":
                    usc = new UCHome();
                    GridBody.Children.Add(usc);
                    break;
                case "Data_Structures":
                    usc = new UCDataStructures();
                    GridBody.Children.Add(usc);
                    break;
                case "Algorithms":
                    usc = new UCAlgorithms();
                    GridBody.Children.Add(usc);
                    break;
          
                default:
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtMainTitle.Text = "Your Data Structures & Algorithms Teacher";
        }
    }
}