using System; 
using System.Collections.Generic;
namespace ManejoDeArreglos3
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> Lista = new List<int>();
            Variables.Array2 = new int[6];
            Variables.var_conta = 0;
            Variables.var_num = new Random();
            for (int f = 0; f < 6; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Variables.var_conta = Variables.var_num.Next(2, 9);
                    Console.Write(" " + Variables.var_conta);
                    if (f == c) Lista.Add(Variables.var_conta);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            for (int f = 0; f < Lista.Count; f++)
            {
                Console.Write(" " + Lista[f]);
            }
            Console.WriteLine("\n Presione cualquier tecla para SALIR");
            Console.ReadKey();

        }
    }
} 