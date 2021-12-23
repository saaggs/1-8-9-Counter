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

namespace Numerology
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public int soulNumber { get; set; }
        public int personalityNumber { get; set; }
        public int powerNumber { get; set; }
        public int firstNameVowelsNumber { get; set; }
        public int lastNameVowelsNumber { get; set; }
        public int firstNameConstsNumber { get; set; }
        public int lastNameConstsNumber { get; set; }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = firstNameText.Text + " " + lastNameText.Text;
        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            powerNumber = 90;
            textBlock.Text = firstNameText.Text + " " + lastNameText.Text; //"You clicked the button!";
            soulTextBlock.Text = "1";
            personalitTextBlock.Text = "8";
            powerTextBlock.Text = powerNumber.ToString();

        }

        private int calculateSoulNumber()
        { 
            return 0;
        }

        private int calculatePersonalityNumber()
        {
            return 0;
        }

        private int calculatePowerNumber()
        {
            return soulNumber + personalityNumber;
        }

        private char[] firstNameArray()
        {
            char[] charactersInFirstName = firstNameText.Text.ToCharArray();
            return charactersInFirstName;
        }

        private char[] lastNameArray()
        {
            char[] charactersInLastName = lastNameText.Text.ToCharArray();
            return charactersInLastName;
        }

        private int calculateCharNumber()
        {

            return 0;
        }
    }
}
