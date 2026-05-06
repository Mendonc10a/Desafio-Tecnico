using System;

namespace SimuladorBatalha
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome1 = "Homem de Ferro";
            int forca1 = 80, agil1 = 80, intel1 = 95, vida1 = 100;

            string nome2 = "Homem-Aranha";
            int forca2 = 85, agil2 = 95, intel2 = 80, vida2 = 90;

            Console.WriteLine("Atributos:");
            Console.WriteLine($"{nome1}: Forca:{forca1}, Agilidade:{agil1}, Inteligencia:{intel1}, Vida:{vida1}");
            Console.WriteLine($"{nome2}: Forca:{forca2}, Agilidade:{agil2}, Inteligencia:{intel2}, Vida:{vida2}");

            Console.WriteLine("\nEscolha quel regra quer usar para a batalha:");
            Console.WriteLine("1 - Regra Ofensiva ");
            Console.WriteLine("2 - Regra Estrategica ");
            Console.WriteLine("3 - Regra Resistencia ");
            Console.Write("Digite sua opcao: ");
            int opcao = int.Parse(Console.ReadLine());

            ExecutarBatalha(opcao, nome1, forca1, agil1, intel1, vida1, nome2, forca2, agil2, intel2, vida2);
        }

        static void ExecutarBatalha(int opt, string n1, int f1, int a1, int i1, int v1, string n2, int f2, int a2, int i2, int v2)
        {
            int poderFinal1 = 0;
            int poderFinal2 = 0;
            string regraNome = "";

            switch (opt)
            {
                case 1:
                    regraNome = "Regra 1 - Ofensiva";
                    poderFinal1 = f1 + a1;
                    poderFinal2 = f2 + a2;
                    break;
                case 2:
                    regraNome = "Regra 2 - Estrategica";
                    poderFinal1 = i1 * 2;  
                    poderFinal2 = i2 * 2;
                    break;
                case 3:
                    regraNome = "Regra 3 - Resistencia";
                    poderFinal1 = v1 + a1; 
                    poderFinal2 = v2 + a2;
                    break;
                default:
                    Console.WriteLine("Opcao invalida!");
                    return;
            }

            Console.WriteLine($"\nRegra escolhida: {regraNome}");
            Console.WriteLine($"{n1}: {poderFinal1} pts | {n2}: {poderFinal2} pts");

            Console.WriteLine("E o vencedor eh:");
            if (poderFinal1 > poderFinal2)
                Console.WriteLine(n1);
            else if (poderFinal2 > poderFinal1)
                Console.WriteLine(n2);
            else
                Console.WriteLine("Empate!!!");
        }
    }
}