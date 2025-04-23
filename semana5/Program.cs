using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/hallar la suma de los primeros n numeros naturales
            int n , suma;
            Console.WriteLine("ingrese el numero de elementos: ");
            n = int.Parse(Console.ReadLine());
            // si n = 6
            // 1+2+3+4+5+6
            suma = 0;
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine("------Inyteraccion " + i;
                Suma = suma + i * i;
                

            }
            Console.Write("la suma es: " + suma);
            Console.ReadKey();
            */

            /*// Hallar la suma de los cubos en los n numeros naturales
            int n, sumacubos;
            Console.WriteLine("Numero de elementos: ");
            n = int.Parse(Console.ReadLine());

            sumacubos = 0;

            for (int i = 1; i <= n; i++) ;// increemento de uno en uno
            {
                sumacubos = sumacubos + (i * i * i);
            }
            Console.WriteLine("La suma de los cuadrados es: " + sumacubos);
            */

            /* // Hallar la suma de los n primeros numeros naturales pares
             int n1, sumapares;
             Console.WriteLine("Ingrese numeros de los elementos: ");
             n1 = int.Parse(Console.ReadLine());
             sumapares = 0;

             for (int i = 1; i <= n1; i ++1) ;
             {
                 Console.WriteLine("hola");
            */
            /*//mostrar los numeros
            //del 1 al 10
            int n;
            Console.WriteLine("Ingrese numeros del 1 al 10");


            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i);
            */
            {
                
                int num;
                int suma=0;
                Console.WriteLine("Ingrese numero: ");
                num = int.Parse(Console.ReadLine());

                for (int x = 1; x < num; x++) 
                {
                    //mod => %
                    if (num % x == 0)
                    {
                        //aqui
                        //Console.WriteLine(x);
                        suma = suma + x;
                    }
                    Console.WriteLine("suma:"+ suma);
                    if (num==suma)
                    {
                        Console.WriteLine("si es perfecto");

                    }
                    else
                    {
                        Console.WriteLine("No es perfecto");
                    }
                }
            

            


            }
        }
       
        


        }
    }


