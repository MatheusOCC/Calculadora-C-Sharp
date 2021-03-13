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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double numero1 = 0;
        double numero2 = 0;
        string operacao = "";
        string acompanha = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if(operacao == "")
            {
                numero1 = (numero1 * 10) + 0;
                OpDisplay.Text = numero1.ToString();
                acompanha += numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 0;
                OpDisplay.Text = numero2.ToString();
                acompanha += numero2.ToString();
            }
            FullDisplay.Text = acompanha;

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 1;
                OpDisplay.Text = numero1.ToString();
                acompanha += numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 1;
                OpDisplay.Text = numero2.ToString();
                acompanha += numero2.ToString();
            }
            FullDisplay.Text = acompanha;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 2;
                OpDisplay.Text = numero1.ToString();
                acompanha += numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 2;
                OpDisplay.Text = numero2.ToString();
                acompanha += numero2.ToString();
            }
            FullDisplay.Text = acompanha;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 3;
                OpDisplay.Text = numero1.ToString();
                acompanha += numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 3;
                OpDisplay.Text = numero2.ToString();
                acompanha += numero2.ToString();
            }
            FullDisplay.Text = acompanha;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 4;
                OpDisplay.Text = numero1.ToString();
                acompanha += numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 4;
                OpDisplay.Text = numero2.ToString();
                acompanha += numero2.ToString();
            }
            FullDisplay.Text = acompanha;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 5;
                OpDisplay.Text = numero1.ToString();
                acompanha += numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 5;
                OpDisplay.Text = numero2.ToString();
                acompanha += numero2.ToString();
            }
            FullDisplay.Text = acompanha;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 6;
                OpDisplay.Text = numero1.ToString();
                acompanha += numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 6;
                OpDisplay.Text = numero2.ToString();
                acompanha += numero2.ToString();
            }
            FullDisplay.Text = acompanha;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 7;
                OpDisplay.Text = numero1.ToString();
                acompanha += numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 7;
                OpDisplay.Text = numero2.ToString();
                acompanha += numero1.ToString();
            }
            FullDisplay.Text = acompanha;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 8;
                OpDisplay.Text = numero1.ToString();
                acompanha += numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 8;
                OpDisplay.Text = numero2.ToString();
                acompanha += numero1.ToString();
            }
            FullDisplay.Text = acompanha;
        }
        
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "")
            {
                numero1 = (numero1 * 10) + 9;
                OpDisplay.Text = numero1.ToString();
                acompanha += numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 9;
                OpDisplay.Text = numero2.ToString();
                acompanha += numero2.ToString();
            }
            FullDisplay.Text = acompanha;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operacao = "";
            OpDisplay.Text = "0";
            acompanha = "";
            FullDisplay.Text = acompanha;
        }

        // Operacões

        private void btnDivisao_Click(object sender, RoutedEventArgs e)
        {
            operacao = "/";
            OpDisplay.Text = "0";
            acompanha += operacao;
            FullDisplay.Text = acompanha;
        }

        private void btnMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            operacao = "*";
            OpDisplay.Text = "0";
            acompanha += operacao;
            FullDisplay.Text = acompanha;
        }

        private void btnSubtracao_Click(object sender, RoutedEventArgs e)
        {
            operacao = "-";
            OpDisplay.Text = "0";
            acompanha += operacao;
            FullDisplay.Text = acompanha;
        }
        
        private void btnAdicao_Click(object sender, RoutedEventArgs e)
        {
            operacao = "+";
            OpDisplay.Text = "0";
            acompanha += operacao;
            FullDisplay.Text = acompanha;
        }

        private void btnPotencia_Click(object sender, RoutedEventArgs e)
        {
            operacao = "^";
            OpDisplay.Text = "0";
            acompanha += operacao;
            FullDisplay.Text = acompanha;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            switch (operacao)
            {
                case "/":
                    numero1 = numero1 / numero2;
                    OpDisplay.Text = (numero1).ToString();
                    break;

                case "*":
                    OpDisplay.Text = (numero1).ToString();
                    break;

                case "-":
                    OpDisplay.Text = (numero1 - numero2).ToString();
                    break;

                case "+":
                    OpDisplay.Text = (numero1 + numero2).ToString();
                    break;

                case "^":
                    OpDisplay.Text = (Math.Pow(numero1,numero2)).ToString();
                    break;
            }
        }
    }
}
