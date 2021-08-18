using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3_Clase_Semana_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos el dictionario
            Dictionary<string, string> empleado = new Dictionary<string, string>();
            string busqueda;

            //Agregamos al diccionario su llave con el que lo llamare
            //y su valor guardado
            empleado.Add("Contador", "Kevin Garcia");
            empleado.Add("Desarrolladora", "Vanessa Melendez");
            empleado.Add("Jefe de ventas", "Xochilt Rivera");

            //Imprimimos cada uno de los nombres
            Console.WriteLine("Imprimimos todos los valores");
            foreach (string nom in empleado.Values)
            {
                Console.WriteLine(nom);
            }

            //Solicitamos a cliente un key para buscar
            Console.WriteLine("Ingrese el puesto que desea obtener el nombre");
            busqueda = Console.ReadLine();

            Console.WriteLine("El valor solicitado es: " + empleado.ContainsKey(busqueda));
            
            //Solicitamos al cliente que busque un nombre
            Console.WriteLine("Ingrese el nombre que desea buscar");
            busqueda = Console.ReadLine();

            Console.WriteLine("El valor solicitado es: " + empleado.ContainsValue(busqueda));

            Console.ReadKey();
        }
    }
}
