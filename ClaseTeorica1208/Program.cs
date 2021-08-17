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
            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 8;
            numbers[2] = 10;

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

            Console.WriteLine("IMPRIME CICLOS CON FOR");
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH");
            foreach(int item  in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
