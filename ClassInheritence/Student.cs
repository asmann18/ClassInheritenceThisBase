using System.Net.WebSockets;

namespace ClassInheritence;

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Group { get; set; }
    public byte Point { get; set; }
    public bool isGraduated { get; set; }
    public Student(string name,string surname,string group,byte point)
    {
        if(point<0 || point > 100)
        {
            Console.WriteLine($"{name} adli telebenin pointi duzgun daxil edilmeyib,Point 0 100 araliginda olmalidi,deyerleri control edin.");
            return;
        }
        Name = name;
        Surname = surname;
        Group = group;
        Point = point;
        
        isGraduated = false;
        if(point>65)
            isGraduated=true;
    }
    public void GetInfo()
    {
        Console.WriteLine($"Name:{Name} Surname:{Surname} Group:{Group} Point:{Point} IsGraduated:{isGraduated}");
    }
    public void CheckGraduation()
    {
        if (isGraduated)
        {
            Console.WriteLine("Telebe mezun olub");
            return;
        }
            Console.WriteLine("Telebe kesilib");
    }
    public void GetDiplomDegree()
    {
        if (Point < 65)
        {
            Console.WriteLine("Diplomu yoxdur");
          
        }
        else if (Point >=65 && Point <= 80)
        {
            Console.WriteLine("Adi diplom");
        

        }
        else if(Point>80 && Point <= 90)
        {
            Console.WriteLine("Seref diplomu");
        }
        else
        {
            Console.WriteLine("Yuksek seref diplomu");
        }
    }
}
