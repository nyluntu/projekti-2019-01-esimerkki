using System;

namespace SwitchCaseRefactor.Toiminnot
{
    public abstract class MenuToiminto
    {
        public string Komento { get; set; }
        public string KomennonKuvaus { get; set; }

        public abstract void Suorita();


        public void TulostaOhje()
        {
            Console.WriteLine("");
        }
    }
}
