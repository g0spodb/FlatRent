using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlatRent
{
    /// <summary>
    /// Логика взаимодействия для PageApartments.xaml
    /// </summary>
    public partial class PageApartments : Page
    {
        User User { get; set; }
        public static ObservableCollection<Apartment> apartments { get; set; }
        public PageApartments(User user)
        {
            InitializeComponent();
            User = user;
            var currentRecipes = FlatRentEntities.GetContext().Apartment.ToList();
            LViewAparts.ItemsSource = currentRecipes;
        }

        private void NewClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAddApartment(User));
        }

        private void AccountClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAccount(User));
        }

        private void LViewAparts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
