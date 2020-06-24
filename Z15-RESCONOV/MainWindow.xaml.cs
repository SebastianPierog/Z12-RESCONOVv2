using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Z15_RESCONOV
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //public Model Model { get; set; } = 100;
        public Model Model { get; set; } = new Model();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Model;
        }


        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            var test = this.FindResource("Title");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Brush"] = new SolidColorBrush(Colors.CornflowerBlue);
            var res = new ResourceDictionary();
            res.Add("test", "test");
            Resources.MergedDictionaries.Add(res);
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Model.Zoom += 10;
        }
    }
}

