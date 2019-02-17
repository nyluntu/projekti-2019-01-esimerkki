using System;
using SwitchCaseRefactor.Toiminnot;

public class KolmasToiminto : MenuToiminto
{
    public KolmasToiminto()
    {
        this.Komento = "kolmas";
        this.KomennonKuvaus = "Varasto";
    }

    public override void Suorita()
    {
        Console.WriteLine("Valinta 03");
    }
}