using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDioDotnetETDD
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string _data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            _data = data;
        }

        public int Somar(int num1, int num2)
        {
            listaHistorico.Insert(0, $"Soma: {num1} + {num2} = {num1 + num2} - data: {_data}");
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            listaHistorico.Insert(0, $"Subtração: {num1} - {num2} = {num1 - num2} - data: {_data}");
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            listaHistorico.Insert(0, $"Multiplicação: {num1} * {num2} = {num1 * num2} - data: {_data}");
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            listaHistorico.Insert(0, $"Divisão: {num1} / {num2} = {num1 / num2} - data: {_data}");
            return num1 / num2;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
