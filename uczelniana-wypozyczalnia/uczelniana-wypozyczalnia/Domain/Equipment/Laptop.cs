namespace uczelniana_wypozyczalnia.Domain.Equipment;

public class Laptop : Sprzet
{
    public string OS;
    
    public Laptop(string OS) : base()
    {
        this.type = "Laptop";
        this.OS = OS;
    }
    
}