namespace Task3;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та
 * параметри суден (ціна, швидкість, рік випуску). Створіть 3 похідні класи
 * Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість
 * пасажирів. Для класу Ship – кількість пасажирів та порт приписки. Написати програму,
 * яка виводить на екран інформацію про кожен засіб пересування.
 */
public class Ship:Vehicle
{
 private int _numberOfPassengers;
 private string _port;
 public Ship(double price,int speed, int dateBild, string typeVehicle, int numberOfPassengers,
  string port)
 {
  Prise = price;
  Speed = speed;
  DateBild = dateBild;
  TypeVehicle = typeVehicle;
  _numberOfPassengers = numberOfPassengers;
  _port = port;
 }

 public override void ShowInfoFoVehicle()
 {
  Console.WriteLine(new string('*',40));
  Console.WriteLine($"Тип транспортного засобу {TypeVehicle}");
  Console.WriteLine($"Ціна ТЗ:{Prise}");
  Console.WriteLine($"Швидкість ТЗ: {Speed}");
  Console.WriteLine($"Дата будіництва {DateBild}");
  Console.WriteLine($"Кількфсть пасажирів {_numberOfPassengers}");
  Console.WriteLine($"Порт реєстрації: {_port}");
 }
}