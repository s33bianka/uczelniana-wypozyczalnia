using uczelniana_wypozyczalnia.Domain.Equipment;

namespace uczelniana_wypozyczalnia.Domain.User;

public class Client : Uzytkownik
{
    public int ilosc_wypozyczonych;
    private List<Sprzet> wypozyczone;

    public Client() : base()
    {
        wypozyczone = new List<Sprzet>();
        this.rodzaj_u = "client";
        ilosc_wypozyczonych = 0;
    }

    public void wypozycz_sprzet(Sprzet sprzet)
    {
        wypozyczone.Add(sprzet);
    }
}