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

namespace WpfAppProject2
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

        private void CaLcUlAtE_Click(object sender, RoutedEventArgs e)
        {
            int income = int.Parse(InCoMe.Text);
            int expenses = int.Parse(ExPeNsEs.Text);
            int priceofthing = int.Parse(Price_of_thing.Text);


            if (income > expenses)
            {
               int day = priceofthing / (income - expenses);

                ReSuLt.Text = day.ToString();
              }
            else if (income < expenses)
            {
                MessageBox.Show("จำนวนเงินของคุณไม่พอ รายจ่ายของคุณมีมากกว่ารายรับ");
            }
            else if (income == expenses)
            {
                MessageBox.Show("จำนวนเงินของคุณมีเท่ากันกับรายจ่าย คุณไม่มีเงินที่จะเก็บออมได้");                  
            }

        }
    }
}
