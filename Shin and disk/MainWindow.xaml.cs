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
using Shin_and_disk.Models;

namespace ShinAndDisk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Core bd = new Core();
        List<Product> arrprod;
        public MainWindow()
        {
            InitializeComponent();
            arrprod = bd.context.Product.ToList();
            ServiceListView.ItemsSource = arrprod;

        }
    }
}
