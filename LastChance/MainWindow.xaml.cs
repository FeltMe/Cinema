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

namespace LastChance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Random rnd = new Random();
        protected int OneTicketValue = 5;
        protected int TotalValue = 0;
        protected Button[] list_buttons = new Button[30];
        //protected Image[] List_image
 
        public MainWindow()
        { 
            InitializeComponent();
            Lb1.FontStyle = FontStyles.Italic;
            Lb1.FontSize = 20;
            for (ushort i = 0; i < 30; i++)
            {
                Button temp = new Button();
                list_buttons[i] = Buttons_grid.Children[i] as Button;
            }
            for (ushort j = 0; j < 7; j++)
            {
                int temp = rnd.Next(0, 30);
                //list_but[temp].IsEnabled = false;
                list_buttons[temp].Background = Brushes.Red;
            }

        }
        private void Bt1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (bt1.Background != Brushes.LightGray && bt1.Background != Brushes.Red)
            {
                bt1.Background = Brushes.LightGray;
                TotalValue -= OneTicketValue;
                Lb1.Content = $"{TotalValue} $";
            }
        }
        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            if (bt1.Background != Brushes.Green && bt1.Background != Brushes.Red)
            {
                bt1.Background = Brushes.Green;
                TotalValue += OneTicketValue;
                Lb1.Content = $"{TotalValue} $";
            }
        }

        private void Bt30_Click(object sender, RoutedEventArgs e)
        {
            bt30.Background = Brushes.Green;

        }

        private void Bt2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            bt2.Background = Brushes.Green;

        }

        private void Bt3_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            bt3.Background = Brushes.Green;

        }

        private void Bt4_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt4_Click(object sender, RoutedEventArgs e)
        {
            bt4.Background = Brushes.Green;

        }

        private void Bt5_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt5_Click(object sender, RoutedEventArgs e)
        {
            bt5.Background = Brushes.Green;

        }

        private void Bt6_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt6_Click(object sender, RoutedEventArgs e)
        {
            bt6.Background = Brushes.Green;

        }

        private void Bt7_Click(object sender, RoutedEventArgs e)
        {
            bt7.Background = Brushes.Green;

        }

        private void Bt7_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt8_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt8_Click(object sender, RoutedEventArgs e)
        {
            bt8.Background = Brushes.Green;

        }

        private void Bt9_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt9_Click(object sender, RoutedEventArgs e)
        {
            bt9.Background = Brushes.Green;

        }

        private void Bt10_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt10_Click(object sender, RoutedEventArgs e)
        {
            bt10.Background = Brushes.Green;

        }

        private void Bt11_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt11_Click(object sender, RoutedEventArgs e)
        {
            bt11.Background = Brushes.Green;

        }

        private void Bt12_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt12_Click(object sender, RoutedEventArgs e)
        {
            bt12.Background = Brushes.Green;

        }

        private void Bt13_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt13_Click(object sender, RoutedEventArgs e)
        {
            bt13.Background = Brushes.Green;

        }

        private void Bt14_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt14_Click(object sender, RoutedEventArgs e)
        {
            bt14.Background = Brushes.Green;

        }

        private void Bt15_Click(object sender, RoutedEventArgs e)
        {
            bt15.Background = Brushes.Green;

        }

        private void Bt15_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt16_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt16_Click(object sender, RoutedEventArgs e)
        {
            bt16.Background = Brushes.Green;

        }

        private void Bt17_Click(object sender, RoutedEventArgs e)
        {
            bt17.Background = Brushes.Green;

        }

        private void Bt17_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt18_Click(object sender, RoutedEventArgs e)
        {
            bt18.Background = Brushes.Green;

        }

        private void Bt18_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt19_Click(object sender, RoutedEventArgs e)
        {
            bt19.Background = Brushes.Green;

        }

        private void Bt19_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt20_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt20_Click(object sender, RoutedEventArgs e)
        {
            bt20.Background = Brushes.Green;

        }

        private void Bt21_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt21_Click(object sender, RoutedEventArgs e)
        {
            bt21.Background = Brushes.Green;

        }

        private void Bt22_Click(object sender, RoutedEventArgs e)
        {
            bt22.Background = Brushes.Green;

        }

        private void Bt22_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt23_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt23_Click(object sender, RoutedEventArgs e)
        {
            bt23.Background = Brushes.Green;

        }

        private void Bt24_Click(object sender, RoutedEventArgs e)
        {
            bt24.Background = Brushes.Green;

        }

        private void Bt24_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt25_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt25_Click(object sender, RoutedEventArgs e)
        {
            bt25.Background = Brushes.Green;

        }

        private void Bt26_Click(object sender, RoutedEventArgs e)
        {
            bt26.Background = Brushes.Green;

        }

        private void Bt26_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt27_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt27_Click(object sender, RoutedEventArgs e)
        {
            bt27.Background = Brushes.Green;

        }

        private void Bt28_Click(object sender, RoutedEventArgs e)
        {
            bt28.Background = Brushes.Green;

        }

        private void Bt28_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt29_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Bt29_Click(object sender, RoutedEventArgs e)
        {
            bt29.Background = Brushes.Green;

        }

        private void Bt30_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
