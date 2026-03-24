using uczelniana_wypozyczalnia.Domain.Equipment;

namespace uczelniana_wypozyczalnia.Domain.User;

public class Employee : Uzytkownik
{
    public int ilosc_wypozyczonych;
    private List<Sprzet> wypozyczenia;

    public Employee() : base()
    {
        wypozyczenia = new List<Sprzet>();
        this.rodzaj_u = "employee";
        ilosc_wypozyczonych = 0;
    }

    public void wypozycz_klientowi(Sprzet sprzet)
    {
        wypozyczenia.Add(sprzet);
    }
}