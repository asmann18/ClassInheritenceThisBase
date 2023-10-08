namespace ClassInheritence;

public class Player
{
    public string Name { get; set; }
    public int Point1 { get; set; }
    public int Point2 { get; set; }
    public int Point3 { get; set; }
    public int TotalScore { get; set; }
    public Player(string name,int point1,int point2,int point3)
    {
        Name = name;
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
        TotalScore = 0;
    }
}
