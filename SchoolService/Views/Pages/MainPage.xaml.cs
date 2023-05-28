using SchoolService.Views.Pages.ActionPages;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnServiceList_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServiceList(new Model.Service()));
        }

        private void btnAddClientService_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServiseClientAdd(new Model.ClientService()));
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UpcomingEntries());
        }
    }
}
