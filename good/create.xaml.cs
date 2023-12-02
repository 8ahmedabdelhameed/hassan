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
    /// Interaction logic for create.xaml
    /// </summary>
    public partial class create : Page
    {
        goodnessEntities db = new goodnessEntities();
        public create()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sign s = new sign();
            NavigationService.Navigate(s);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            goodtab tab = new goodtab();
            try
            {
                tab.username = name.Text;
                tab.password_ = password.Text;
                db.goodtabs.Add(tab);
                db.SaveChanges();
                MessageBox.Show(name.Text + " hass been added");
            }
            catch { MessageBox.Show("username is already taken try to use "+name.Text+"*@#12"); }
        }
    }
}
