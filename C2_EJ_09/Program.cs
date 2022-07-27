using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ej_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el valor para A: ");
            int numa = Convert.ToInt32(Console.ReadLine()); //leemos y asignamos a numa el valor de A
            Console.WriteLine("Introduzca el valor para B: ");
            int numb = Convert.ToInt32(Console.ReadLine()); //leemos y asignamos a numb el valor de B

            Console.WriteLine();
            if (numa > numb) //Si A es mayor que B
            {
                Console.WriteLine("El valor de A es mayor que B.");
            }
            else
            {
                if (numb > numa) //Si B es mayor que A
                {
                    Console.WriteLine("El valor de B es mayor que A.");
                }
                else //Si A no es mayor que B y B no es mayor que A solo queda que sean iguales
                    Console.WriteLine("El valor de A es igual que el de B.");
            }
        }
    }
}