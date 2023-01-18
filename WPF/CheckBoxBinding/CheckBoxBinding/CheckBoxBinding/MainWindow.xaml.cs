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

namespace CheckBoxBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Item> items = new List<Item>();
        public MainWindow()
        {
            items.Add(new Item("first item"));
            items.Add(new Item("second item"));
            items.Add(new Item("third item"));
            items.Add(new Item("fourth item"));
            InitializeComponent();
            
            DataContext = this;

        }
    }
}
