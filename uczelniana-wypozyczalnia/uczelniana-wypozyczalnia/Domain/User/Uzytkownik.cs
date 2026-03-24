namespace uczelniana_wypozyczalnia.Domain.User;

public abstract class Uzytkownik
{
    private static int ilosc = 0;
    public int ID { get; }
    public string imie;
    public string nazwisko;
    public string rodzaj_u;

    public Uzytkownik(string imie, string nazwisko)
    {
        ID = ++ilosc;
        this.imie = imie;
        this.nazwisko = nazwisko;
    }
    
    public override string ToString()
        {
            return $"{rodzaj_u} {ID.ToString()}: {imie} {nazwisko}";
        }
}