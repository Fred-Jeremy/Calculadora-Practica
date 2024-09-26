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
            //if (operacionStrg.Contains(".")) operacionStrg = operacionStrg.Replace(".", ",");     //Sin función actual

            if (operacionStrg.Contains("x")) operacionStrg = operacionStrg.Replace("x", "*");       
            //Cambia caracter 'x' por '*' para su interpretación al operar

            AnadirOperadores(operacionStrg);

            AnadirValores(operacionStrg);

            Mates mate = new Mates(operador, _valores);     //Crea el objeto mate para realizar el calculo
            string resultado = "" + mate.Resolver();        //Llamar a la función Resolver de la clase Mates

            return resultado;
        }

        private static void AnadirOperadores(string operacionStrg)      //Crea una lista de caracteres con los operadores
        {
            operador.Clear();       //Limpia la lista de caracteres para evitar errores al calcular
            for (int i = 0; i < operacionStrg.Length; i++)
            {
                char aux = operacionStrg.ToCharArray()[i];
                if (aux == '+' || aux == '-' || aux == '*' || aux == '/') operador.Add(aux);
            }
        }

        private static void AnadirValores(string operacionStrg)         //Crea un array con los números incluídos en operacionStrg
        {
            char[] nonum = { '+', '-', '*', '/', ' ' };     //Array para filtrar y borrar los operadores de operacionStrg
            string[] numerosStr = operacionStrg.Split(nonum);
            for (int i = 0; i < numerosStr.Length; i++) _valores[i] = Double.Parse(numerosStr[i]);
        }

        private static List<char> operador = new List<char>();
        private static double[] _valores = new double[20];
    }
}