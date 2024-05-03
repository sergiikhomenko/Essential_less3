namespace Task2;
/*
 * Завдання 2
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас, який представляє навчальний клас ClassRoom.
 * Створіть клас учень Pupil. У тілі класу створіть методи void Study(),
 * void Read(), void Write(), void Relax(). Створіть 3 похідні класу
 * ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil
 * і перевизначте кожен із методів, залежно від успішності учня.
 * Конструктор класу ClassRoom приймає аргументи типу Pupil,
 * клас має складатися із 4 учнів. Передбачте можливість, що користувач може
 * передати 2 або 3 аргументи. Виведіть інф
 */
public class ClassRoom
{
    private Pupil[] _student;
    public ClassRoom(Pupil[] student )
    {
        _student = student;
    }

    public void ShowClassRoom()
    {
        ShowFunction(_student);
    }

    private void ShowFunction(Pupil[] student)
    {
        for (int i = 0; i < student.Length; i++)
        {
            Console.WriteLine(new string('*',40));
            Console.WriteLine(student[i].Name);
            Console.WriteLine(student[i].Status);
            student[i].Read();
            student[i].Write();
            student[i].Study();
            student[i].Relax();
            Console.WriteLine(new string('*',40));
            Console.WriteLine();
        }
    }
}