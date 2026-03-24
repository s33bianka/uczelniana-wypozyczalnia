using uczelniana_wypozyczalnia.Domain.Equipment;

namespace uczelniana_wypozyczalnia.Domain.User;

public class Employee : Uzytkownik
{
    private List<Sprzet> wypozyczenia;

    public Employee(string imie, string nazwisko) : base(imie, nazwisko)
    {
        wypozyczenia = new List<Sprzet>();
        rodzaj_u = "employee";
        max_wypozyczen = 5;
    }

    public void wypozycz_klientowi(Sprzet sprzet)
    {
        wypozyczenia.Add(sprzet);
    }
}