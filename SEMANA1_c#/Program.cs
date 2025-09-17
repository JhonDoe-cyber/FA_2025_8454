using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer5();
            Console.ReadKey();
        }
        static void ejer1()
        {
            String nombre, carrera;

            Console.Write("Ingresar su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresar su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso de FA de la carrera {carrera}"); //declaramos variables
        }
        static void ejer2()
        {
            Console.Write("\"Krisstel\"");
        }
        static void ejer3()
        {
            Console.Write("Ingrese número 1 :");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número 2 :");
            int num2 = int.Parse(Console.ReadLine());

            double divi = (double)num1 / (double)num2;

            Console.WriteLine("Suma: " + (num1 + num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicación: " + (num1 * num2));
            Console.WriteLine("Divición: " + divi);
        }
        static void ejer4()
        {

            Console.Write("Ingrese un numero decimal: ");
            double num= double.Parse(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            double redo = Math.Round(num,0); //el 0 hacer referenciaa cuantos decimales quiero, escojo a mi gusto
            double cubo = Math.Pow(num, 3); //el 3 viene ser el exponente
            double raiz3 = Math.Pow(num, 1/3d);  //raiz cubica de 3 (cambia a custo la raiz de 3 a otro la "d" es para redondearlo a entero)

            Console.WriteLine("\nRaiz 2: " + raiz2);
            Console.WriteLine("Redondeado: " + redo);
            Console.WriteLine("Al cubo: " +cubo);
            Console.WriteLine("Raiz cubica: " + raiz3);
        }
        static void ejer5()
        {
            Console.Write("Ingrese un número: ");
            string num= Console.ReadLine();

            int entero = int.Parse(num);
            double deci= double.Parse(num);

            Console.WriteLine("\nResto: "+(entero % 2));
            Console.WriteLine("Dividido 3: " + (deci / 3));

        }
        static void ejer6()
        {

        }

    }
}
