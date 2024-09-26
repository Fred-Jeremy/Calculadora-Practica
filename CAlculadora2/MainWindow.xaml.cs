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
using Calculadora;

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Boton0(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "0";
        }

        private void Boton1(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "1";
        }

        private void Boton2(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "2";
        }

        private void Boton3(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "3";
        }

        private void Boton4(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "4";
        }

        private void Boton5(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "5";
        }

        private void Boton6(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "6";
        }

        private void Boton7(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "7";
        }

        private void Boton8(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "8";
        }

        private void Boton9(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "9";
        }



        private void BotonPor(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "x";
        }

        private void BotonMenos(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "-";
        }

        private void BotonMas(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "+";
        }

        private void Botondiv(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = PantallaOutput.Text + "/";
        }

        private void BotonC(object sender, RoutedEventArgs e)
        {
            PantallaOutput.Text = "";
        }

        private void BotonIgual(object sender, RoutedEventArgs e)
        {
            Operacion operador = new Operacion();
            PantallaOutput.Text = operador.Operar(PantallaOutput.Text);
        }
    }
}