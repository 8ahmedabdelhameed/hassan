using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forget_password.xaml
    /// </summary>
    public partial class forget_password : Page
    {  goodnessEntities db = new goodnessEntities();    
        public forget_password()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            goodtab tab = new goodtab();
           tab = db.goodtabs.First(x => x.username == name.Text);
            tab.password_ = password.Text;
            if (password.Text == cpassword.Text)
            {
                db.goodtabs.AddOrUpdate(tab);
                db.SaveChanges();
                MessageBox.Show("your password has been updated");
                sign sign = new sign();
                NavigationService.Navigate(sign);
            }
            else { MessageBox.Show("password in confirmation is not similar to the original"); }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sign sign = new sign();
            NavigationService.Navigate(sign);   
        }
    }
}
