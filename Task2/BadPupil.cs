namespace Task2;

public class BadPupil:Pupil
{
    public BadPupil(string name, string status)
    {
        Name = name;
        Status = status;
    }

    public override void Read()
    {
        Console.WriteLine("no read");
    }

    public override  void Study()
    {
        Console.WriteLine("no study");
    }

    public  override void Write()
    {
        Console.WriteLine("no stadi");
    }

    public override  void Relax()
    {
        Console.WriteLine("max relax");
    }
}