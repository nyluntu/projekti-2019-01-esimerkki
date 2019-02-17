using System;

namespace SwitchCaseRefactor
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Anna komento ja valitse kuka olet? Kirjoita numero\n1. Asiakas\n2. Kauppias\n0. Lopetus\n");

            string valinta = Console.ReadLine();

            switch (valinta)
            {
                case "1": 
                    Console.Clear();
                    Console.WriteLine("Valinta 01");

                    while (!valinta.StartsWith("0", StringComparison.Ordinal))
                    {
                        Console.WriteLine("Anna komento 1 tai 2. Muu komento poistuu ohjelmasta\n");
                        valinta = Console.ReadLine();
                        bool poistu = false;

                        switch (valinta) 
                        {
                            case "1": 
                                Console.WriteLine("Valinta 01.01");
                                break;
                            case "2":
                                Console.WriteLine("Valinta 01.02");
                                break;
                            default:
                                Console.WriteLine("Poistuttu 01");
                                poistu = true;
                                break;
                        }

                        if(poistu)
                        {
                            break;
                        }
                    }
                    break;
                case "2": 
                    Console.WriteLine("Valinta 02");

                    while (!valinta.StartsWith("0", StringComparison.Ordinal))
                    {
                        Console.WriteLine("Anna komento 1. Muu komento poistuu ohjelmasta\n");
                        valinta = Console.ReadLine();
                        bool poistu = false;

                        switch (valinta)
                        {
                            case "1":
                                Console.WriteLine("Valinta 02.01");
                                break;
                            default:
                                Console.WriteLine("Poistuttu 02");
                                poistu = true;
                                break;
                        }

                        if (poistu)
                        {
                            break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Poistuttu pääohjelmasta");
                    break;
            }
        }

    }
}
