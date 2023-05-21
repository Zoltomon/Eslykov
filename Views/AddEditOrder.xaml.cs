using CommercialFirm.Classes;
using CommercialFirm.Models;
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

namespace CommercialFirm.Views
{
    /// <summary>
    /// Логика взаимодействия для AddEditOrder.xaml
    /// </summary>
    public partial class AddEditOrder : Page
    {
        private Order _order = new Order();
        public AddEditOrder(Order order)
        {
            InitializeComponent();
            if (order != null)
                _order = order;
            DataContext = _order;


            ComboClient.DisplayMemberPath = "FIO";
            ComboClient.SelectedValuePath = "id";
            ComboClient.ItemsSource = DBConnect.connectDB.Client.ToList();

            ComboModels.DisplayMemberPath = "Name";
            ComboModels.SelectedValuePath = "Id";
            ComboModels.ItemsSource = DBConnect.connectDB.Model.ToList();

            ComboPrice.DisplayMemberPath = "Price";
            ComboPrice.SelectedValuePath = "Id";
            ComboPrice.ItemsSource = DBConnect.connectDB.PriceList.ToList();

            ComboStatus.DisplayMemberPath = "Type";
            ComboStatus.SelectedValuePath = "Id";
            ComboStatus.ItemsSource = DBConnect.connectDB.Status.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order order = new Order()
                {
                    Client = ComboClient.SelectedItem as Client,
                    Model = ComboModels.SelectedItem as Model,
                    PriceList = ComboPrice.SelectedItem as PriceList,
                    Status = ComboStatus.SelectedItem as Status,
                };

                DBConnect.connectDB.Order.Add(order);
                DBConnect.connectDB.SaveChanges();
                MessageBox.Show("Данные успешно добавлены!",
                "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message.ToString(),
                    "Критическая ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
    }
}
