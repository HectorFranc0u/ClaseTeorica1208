using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTeorica1208
{
    class colecciones
    {
        static void Main(string[] args)
        {
            //definir un diccionario
            Dictionary<string, string> empployeeList = new Dictionary<string, string>();
            //agregar elementos al diccionario
            empployeeList.Add("Vilma Medrano", "Director");
            empployeeList.Add("Juan Paredes", "Coordinador");
            empployeeList.Add("Diego Perdomo", "gerente");

            Dictionary<string, int> StudentsList = new Dictionary<string, int>();
            StudentsList.Add("Mercedes Concepcion", 23);
            StudentsList.Add("Jose Rusia", 17);
            StudentsList.Add("Martina Rojo", 19);

            // leer el diccionario y mostrar los datos
            foreach (KeyValuePair<string, string> employee in empployeeList)
            {
                Console.WriteLine("clave: {0}, Valor: {1}", employee.Key, employee.Value);
            }

            //ordenar los elementos del diccionario
            var dic = empployeeList.Keys.ToList();
            dic.Sort();

            Console.WriteLine("DICCIONARIO ORDENADO");
            foreach(var item in dic)
            {
                Console.WriteLine("{0}: {1}", item, empployeeList[item]);
            }

            //contar los elementos en un diccionario
            Console.WriteLine("elementos en el diccionario: {0}.", empployeeList.Count);
            Console.ReadKey();

            /*3 - Crear un diccionario con los datos de 4 familiares,
             * almacene el nombre y la edad, incluya e imprima los datos del diccionario ordenado.
             */

            Dictionary<string, int> Familiares = new Dictionary<string, int>();

            Familiares.Add("Marcelo Andres Franco Berrios", 13);
            Familiares.Add("Claudia Lissette Berrios", 43);
            Familiares.Add("Hector Balmore Franco Treminio", 41);
            Familiares.Add("Ariana Mariela Franco Berrios", 20);
            var orden = Familiares.Keys.ToList();
            orden.Sort();

            Console.WriteLine("EJERCICIO 3 - FAMILIARES ORDENADO.");
            Console.WriteLine("");
            foreach (KeyValuePair<string, int> familiar in Familiares)
            {
                Console.WriteLine("{0}, Valor: {1}", familiar.Key, familiar.Value);
            }
            Console.WriteLine("");
            foreach (var item in orden)
            {
                Console.WriteLine("{0}: {1}", item, Familiares[item]);
            }
            Console.WriteLine("");
            Console.WriteLine("NUMERO DE MIEMBROS DE LA FAMILIA: {0}.", empployeeList.Count);
            Console.ReadKey();
        }
    }
}
