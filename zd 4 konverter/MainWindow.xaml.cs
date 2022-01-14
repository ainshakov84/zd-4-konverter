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

namespace zd_4_konverter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double ratedollar=Convert.ToDouble(rate.Text);
            double sumdollar=Convert.ToDouble(sum.Text);
            double resDollar = ratedollar * sumdollar;
            resSum.Text= resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateevro1 = Convert.ToDouble(rateevro.Text);
            double sumevro1 = Convert.ToDouble(sumevro.Text);
            double resevro = rateevro1 * sumevro1;
            resSumevro.Text = resevro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateevro2 = Convert.ToDouble(ratrubdollar.Text);
            double sumevro2 = Convert.ToDouble(sumrubdollar.Text);
            double resevro =  sumevro2/ rateevro2 ;
            resSumrubdollar.Text = resevro.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateevro2 = Convert.ToDouble(ratevrorub.Text);
            double sumevro2 = Convert.ToDouble(sumevrorub.Text);
            double resevro = sumevro2 / rateevro2;
            resSumevrorub.Text = resevro.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double dim1 = Convert.ToDouble(dim.Text);
                       double sumdim = dim1 / 39.37;
            resDim.Text = sumdim.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double fut1 = Convert.ToDouble(fut.Text);
            double sumfut = fut1 / 3.28;
            resFut.Text = sumfut.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double mil1 = Convert.ToDouble(mil.Text);
            double summil = mil1 * 1609.34;
            resMil.Text = summil.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double ver1 = Convert.ToDouble(ver.Text);
            double sumver = ver1 * 1066.8;
            resVer.Text = sumver.ToString();
        }
    }
}
