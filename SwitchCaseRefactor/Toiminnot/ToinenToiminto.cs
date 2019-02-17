using System;
namespace SwitchCaseRefactor.Toiminnot
{
    public class ToinenToiminto : MenuToiminto
    {
        public ToinenToiminto()
        {
            this.Komento = "2";
            this.KomennonKuvaus = "Kauppias";
        }

        public override void Suorita()
        {
            Console.WriteLine("Valinta 02");

            string valinta = Console.ReadLine();

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
        }
    }
}
