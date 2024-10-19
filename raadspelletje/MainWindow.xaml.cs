using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace raadspelletje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            randomNumber = random.Next(1,100);
        }

        Random random;
        int number1;
        int randomNumber;
        int aantalPogingen = 0;
        bool geraden = false;



        private void evaluateButton_Click(object sender, RoutedEventArgs e)
        {
            
            number1 = Convert.ToInt32(numberTextBox.Text);
            if (randomNumber == number1)
            {
                output1TextBox.Text = ("Proficiat! U hebt het getal geraden!");
                geraden = false;
            }
            else if(randomNumber < number1)
            {
                output1TextBox.Text = ("Raad lager!");
                geraden = false;

            }
            else if (randomNumber > number1) {
                output1TextBox.Text = ("Raad hoger!");
                geraden = false;

            }
            if (!geraden) {

                aantalPogingen++;
                output2TextBox.Text = "Aantal keer geraden: " + $"{aantalPogingen}";
            }
            

        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            output1TextBox.Clear();
            output2TextBox.Clear();
            numberTextBox.Clear();
            aantalPogingen = 0;
            random = new Random();
            randomNumber = random.Next(1, 100);

        }

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}