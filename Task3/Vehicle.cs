namespace Task3;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та
 * параметри суден (ціна, швидкість, рік випуску). Створіть 3 похідні класи
 * Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість
 * пасажирів. Для класу Ship – кількість пасажирів та порт приписки. Написати програму,
 * яка виводить на екран інформацію про кожен засіб пересування.
 */
public abstract class Vehicle
{
    private double _prise;
    private int _speed;
    private int _dateBild;
    private string _typeVehicle;

    public double Prise
    {
        set { _prise = value; }
        get { return _prise; }
    }

    public int Speed
    {
        set { _speed = value; }
        get { return _speed; }
    }

    public int DateBild
    {
        set { _dateBild = value; }
        get { return _dateBild; }
    }

    public string TypeVehicle
    {
        set { _typeVehicle = value; }
        get { return _typeVehicle; }
    }
    public abstract void ShowInfoFoVehicle();
}