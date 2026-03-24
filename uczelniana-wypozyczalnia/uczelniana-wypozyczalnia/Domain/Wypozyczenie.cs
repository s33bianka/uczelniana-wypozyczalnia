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
    private bool overdue;

    public Wypozyczenie(Uzytkownik u, Employee e, DateTime limit)
    {
        this.u = u;
        this.e = e;
        this.aktywne = true;
        this.data_wypozyczenia = DateTime.Now;
        this.wypozyczenie_limit = limit;
        overdue = false;
    }

    public bool is_active()
    {
        return aktywne;
    }

    public int zwrot()
    {
        data_oddania = DateTime.Now;
        aktywne = false;
        int do_zaplacenia = kara();
        return do_zaplacenia;
    }

    public int kara()
    {
        if (data_oddania > wypozyczenie_limit)
        {
            overdue = true;
            return ((data_oddania - wypozyczenie_limit).Days * 100);
        }

        return 0;
    }

    public bool is_overdue()
    {
        return overdue;
    }
}