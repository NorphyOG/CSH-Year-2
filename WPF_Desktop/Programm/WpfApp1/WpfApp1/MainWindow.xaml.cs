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

namespace WpfApp1
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
    
        /*
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            double left, top;
            left = (double) Button1.GetValue(Canvas.LeftProperty);
            top = (double) Button1.GetValue(Canvas.TopProperty);
            
            Button bn = new Button();
            bn.Content = "Button 1";
            bn.SetValue(Canvas.RightProperty, 5.0);
            bn.SetValue(Canvas.BottomProperty, 5.0);
            ca2.Children.Add(bn);

        }

        private void Button2_OnClick(object sender, RoutedEventArgs e)
        {
            Button bn = new Button();
            bn.Content = "Button 2";
            bn.SetValue(Canvas.RightProperty, 5.0);
            bn.SetValue(Canvas.BottomProperty, 5.0);
            ca1.Children.Add(bn);

        }
        */

        private void neu_Button(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}