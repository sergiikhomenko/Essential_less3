namespace Task2;

public class GoodPupil:Pupil
{
    public GoodPupil(string name, string status)
    {
        Name = name;
        Status = status;
    }

    public  override void Read()
    {
        Console.WriteLine("read");
    }

    public  override void Study()
    {
        Console.WriteLine("stady good");
    }

    public override void Write()
    {
        Console.WriteLine("write good");
    }

    public override void Relax()
    {
        Console.WriteLine("50/50");
    }
}