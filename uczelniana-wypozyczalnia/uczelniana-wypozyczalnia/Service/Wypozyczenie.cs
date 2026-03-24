using uczelniana_wypozyczalnia.Domain.Equipment;
using uczelniana_wypozyczalnia.Domain.User;

namespace uczelniana_wypozyczalnia.Service;

public class Wypozyczenie
{
    private List<Sprzet> lista_sprzety = new();
    private List<Uzytkownik> lista_uzytkownicy = new();
    private List<Wypozyczenie> lista_wypozyczenia = new();
    
    // sprzet ------------------------------------------------------------------------
    public void dodaj_sprzet(Sprzet s)
    {
        lista_sprzety.Add(s);
        Console.WriteLine("dodano sprzęt");
    }
    
    public List<Sprzet> caly_sprzet()
    {
        return lista_sprzety;
    }

    public List<Sprzet> dostepny_sprzet()
    {
        return lista_sprzety.Where(s => s.available).ToList();
    }

    public void zrob_niedostepny(int IDS)
    {
        var sprz = lista_sprzety.FirstOrDefault(s => s.ID == IDS);
        if (sprz != null)
        {
            sprz.notAvailable();
        }
    }
    
    
    // uzytkownicy -----------------------------------------------------------------
    public void dodaj_u(Uzytkownik u)
    {
        lista_uzytkownicy.Add(u);
        Console.WriteLine("dodano użytkownika");
    }
    
    
    // wypozyczenia ---------------------------------------------------------------
    public void wypozycz(int id_u, int id_s, int liczba_dni, DateTime? teraz = null)
    {
        var uz = lista_uzytkownicy.FirstOrDefault(u => u.ID == id_u);
    }
}