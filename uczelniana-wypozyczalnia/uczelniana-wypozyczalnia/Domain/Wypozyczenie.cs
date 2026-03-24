using uczelniana_wypozyczalnia.Domain.Equipment;
using uczelniana_wypozyczalnia.Domain.User;

namespace uczelniana_wypozyczalnia.Domain;

public class Wypozyczenie
{
    private static int count = 0;
    public int ID { get; }
    public Uzytkownik uzytkownik { get; }
    public Sprzet sprzet { get; }
    public DateTime data_wypozyczenia { get; }
    public DateTime termin_oddania { get; }
    public DateTime? data_oddania { get; set; }
    public bool aktywne => data_oddania == null;
    public int? kara { get; set; }

    public Wypozyczenie(Uzytkownik u, Sprzet s)
    {
        this.ID = ++count;
        this.uzytkownik = u;
        this.sprzet = s;
        data_wypozyczenia = DateTime.Now;
        termin_oddania = data_wypozyczenia.AddDays(30);
    }
    
    public bool overdue()
    {
        return aktywne && (DateTime.Now > termin_oddania);
    }

    public int ile_kary()
    {
        var oddanie_pls = data_oddania ?? DateTime.Now;
        var dni = (int)(Math.Max(0, (oddanie_pls - termin_oddania).TotalDays));
        return dni * 100;
    }

    public int zwrot()
    {
        if (sprzet.available)
        {
            data_oddania = DateTime.Now;
            kara = ile_kary();
            return kara.Value;
        }

        return 0;
    }

    // to do tostring override
    
    
}