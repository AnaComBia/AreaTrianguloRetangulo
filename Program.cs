using System;

namespace AreaTrianguloRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nMe informe a base do triângulo retângulo: ");
            double Base = Convert.ToDouble(Console.ReadLine());



            Console.Write("Me informe a altura do triângulo retângulo: ");
            double Altura = Convert.ToDouble(Console.ReadLine());

            double Area = Altura * Base / 2;

            Console.WriteLine($"\nA área do triângulo retângulo é: {Area}\n");

        }
    }
}
