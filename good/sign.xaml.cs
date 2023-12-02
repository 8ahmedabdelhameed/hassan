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

namespace good
{
    /// <summary>
    /// Interaction logic for sign.xaml
    /// </summary>
    public partial class sign : Page
    {    goodnessEntities db= new goodnessEntities();   
        public sign()
        {   
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {     goodtab tab = new goodtab();
        var ss=db.goodtabs.First(x=>x.username==name.Text&&x.password_==password.Password);
            try
            { welcome s = new welcome();
                if (ss != null)
                { NavigationService.Navigate(s); }
               

                
            }catch  { MessageBox.Show("wrong password or username try again"); }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            forget_password p = new forget_password();
            NavigationService.Navigate(p);        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            create create = new create();
            NavigationService.Navigate(create);
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

        }
    }
}
