namespace SwitchCaseRefactor.Asiakas
{
    public class Postiosoite
    {
        public Postiosoite()
        {
        }

        public string Kadunnimi { get; set; }
        public string Postinumero { get; set; }
        public string Postitoimipaikka { get; set; }


        public bool TarkistaOikeellisuus()
        {
            // Tarkistaa ovatko tiedot sallittuja.

            return true;
        }
    }
}
