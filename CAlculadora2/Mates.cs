using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Mates
    {

        public Mates(List<char> operadores, double[] valores)   //Constructor por defecto
        {
            this.operadores = operadores;
            _valores = valores;
        }

        public double Resolver()
        {
            short j = 0;    //Variable short que sirve para recorrer las posiciones dentro de _valores

            foreach (char i in operadores)  //Filtro para operar primero las multiplicaciones y divisiones
            {
                if (i == '*' || i == '/') FormulaIf(i, j);
                j++;
            }

            j = 0;
            char aux = '+';
            foreach (char i in operadores)  //Filtro para operar solo las sumas y restas
            {
                if (i == '+' || i == '-')
                {
                    aux = i;
                    FormulaIf(i, j);
                }
                else if (i == '*' || i == '/')
                {
                    if (aux == '-') _valores[j] -= _valores[j + 1];
                    else _valores[j] += _valores[j + 1];
                    _valores[j + 1] = _valores[j];
                }
                j++;
            }

            resultadofinal = _valores[j];
            return resultadofinal;
        }

        private void FormulaIf(char i, short j)
        {
            switch (i)
            {
                case '*':
                    _valores[j] *= _valores[j + 1];
                    break;
                case '/':
                    _valores[j] /= _valores[j + 1];
                    break;
                case '+':
                    _valores[j] += _valores[j + 1];
                    break;
                case '-':
                    _valores[j] -= _valores[j + 1];
                    break;
            }
            _valores[j + 1] = _valores[j];
            _valores[j] = 0;
        }

        private double resultadofinal = 0;
        private List<char> operadores;
        private double[] _valores;
    }
}