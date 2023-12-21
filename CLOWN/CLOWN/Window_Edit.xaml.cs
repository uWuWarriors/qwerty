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
using System.Windows.Shapes;

namespace CLOWN
{
    /// <summary>
    /// Логика взаимодействия для Window_Edit.xaml
    /// </summary>
    public partial class Window_Edit : Window
    {
        //private  _current = new Hote();
        public Window_Edit()
        {
            InitializeComponent();
            //nameBD nameBD = new nameBD();
            //if (selected != null)
            //    _current = selectedHotel;
            //DataContext = _current;
          
        }
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var my = Test.Text;
        }
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            //TourBaseEntities.GetContext().Hotels.Add(my);
            //tourspr420Entities.GetContext().SaveChanges();
        }
    }
}
