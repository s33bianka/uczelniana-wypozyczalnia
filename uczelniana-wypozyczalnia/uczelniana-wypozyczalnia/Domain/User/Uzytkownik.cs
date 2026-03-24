namespace uczelniana_wypozyczalnia.Domain.User;

public abstract class Uzytkownik
{
    public static int ilosc = 0;
    public int ID;
    public string rodzaj_u;

    public Uzytkownik()
    {
        ID = ++ilosc;
    }
}