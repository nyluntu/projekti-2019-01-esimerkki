﻿using System;
using SwitchCaseRefactor.Asiakas;

namespace SwitchCaseRefactor.Toiminnot
{
    public class EnsimmainenToiminto : MenuToiminto
    {
        public EnsimmainenToiminto()
        {
            this.Komento = "1";
            this.KomennonKuvaus = "Asiakas";
        }

        public override void Suorita()
        {
            Console.Clear();
            Console.WriteLine("Valinta 01");

            string valinta = Console.ReadLine();

            while (!valinta.StartsWith("0", StringComparison.Ordinal))
            {
                Console.WriteLine("Anna komento 1 tai 2. Muu komento poistuu ohjelmasta\\n");
 
                valinta = Console.ReadLine();
                bool poistu = false;

                switch (valinta)
                {
                    case "1":
                        Console.WriteLine("Valinta 01.01");

                        KysyPostiosoite kysyPostiosoite = new KysyPostiosoite();
                        Postiosoite osoite = kysyPostiosoite.Kysy(); 

                        TulostaPostiosoite tulostaja = new TulostaPostiosoite();
                        tulostaja.Tulosta(osoite);

                        break;
                    case "2":
                        Console.WriteLine("Valinta 01.02");
                        break;
                    default:
                        Console.WriteLine("Poistuttu 01");
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
