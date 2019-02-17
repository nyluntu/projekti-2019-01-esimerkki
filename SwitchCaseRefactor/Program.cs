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

    //    string syote = "toimitustapa_id=" + toimitustapa_id + "&loppusumma=" + loppusumma + "&tilaus_status_id=" + status + "&asiakas_id=" + asiakasnumero +
    //"&tuotteet=" + tilauksen_tuotteet;

    //switch (valinta)
        //{
        //case "1":
        //    do //case 1 looppi
        //    {
        //        Console.Clear();
        //        Console.WriteLine("\nUusi varaus: \n");
        //        Console.Write("Varausnumero: ");
        //        string VarausNum = Console.ReadLine();

        //string path = (@"kansio/" + VarausNum + ".txt");

        //if (!File.Exists(path) && VarausNum != "")
        //{
        //    TextWriter wrtr = new StreamWriter(path, true);

        //string Pvm;
        //string PvmTxt = "Pvm : ";
        //string Pvm2;
        //string PvmTxt2 = "Poistumis Pvm : ";
        //string Nimi;
        //string HuoneNro;
        //string HuoneNroTxt = "Huone: ";

        //do
        //{
        //    Console.Write("Anna ensimmäinen pvm: ");
        //    // Pvm = int.Parse(Console.ReadLine());
        //    Pvm = Console.ReadLine();
        //} while (Pvm == "");
        //wrtr.WriteLine(Pvm);

        //do
        //{
        //    Console.Write("Anna viimeinen pvm: ");
        //    Pvm2 = Console.ReadLine();
        //} while (Pvm2 == "");
        //wrtr.WriteLine(Pvm2);

        //do
        //{
        //    Console.Write("anna nimi: ");
        //    Nimi = Console.ReadLine();
        //} while (Nimi == "");
        //wrtr.WriteLine("Nimi: " + Nimi);


    }
}
