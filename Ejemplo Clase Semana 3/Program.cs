using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clase_Semana_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaramos un arreglo de 2 dimensiones
            string[,] nombres = new string[2, 5];

            Console.WriteLine("Ingrese los 10 nombres");
            //Este for revisa las filas
            for(int i=0; i<2; i++)
            {
                //Este for revisa las columnas
                for (int j = 0; j < 5; j++)
                {
                    nombres[i,j]= Console.ReadLine();
                }
            }
            Console.WriteLine("\n\n--------------------------------------------------");
            Console.WriteLine("Impresion de los nombres con 2 ciclos For:\n");
            //Imprimir los nombres en pantalla con dos for
            for (int i = 0; i < 2; i++)
            {
                //Este for revisa las columnas
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("nombre["+i+","+j+"]: "+ nombres[i, j] + "\t");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n\n--------------------------------------------------");
            Console.WriteLine("Impresion de los nombres con Foreach:\n");
            //Imprimir los nombres con foreach
            foreach (string n in nombres)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
