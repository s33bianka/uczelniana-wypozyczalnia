using uczelniana_wypozyczalnia.Domain.Equipment;

namespace uczelniana_wypozyczalnia.Domain.User;

public class Employee : Client
{

    public Employee(string imie, string nazwisko) : base(imie, nazwisko)
    {
        rodzaj_u = "employee";
    }
}