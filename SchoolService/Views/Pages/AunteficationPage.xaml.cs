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

namespace SchoolService.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AunteficationPage.xaml
    /// </summary>
    public partial class AunteficationPage : Page
    {
        public AunteficationPage()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbCode.Text == "")
                {
                    throw new Exception("заполните поле!");
                }
                else if(txbCode.Text == "0000")
                {
                    NavigationService.Navigate(new MainPage());
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
