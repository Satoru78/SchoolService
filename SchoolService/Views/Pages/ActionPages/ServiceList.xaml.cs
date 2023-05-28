using SchoolService.Context;
using SchoolService.Model;
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

namespace SchoolService.Views.Pages.ActionPages
{
    /// <summary>
    /// Логика взаимодействия для ServiceList.xaml
    /// </summary>
    public partial class ServiceList : Page
    {
        public List<Service> Services { get; set; }
        public Service Service { get; set; }
        public ServiceList(Service service)
        {
            InitializeComponent();
            Service = service;
            this.DataContext = this;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ActionServicePage(new Model.Service()));
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Service)ListDataView.SelectedItem;
            if (selectedItem != null)
            {
                NavigationService.Navigate(new ActionServicePage(selectedItem));
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Service)ListDataView.SelectedItem;
            if (selectedItem != null)
            {
                DataApp.db.Service.Remove(selectedItem);
                DataApp.db.SaveChanges();
            }
                Page_Loaded(null, null);
                MessageBox.Show("Data deleted", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListDataView.ItemsSource = DataApp.db.Service.Where(item => item.Title.ToString().Contains(Search.Text) || item.Description.ToString().Contains(Search.Text)).ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Services = DataApp.db.Service.ToList();
            ListDataView.ItemsSource = Services;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
