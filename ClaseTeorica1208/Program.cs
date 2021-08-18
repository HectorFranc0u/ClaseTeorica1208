using System;

namespace ClaseTeorica1208
{
    class Program
    {
        static void Main(string[] args)
        {
            loops();
            Console.ReadLine();

        }

        //bucles
        public static void loops()
        {
            /* 1- escribir un ciclo que permita capturar los valores 
            * a almacenar en el arreglo de numbers con un tamano de 10.
            * 2 - Calcular el promedio de los numeros almacenados en el array.
            */

            int prom = 0;
            int[] numbers = new int[10];
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("ingresar el valor del elemento {0}: ", a);
                numbers[a] = Convert.ToInt32(Console.ReadLine());
            }    
            //ciclo while
            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON WHILE.");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }


            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int c = 0;
            do
            {
                Console.WriteLine(numbers[c]);
                c++;
            } while (c < numbers.Length);

            Console.WriteLine("IMPRIME CICLOS CON FOR - ARREGLO ORDENADO.");
            Array.Sort(numbers);
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
                prom = prom + numbers[j];
            }


            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH - ARREGLO EN INVERTIDO");
            Array.Reverse(numbers);
            foreach(int item  in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(prom);
            Console.WriteLine("EL PROMEDIO ES: {0};", (prom / (numbers.Length)));
        }
    }
}
