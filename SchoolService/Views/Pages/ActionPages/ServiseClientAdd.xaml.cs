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
    /// Логика взаимодействия для ServiseClientAdd.xaml
    /// </summary>
    public partial class ServiseClientAdd : Page
    {
        public List<Service> Services { get; set; }
        public ClientService ClientService { get; set; }
        public List<Client> Clients { get; set; }
        public ServiseClientAdd(ClientService clientService)
        {
            InitializeComponent();
            ClientService = clientService;
            this.DataContext = this;
            Clients = DataApp.db.Client.ToList();
            Services = DataApp.db.Service.ToList();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ClientService.ID == 0)
                {
                    DataApp.db.ClientService.Add(ClientService);
                }
                DataApp.db.SaveChanges();
                MessageBox.Show("Data add", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
