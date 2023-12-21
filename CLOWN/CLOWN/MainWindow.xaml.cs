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

namespace CLOWN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //nameBD nameBD = new nameBD();
            //ProductsDG.ItemsSource = nameBD.nameTable.ToList();
            //CategoryDG.ItemsSource = tourspr420.nameTable.ToList();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Window_Edit win2 = new Window_Edit();
            win2.Show();
            //ProductsDG.ItemsSource = nameBD.nameTable.ToList();
            //CategoryDG.ItemsSource = nameBD.nameTable.ToList();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            //var nameSelectP = ProductsDG.SelectedItems.Cast<nameTable>().ToList();
            //var nameSelectC = CategoryDG.SelectedItems.Cast<nameTable>().ToList();
            //NameBD.GetContext().Products.RemoveRange(nameSelectP);
            //NameBD.GetContext().Category.RemoveRange(nameSelectC);
            //NameBD.GetContext.SaveChanges();
        }
    }
}
