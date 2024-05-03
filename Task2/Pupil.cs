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
public   class Pupil
{ 
    private string _name , _status;

    public virtual void Study()
    {
    }

    public virtual void Read()
    {
    }

    public virtual void Write()
    {
    }

    public virtual void Relax()
    {
    }

    public string Name
  {
      set
      {
          _name = value;
      }
      get
      {
          return _name;
      }
  }

    public string Status
    {
        set
        {
            _status = value;
        }
        get
        {
            return _status;
        }
    }
    
}