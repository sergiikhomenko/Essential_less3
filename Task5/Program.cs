namespace Task5;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас Printer. У тілі класу створіть метод void Print(string value),
 * що виводить на екран значення аргументу. Реалізуйте можливість того, щоб у разі
 * успадкування від даного класу інших класів, та виклику відповідного методу їх екземпляра,
 * рядки, передані як аргументи методів, виводилися різними кольорами. Обов'язково використовуйте типи.
 */
class Program
{
    static void Main(string[] args)
    {
        ColorPrint colorPrint = new ColorPrint();
        colorPrint.Print("text1");
        colorPrint.Print("text2");
        colorPrint.Print("text3");
        colorPrint.Print("text4");
        colorPrint.Print("text5");
    }
}