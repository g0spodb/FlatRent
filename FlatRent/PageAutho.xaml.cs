using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FlatRent
{
    /// <summary>
    /// Логика взаимодействия для PageAutho.xaml
    /// </summary>
    public partial class PageAutho : Page
    {
        public static ObservableCollection<User> users { get; set; }
        public PageAutho()
        {
            InitializeComponent();
        }

        private void AuthoClick(object sender, RoutedEventArgs e)
        {
            users = new ObservableCollection<User>(bd_connection.connection.User.ToList());
            var z = users.Where(a => a.Login == tb_Login.Text && a.Password == pb_Password.Password).FirstOrDefault();
            if (z != null)
            {
                MessageBox.Show("Добро пожаловать, " + z.FullName);
                if (z.Id_Role == 2)
                {
                    NavigationService.Navigate(new PageApartments(z));
                }
                else
                {
                    NavigationService.Navigate(new PageAdmin());
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }
        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}