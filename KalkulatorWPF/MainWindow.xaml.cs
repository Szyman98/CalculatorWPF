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

namespace KalkulatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operation = "";
        string output = "";
        double temp = 0;
        double final = 0;

        public MainWindow()
        {
            InitializeComponent();
            btnDivision.Content = "\u00F7";
            sqrtButton1.Content = "\u221A";
            
          
        }

        

        public void numberButton_Click(object sender, RoutedEventArgs e)
        {
            string number = ((Button)sender).Name;
            

            switch (number)
            {
                case "btn0":
                    output += "0";
                    resultbox.Text = output;
                    break;
                case "btn1":
                    output += "1";
                    resultbox.Text = output;
                    break;
                case "btn2":
                    output += "2";
                    resultbox.Text = output;
                    break;
                case "btn3":
                    output += "3";
                    resultbox.Text = output;
                    break;
                case "btn4":
                    output += "4";
                    resultbox.Text = output;
                    break;
                case "btn5":
                    output += "5";
                    resultbox.Text = output;
                    break;
                case "btn6":
                    output += "6";
                    resultbox.Text = output;
                    break;
                case "btn7":
                    output += "7";
                    resultbox.Text = output;
                    break;
                case "btn8":
                    output += "8";
                    resultbox.Text = output;
                    break;
                case "btn9":
                    output += "9";
                    resultbox.Text = output;
                    break;

                    
            }
            


        }




        public void sumButton_click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "Adding":
                    final = temp + double.Parse(output);
                    memorybox.Text += output;
                    resultbox.Text = final.ToString();
                    output = final.ToString();
                    break;
                case "Subtarction":
                    final = temp - double.Parse(output);
                    memorybox.Text += output;
                    resultbox.Text = final.ToString();
                    output = final.ToString();
                    break;
                case "Multiplication":
                    final = temp * double.Parse(output);
                    memorybox.Text += output;
                    resultbox.Text = final.ToString();
                    output = final.ToString();
                    break;
                case "Division":
                    final = temp / double.Parse(output);
                    memorybox.Text += output;
                    resultbox.Text = final.ToString();
                    output = final.ToString();
                    break;
                default:
                    MessageBox.Show("cos poszlo nie tak");
                    break;

                
            }

           
        }

        public void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "Adding";
            chceckoutput();
            memorybox.Text = temp.ToString() + "+";
           
                    }

        public void minusButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "Subtarction";
            chceckoutput();
            memorybox.Text = temp.ToString() + "-";

        }

        public void multipleButton_Click(object sender, RoutedEventArgs e)
        {

            operation = "Multiplication";
            chceckoutput();
            memorybox.Text = temp.ToString() + "*";
        }

        public void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            operation = "Division";
            chceckoutput();
            memorybox.Text = temp.ToString() + "/";

        }

        public void ClearButton(object sender, RoutedEventArgs e)
        {
            output = "";
            resultbox.Text = output;
            memorybox.Text = output;
        }

        public void sqrtButton(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = Math.Sqrt(double.Parse(output));
                resultbox.Text = temp.ToString();

                

                output = "";
            }




        }

        public void power2Button(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = Math.Pow(double.Parse(output), 2);
                resultbox.Text = temp.ToString();
                output = "";
            }


        }


        public void chceckoutput()
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";
            }

        }
    }
}
