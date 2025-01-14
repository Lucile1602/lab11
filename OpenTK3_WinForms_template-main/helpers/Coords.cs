public class Coords
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public Coords(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public string Display()
    {
        return $"({X}, {Y}, {Z})";
    }
}