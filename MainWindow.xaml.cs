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

namespace squadExpression
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
                                           double a ,b,c, D;
            if (double.TryParse(tbA.Text, out a) && double.TryParse(tbB.Text, out b) 
         && double.TryParse(tbC.Text, out c)){if (a == 0) {if (b == 0){if (c == 0) resultBox.
      Text = "Бесконечное множество решений";else resultBox.Text = "Нет решений фф"; } else resultBox
     .Text = "x1: " + (-c / b).ToString();}else{ D = Math.Pow(b, 2) - 4 * a * c;if (D >= 0){resultBox
      .Text = "x1: " + (-b + Math.Sqrt(D)) / (2 * a) + "\n" + "x2: " + (-b - Math.Sqrt(D)) / (2 * a);
           return;}else if (D == 0) { resultBox.Text = "x1: " + (-b / (2 * a));}else if (D < 0) {
             resultBox.Text = "Нет решений";}}} else MessageBox.Show("Во всех полях должны быть " +
                 "числа!", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);}
                                private void bClose_Click(object sender, 
                                         RoutedEventArgs e)
                                                {
            Application.Current.Shutdown();
        }

        private void bHide_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
