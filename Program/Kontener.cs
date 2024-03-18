namespace Program;

public abstract class Kontener
{
    protected double MasaLadunku { get; set; }
    protected int Wysokosc { get; }
    protected double Waga { get; }
    protected int Glebokosc { get; }
    protected int Numer { get; }
    protected double MaxMasaLadunku { get; }

    protected Kontener(double masaLadunku, int wysokosc, double waga, int glebokosc, int numer, double maxMasaLadunku)
    {
        MasaLadunku = masaLadunku;
        Wysokosc = wysokosc;
        Waga = waga;
        Glebokosc = glebokosc;
        Numer = numer;
        MaxMasaLadunku = maxMasaLadunku;
    }

    protected void Oproznienie()
    {
        MasaLadunku = 0;
    }

    protected void Zaladowanie(double masa)
    {
        MasaLadunku += masa;
        if (MasaLadunku > MaxMasaLadunku)
        {
            throw new OverfillException(0, "kontener wybuchnie");
        }
    }

    protected void eksplozja()
    {
        Oproznienie();
    }
}