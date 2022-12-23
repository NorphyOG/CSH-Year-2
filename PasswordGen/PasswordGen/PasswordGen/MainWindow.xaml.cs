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

namespace PasswordGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Gen gen = new Gen();
        private FileState fileState = new FileState();

        private int _menge = 1;
        public int Menge
        {
            get
            {
                return _menge;
            }
            set
            {
                if (value < 1)
                {
                    _menge = 1;
                }
                else
                {
                    _menge = value;
                }
            }
        }
        
        private int _launge;
        public int Launge
        {
            get
            {
                return _launge;
            }
            set
            {
                if (value < 1)
                {
                    _launge = 1;
                }
                else
                {
                    _launge = value;
                }
            }
        }

        public string abcKlein = "abcdefghijklmnopqrstuvwxyz";

        public string abcGross = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public bool abcGrossBool = false;
        
        public string nums = "0123456789";
        public bool numBool = false;

        public string sonderZeichen = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
        public bool sonderZeichenBool = false;

        public string andere = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_OnClick(object sender, RoutedEventArgs e)
        {
            string abcGString = "";
            string numsString = "";
            string sonderZeichenString = "";

            if (abcGrossBool)
            {
                abcGString = abcGross;
            }
            if (numBool)
            {
                numsString = nums;
            }
            if (sonderZeichenBool)
            {
                sonderZeichenString = sonderZeichen;
            }

            TextBox2.Text = gen.createPasswort(Launge, Menge, abcKlein, abcGString, numsString, sonderZeichenString, andere);
            
        }

        private void CheckBox1_OnChecked(object sender, RoutedEventArgs e)
        {
            sonderZeichenBool = true;
        }

        private void CheckBox1_OnUnchecked(object sender, RoutedEventArgs e)
        {
            sonderZeichenBool = false;
        }

        private void CheckBox2_OnChecked(object sender, RoutedEventArgs e)
        {
            numBool = true;
        }

        private void CheckBox2_OnUnchecked(object sender, RoutedEventArgs e)
        {
            numBool = false;
        }

        private void CheckBox3_OnChecked(object sender, RoutedEventArgs e)
        {
            abcGrossBool = true;
        }

        private void CheckBox3_OnUnchecked(object sender, RoutedEventArgs e)
        {
            abcGrossBool = false;
        }

        private void Button2_OnClick(object sender, RoutedEventArgs e)
        {
            fileState.save(TextBox5.Text, TextBox2.Text);
        }

        private void TextBox1_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Launge = Convert.ToInt32(TextBox1.Text);
                TextBox2.Text = "";
            }
            catch (Exception exception)
            {
                TextBox2.Text = "ERROR: Im Text Feld sind keine Zahlen!";
            }
        }

        private void TextBox3_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Menge = Convert.ToInt32(TextBox3.Text);
                TextBox2.Text = "";
            }
            catch (Exception exception)
            {
                TextBox2.Text = "ERROR: Im Text Feld sind keine Zahlen!";
            }
        }

        private void TextBox4_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            andere = TextBox4.Text;
        }
    }
}