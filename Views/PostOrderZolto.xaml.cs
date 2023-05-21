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
using CommercialFirm.Classes;

namespace CommercialFirm.Views
{
    /// <summary>
    /// Логика взаимодействия для PostOrderZolto.xaml
    /// </summary>
    public partial class PostOrderZolto : Page
    {
        public PostOrderZolto()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                Supplier sup = new Supplier()
                {
                    Name = TxbNameSup.Text,
                    NumberPhone = TxbPhoneSup.Text,
                    Email = TxbEmail.Text,
                    Website = TxbWebSup.Text
                };
                DBConnect.connectDB.Supplier.Add(sup);
                DBConnect.connectDB.SaveChanges();
                MessageBox.Show("Данные добавлены");
            }
            catch(Exception exp)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
