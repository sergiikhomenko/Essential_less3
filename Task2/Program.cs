namespace Task2;
/*
   Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно: Створити клас, який представляє навчальний клас ClassRoom. 
    Створіть клас учень Pupil. У тілі класу створіть методи void Study(), 
    void Read(), void Write(), void Relax(). Створіть 3 похідні класу 
    ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil і 
    перевизначте кожен із методів, залежно від успішності учня.
     Конструктор класу ClassRoom приймає аргументи типу Pupil, клас має складатися із 4 учнів. 
     Передбачте можливість, що користувач може передати 2 або 3 аргументи. Виведіть інф
 */
class Program
{
    static void Main(string[] args)
    {
        Pupil badPupil0 = new BadPupil("Vasya","bad student");
        Pupil goodPupil = new GoodPupil("Toha","good student");
        Pupil excelentPupil = new ExcelentPupil("Anna","Excelend student");
        Pupil badPupil3 = new BadPupil("Alex", "bad student");
        Pupil[] student = new[] {badPupil0, goodPupil, excelentPupil, badPupil3 };
        ClassRoom classRoom = new ClassRoom(student);
        classRoom.ShowClassRoom();
    }
}