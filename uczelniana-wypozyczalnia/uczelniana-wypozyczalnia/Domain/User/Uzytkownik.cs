namespace uczelniana_wypozyczalnia.Domain.User;

public abstract class Uzytkownik
{
    public static int ilosc = 0;
    public int ID;
    public string imie;
    public string nazwisko;
    public string rodzaj_u;
    public int ilosc_wypozyczonych;
    public int max_wypozyczen;

    public Uzytkownik(string imie, string nazwisko)
    {
        ID = ++ilosc;
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.ilosc_wypozyczonych = 0;
    }
}