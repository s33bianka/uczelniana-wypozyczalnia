namespace uczelniana_wypozyczalnia.Domain.Equipment;

public class Projector : Sprzet
{
    public bool color;

    public Projector(bool color)
    {
        this.type = "Camera";
        this.color = color;
    }
}