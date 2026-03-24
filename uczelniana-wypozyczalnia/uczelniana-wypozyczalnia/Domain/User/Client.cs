using uczelniana_wypozyczalnia.Domain.Equipment;

namespace uczelniana_wypozyczalnia.Domain.User;

public class Client : Uzytkownik
{
    private List<Sprzet> wypozyczone;

    public Client(string imie, string nazwisko) : base(imie, nazwisko)
    {
        wypozyczone = new List<Sprzet>();
        rodzaj_u = "client";
        max_wypozyczen = 2;
    }

    public void wypozycz_sprzet(Sprzet sprzet)
    {
        wypozyczone.Add(sprzet);
    }
}