namespace Task2;
/*
Створіть клас учень Pupil. У тілі класу створіть методи void Study(),
* void Read(), void Write(), void Relax(). Створіть 3 похідні класу
* ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil
* і перевизначте кожен із методів, залежно від успішності учня.
* Конструктор класу ClassRoom приймає аргументи типу Pupil,
* клас має складатися із 4 учнів. Передбачте можливість, що користувач може
* передати 2 або 3 аргументи. Виведіть інф
    */
public class ExcelentPupil:Pupil
{
    public ExcelentPupil(string name, string status)
    {
        Name = name;
        Status = status;
    }

    public override  void Read()
    {
        Console.WriteLine("Read Excelent Pupil");
    }

    public  override void Write()
    {
        Console.WriteLine("Write Excelent Pupil");
    }

    public  override  void Study()
    {
        Console.WriteLine("Study Excelent Pupil");
    }

    public override void Relax()
    {
        Console.WriteLine("no Relax");
    }
}