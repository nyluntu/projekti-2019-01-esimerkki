using System;
using System.Collections.Generic;
using System.Linq;
using SwitchCaseRefactor.Toiminnot;

namespace SwitchCaseRefactor
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            List<MenuToiminto> toiminnot = new List<MenuToiminto>();
            toiminnot.Add(new EnsimmainenToiminto());
            toiminnot.Add(new ToinenToiminto());
            toiminnot.Add(new KolmasToiminto());

            // Pääohjelman toistolauseke
            bool toistaOhjelmaa = true;
            do
            {
                TulostaToiminnot(toiminnot);

                string kayttajanSyote = Console.ReadLine();

                MenuToiminto loytynytToiminto = toiminnot.FirstOrDefault(t => t.Komento.Equals(kayttajanSyote));

                if (loytynytToiminto != null)
                {
                    loytynytToiminto.Suorita();
                }
                else
                {
                    Console.WriteLine("Komentoa ei löytynyt.");
                    toistaOhjelmaa = false;
                }
            } while (toistaOhjelmaa);

        }

        private static void TulostaToiminnot(List<MenuToiminto> toiminnot)
        {
            Console.Clear();
            Console.WriteLine("Valitse komento antamalla haluttu komento:\n");
            Console.WriteLine("Komento\t\tKuvaus");
            foreach (MenuToiminto toiminto in toiminnot)
            {
                Console.WriteLine($"{toiminto.Komento}\t\t{toiminto.KomennonKuvaus}");
            }
        }
    }
}
