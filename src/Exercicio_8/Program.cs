using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***************************************");
            Console.WriteLine("*********     Exercicio 6     *********");
            Console.WriteLine("***************************************");

            Console.WriteLine("");

            int Votos_Brancos;
            int Votos_Nulos;
            int Votos_Validos;
            int Porc_Brancos;
            int porc_nulos;
            int porc_validos;

            Console.Write("Quantos votos Brancos tiveram no municipio: ");
            Votos_Brancos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos votos Nulos tiveram no municipio: ");
            Votos_Nulos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos votos válidos tiveram no municipio: ");
            Votos_Validos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Porc_Brancos = (Votos_Brancos / 100) * 100;
            porc_nulos = (Votos_Nulos / 100) * 100;
            porc_validos = (Votos_Validos / 100) * 100;
            
            Console.WriteLine("***************************************");
                        
            Console.WriteLine($"Com base nas pesquisas {Porc_Brancos} % represemtam os votos em Branco. ");
            Console.WriteLine($"Com base nas pesquisas {porc_nulos} % represemtam os votos Nulos. ");
            Console.WriteLine($"Com base nas pesquisas {porc_validos} % represemtam os votos Válidos. ");
                       
            Console.WriteLine("***************************************");

            Console.WriteLine("");

            Console.ReadKey();



        }
    }
}
