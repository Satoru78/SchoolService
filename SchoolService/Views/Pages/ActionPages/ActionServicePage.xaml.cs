using Microsoft.Win32;
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
    /// Логика взаимодействия для ActionServicePage.xaml
    /// </summary>
    public partial class ActionServicePage : Page
    {
        public Service Service { get; set; }
        public ActionServicePage(Service service)
        {
            InitializeComponent();
            Service = service;
            this.DataContext = this;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (Service.ID == 0)
            {
                DataApp.db.Service.Add(Service);
            }     
            DataApp.db.SaveChanges();
            MessageBox.Show("Data add", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }
        OpenFileDialog file = new OpenFileDialog();
        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            file.Filter = "Image (*.jpg;*.jpeg;*.png;) |  *.jpg; *.jpeg; *.png";
            if (file.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(file.FileName));
                Img.Source = image;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
