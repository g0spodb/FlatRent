using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlatRent
{
    /// <summary>
    /// Логика взаимодействия для PageAccount.xaml
    /// </summary>
    public partial class PageAccount : Page
    {
        public User User { get; set; }
        public PageAccount(User user)
        {

            InitializeComponent();
            User = user;
            this.DataContext = this;
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            tbFullName.Visibility = Visibility.Hidden;
            tbPhone.Visibility = Visibility.Hidden;
            tbPassport.Visibility = Visibility.Hidden;
            tbLogin.Visibility = Visibility.Hidden;
            tbPassword.Visibility = Visibility.Hidden;
            Save.Visibility = Visibility.Hidden;

            FullName.Visibility = Visibility.Visible;
            Phone.Visibility = Visibility.Visible;
            Passport.Visibility = Visibility.Visible;
            Login.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Visible;
            Edit.Visibility = Visibility.Visible;
            User.FullName = tbFullName.Text;
            User.Phone = tbPhone.Text;
            User.Passport = tbPassport.Text;
            User.Login = tbLogin.Text;
            User.Password = tbPassword.Text;
            bd_connection.connection.SaveChanges();
            NavigationService.Navigate(new PageAccount(User));
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            tbFullName.Visibility = Visibility.Visible;
            tbPhone.Visibility = Visibility.Visible;
            tbPassport.Visibility = Visibility.Visible;
            tbLogin.Visibility = Visibility.Visible;
            tbPassword.Visibility = Visibility.Visible;
            Save.Visibility = Visibility.Visible;
            Photo.Visibility = Visibility.Visible;

            FullName.Visibility = Visibility.Hidden;
            Phone.Visibility = Visibility.Hidden;
            Passport.Visibility = Visibility.Hidden;
            Login.Visibility = Visibility.Hidden;
            Password.Visibility = Visibility.Hidden;
            Edit.Visibility = Visibility.Hidden;
        }

        private void PhotoClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "*.jpg|*.jpg|*.png|*.png"
            };
            if (openFile.ShowDialog().GetValueOrDefault())
            {
                User.Photo = File.ReadAllBytes(openFile.FileName);
                img_prod.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageApartments(User));
        }

        private void ShowClick(object sender, RoutedEventArgs e)
        {
            Password.Visibility = Visibility.Visible;
            Login.Visibility = Visibility.Visible;
        }
    }
}
