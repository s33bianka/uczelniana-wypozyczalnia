using uczelniana_wypozyczalnia.Domain.Equipment;

namespace uczelniana_wypozyczalnia.Domain.User;

public class Client : Uzytkownik
{

    public Client(string imie, string nazwisko) : base(imie, nazwisko)
    {
        rodzaj_u = "client";
    }
    
}