using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte id;
            byte sl;

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Seu id: ");

            id = byte.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas trabalhou no mês:  ");

            sl = byte.Parse(Console.ReadLine());

            Console.WriteLine(salario.ToString("F2", CultureInfo.InvariantCulture));            

            Console.WriteLine("Seu salario é" + (id * sl) * 2);

            //Console.Write(pontoFlutuante.ToString("F2", CultureInfo.InvariantCulture));
            
            
            Console.ReadLine();
        }
    }
}
