using System.ComponentModel.Design;
using Microsoft.VisualBasic;
using uczelniana_wypozyczalnia.Domain.User;

namespace uczelniana_wypozyczalnia.Domain;

public class Wypozyczenie
{
    public static int ID;
    private Uzytkownik u;
    private Employee e;
    private bool aktywne;
    private DateTime data_wypozyczenia;
    private DateTime wypozyczenie_limit;
    private DateTime data_oddania;

    public Wypozyczenie(Uzytkownik u, Employee e, DateTime limit)
    {
        this.u = u;
        this.e = e;
        this.aktywne = true;
        this.data_wypozyczenia = DateTime.Now;
        this.wypozyczenie_limit = limit;
    }

    public bool is_active()
    {
        return aktywne;
    }

    public bool overdue()
    {
        if (wypozyczenie_limit < data_wypozyczenia)
            return true;
        
        return false;
    }
}