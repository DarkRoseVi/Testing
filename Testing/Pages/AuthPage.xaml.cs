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
using Testing.Components;
using Testing.Pages;

namespace Testing.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text.Trim();
            string password = PassworTb.Password.Trim();
            if (login.Length > 0 && password.Length > 0)
            {
                Navigation.AutoUser = DBConnect.db.User.ToList().Find(x => x.Password == password && x.Login == login);
                if (Navigation.AutoUser == null)
                {
                    MessageBox.Show("Вы кто");
                }
                else {
                    Navigation.Nextpage(new Nav(new CalendarPage()));
                }
            }
            else MessageBox.Show("Заполните поля");
        }
    }
}
