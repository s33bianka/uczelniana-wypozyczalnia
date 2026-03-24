namespace uczelniana_wypozyczalnia.Domain.Equipment;

public class Camera : Sprzet
{
    public String size;
    public Camera(string size) : base()
    {
        this.type = "Camera";
        this.size = size;
    }
}