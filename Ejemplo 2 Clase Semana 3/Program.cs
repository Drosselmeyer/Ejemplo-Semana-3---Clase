using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2_Clase_Semana_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos la lista de colores
            List<string> colores = new List<string>();
            int cantidad = 0;

            //Agregamos colores quemados
            colores.Add("Azul");
            colores.Add("Cian");
            colores.Add("Lila");

            //Solicitamos al usuario cuantos colores desea agregar y a continuacion los colores
            Console.WriteLine("Ingrese la cantidad de colores que desea ingresar");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los colores, separados por un enter");
            //Solicitamos los colores a agregar
            for(int i=0; i< cantidad; i++)
            {
                colores.Add(Console.ReadLine());
            }

            Console.WriteLine("Imprimimos los colores");
            //Imprimimos los colores
            foreach(string c in colores)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
