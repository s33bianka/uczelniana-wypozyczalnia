namespace uczelniana_wypozyczalnia.Domain.Equipment;

public class Camera : Sprzet
{
    public string size;
    public Camera(string size) : base()
    {
        this.type = "Camera";
        this.size = size;
    }
}