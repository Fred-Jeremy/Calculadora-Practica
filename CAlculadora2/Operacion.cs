using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacion
    {
        public string Operar(string operacionStrg)
        {

            string input = operacionStrg;

            if (input.Contains(".")) input = input.Replace(".", ",");
            if (input.Contains("x")) input = input.Replace("x", "*");

            AnadirOperadores(input);
            AnadirValores(input);

            Mates mate = new Mates(operador, _valores);
            string resultado = "" + mate.Resolver();

            return resultado;
        }

        //----------------------------------------------------------------------------

        private static void AnadirOperadores(string input)
        {
            operador.Clear();
            for (int i = 0; i < input.Length; i++)
            {
                char aux = input.ToCharArray()[i];
                if (aux == '+' || aux == '-' || aux == '*' || aux == '/') operador.Add(aux);
            }
        }

        private static void AnadirValores(string input)
        {
            char[] nonum = { '+', '-', '*', '/', ' ' };
            string[] numerosStr = input.Split(nonum);
            for (int i = 0; i < numerosStr.Length; i++) _valores[i] = Double.Parse(numerosStr[i]);
        }

        private static List<char> operador = new List<char>();
        private static double[] _valores = new double[20];
    }
}
