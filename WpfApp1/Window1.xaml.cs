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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void tbPosName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbPosType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
            PositionObject item = new PositionObject();
            item.PositionID = dgMain.Items.Count + 1;
            item.PositionName = tbPosName.Text;
            item.PositionType =
           (PositionType)cbPosType.SelectedItem;
            item.PositionValue = int.Parse(tbPosValue.Text);
            item.PositionPrice = double.Parse(tbPosPrice.Text);
            string[] strings =
           lbQuotes.SelectedItem.ToString().Split(' ');
            item.PriceCurrency =
           Math.Round(double.Parse(tbPosPrice.Text) /
           double.Parse(strings[0]), 2);
            dgMain.Items.Add(item);
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            cbPosType.ItemsSource =
         Enum.GetValues(typeof(PositionType));
            cbPosType.SelectedIndex = 0;
        }
        public enum PositionType
        {
            Production = 0,
            Service = 1,
            Bonus = 2
        }
        private void bQuotes_Click(object sender, RoutedEventArgs e)
        {
            lbQuotes.Items.Clear();
            lbQuotes.Items.Add("75,47 USD");
            lbQuotes.Items.Add("80,24 EUR");
            lbQuotes.Items.Add("10,88 CNY");
            lbQuotes.SelectedIndex = 0;
        }
        private void sMarkup_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lMarkup.Content = Math.Round(100 + sMarkup.Value, 2) + "%";
        }
        private void bQuotes_Click_1(object sender, RoutedEventArgs e)
        {

        }

        public class PositionObject
        {
            public int PositionID { get; set; }
            public string PositionName { get; set; }
            public PositionType PositionType { get; set; }
            public int PositionValue { get; set; }
            public double PositionPrice { get; set; }
            public double PriceCurrency { get; set; }

        }
    }
}

