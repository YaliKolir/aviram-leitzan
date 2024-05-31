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

namespace FirstWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void countryBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = this.countryBox.SelectedItem as ComboBoxItem;
            switch (selectedItem.Content.ToString().ToLower())
            {
                case "italy":
                    this.border1.Visibility = Visibility.Visible;
                    this.border2.Visibility = Visibility.Collapsed;
                    this.rec1.Fill = new SolidColorBrush(Colors.Green);
                    this.rec2.Fill = new SolidColorBrush(Colors.White);
                    this.rec3.Fill = new SolidColorBrush(Colors.Red);
                    break;

                case "france":
                    this.border1.Visibility = Visibility.Visible;
                    this.border2.Visibility = Visibility.Collapsed;
                    this.rec1.Fill = new SolidColorBrush(Colors.Blue);
                    this.rec2.Fill = new SolidColorBrush(Colors.White);
                    this.rec3.Fill = new SolidColorBrush(Colors.Red);
                    break;

                case "belgium":
                    this.border1.Visibility = Visibility.Visible;
                    this.border2.Visibility = Visibility.Collapsed;
                    this.rec1.Fill = new SolidColorBrush(Colors.Black);
                    this.rec2.Fill = new SolidColorBrush(Colors.Yellow);
                    this.rec3.Fill = new SolidColorBrush(Colors.Red);
                    break;

                case "germany":
                    this.border1.Visibility = Visibility.Collapsed;
                    this.border2.Visibility = Visibility.Visible;
                    this.rec4.Fill = new SolidColorBrush(Colors.Black);
                    this.rec5.Fill = new SolidColorBrush(Colors.Red);
                    this.rec6.Fill = new SolidColorBrush(Colors.Yellow);
                    break;

                case "austria":
                    this.border1.Visibility = Visibility.Collapsed;
                    this.border2.Visibility = Visibility.Visible;
                    this.rec4.Fill = new SolidColorBrush(Colors.Red);
                    this.rec5.Fill = new SolidColorBrush(Colors.White);
                    this.rec6.Fill = new SolidColorBrush(Colors.Red);
                    break;
            }
        }
    }
}
