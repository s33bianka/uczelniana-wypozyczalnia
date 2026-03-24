namespace uczelniana_wypozyczalnia.Domain.Equipment;

public abstract class Sprzet
{
    private static int ilosc = 0;
    
    public int ID { get;} 
    public string type { get; set; }
    public bool available { get; set; }

    public Sprzet()
    {
        this.ID = ++ilosc;
        this.available = true;
    }

    public void notAvailable()
    {
        available = false;
    }

    public override string ToString()
    {
        return $"{ID.ToString()}: {type}, {available}";
    }
}