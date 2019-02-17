using System;
namespace SwitchCaseRefactor.Asiakas
{
    public class TulostaPostiosoite
    { 
        public void Tulosta(Postiosoite osoite)
        {
            Console.WriteLine(osoite.Kadunnimi);
            Console.WriteLine(osoite.Postinumero);
            Console.WriteLine(osoite.Postitoimipaikka);
        }
    }
}
