namespace uczelniana_wypozyczalnia.Domain.Equipment;

public abstract class Sprzet
{
    public static int ilosc = 0;
    
    public int ID;
    public string type;
    public bool available;

    public Sprzet()
    {
        this.ID = ++ilosc;
        this.available = true;
    }
    
}