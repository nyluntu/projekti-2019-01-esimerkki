using System;
namespace SwitchCaseRefactor.Asiakas
{
    public class KysyPostiosoite
    {
        public Postiosoite Kysy()
        {
            Postiosoite osoite = new Postiosoite();

            KysyKadunnimi(osoite);
            KysyPostinumero(osoite);
            KysyPostitoimipaikka(osoite);

            return osoite;
        }

        private void KysyPostitoimipaikka(Postiosoite osoite)
        {
            do
            {
                Console.Write("Anna postitoimipaikka: ");
                osoite.Postitoimipaikka = Console.ReadLine();
            } while (osoite.Postitoimipaikka == "");
        }

        private void KysyPostinumero(Postiosoite osoite)
        {
            do
            {
                Console.Write("Anna postinumero: ");
                osoite.Postinumero = Console.ReadLine();
            } while (osoite.Postinumero == "");
        }

        private void KysyKadunnimi(Postiosoite osoite)
        {
            do
            {
                Console.Write("Anna kadunnimi: ");
                osoite.Kadunnimi = Console.ReadLine();
            } while (osoite.Kadunnimi == "");
        }
    }
}
