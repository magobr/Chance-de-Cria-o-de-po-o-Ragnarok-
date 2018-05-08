using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caucula_Sorte
{
    class Program
    {
        static void Main(string[] args)
        {

            /*pp - Pesquisa de poçoes
              PR - Preparar Poçoes
              MP - Mudança de Planos
              NC - Nivel de classe
              DZ - Destreza
              ST - Sorte
              IT - Inteligencia
             */

            Console.WriteLine("\t\t***Bem Vindo a calculadora de poções***\n\n");

            double PP, PR, MP, NC, DZ, ST, IT, dificuldade = 1, chance; 
            string txt;

            Console.Write("Digite o Grupo de Poções:\n" +
                "1 - Poção Vermelha, Poção Amarela, Poção Branca.\n" +
                "2 - Álcool.\n" +
                "3 - Frasco de Ácido, Frasco de Esfera Marinha, Frasco de Fogo Grego, Frasco de Planta Carnívora.\n" +
                "4 - Poção Azul, Analgésico, Aloe Vera, Embrião, Poções Anti-Propriedade, Poção Compacta Vermelha.\n" +
                "5 - Poção Compacta Amarela.\n" +
                "6 - Poção Compacta Branca, Frasco de Revestimento.\n");
            txt = Console.ReadLine();
            dificuldade = Convert.ToInt32(txt);
            
            

            switch (dificuldade)
            {
                case 1:
                    Console.WriteLine("Poção Vermelha, Poção Amarela, Poção Branca");
                    dificuldade = 0.2;
                    break;

                case 2:
                    Console.WriteLine("Poção Vermelha, Poção Amarela, Poção Branca");
                    dificuldade = 0.1;
                    break;

                case 3:
                    Console.WriteLine("Poção Vermelha, Poção Amarela, Poção Branca");
                    dificuldade = 0;
                    break;

                case 4:
                    Console.WriteLine("Poção Vermelha, Poção Amarela, Poção Branca");
                    dificuldade = -0.05;
                    break;

                case 5:
                    Console.WriteLine("Poção Vermelha, Poção Amarela, Poção Branca");
                    dificuldade = -0.07;
                    break;

                case 6:
                    Console.WriteLine("Poção Vermelha, Poção Amarela, Poção Branca");
                    dificuldade = -0.1;
                    break;

            }



            Console.Write("Digite Seu nivel de Pesquisa de Poções: ");
            txt = Console.ReadLine();
            PP = Convert.ToDouble(txt);

            if (PP <= 10)
            {
                Console.WriteLine(PP);
            }
            else
                Console.WriteLine("Reinicie o Programa");


            Console.Write("Digite Seu nivel de Preparo de Poções: ");
            txt = Console.ReadLine();
            PR = Convert.ToDouble(txt);

            if (PR <= 10)
            {
                Console.WriteLine(PR);
            }
            else
                Console.WriteLine("Reinicie o Programa");


            Console.Write("Digite Seu nivel de Mudança de Planos: ");
            txt = Console.ReadLine();
            MP = Convert.ToDouble(txt);

            if (MP <= 5)
            {
                Console.WriteLine(MP);
            }
            else
                Console.WriteLine("Reinicie o Programa");


            Console.Write("Digite Seu nivel de Classe: ");
            txt = Console.ReadLine();
            NC = Convert.ToDouble(txt);

            if (NC <= 70)
            {
                Console.WriteLine(NC);
            }
            else
                Console.WriteLine("Reinicie o Programa");


            Console.Write("Digite Seu nivel de Destreza: ");
            txt = Console.ReadLine();
            DZ = Convert.ToDouble(txt);

            Console.WriteLine(DZ);
          
            Console.Write("Digite Seu nivel de Sorte: ");
            txt = Console.ReadLine();
            ST = Convert.ToDouble(txt);
            
            Console.WriteLine(ST);
          


            Console.Write("Digite Seu nivel de Inteligência: ");
            txt = Console.ReadLine();
            IT = Convert.ToDouble(txt);

            Console.WriteLine(IT);

            chance = ((PP) + (PR * 3) + (MP) + (NC * 0.2) + (DZ * 0.1) + (ST * 0.1) + (IT * 0.05) + (dificuldade));

            Console.WriteLine("Sua Chance é de : {0}%", chance);


            Console.ReadKey();
        }
    }
}
