namespace Task4;
/*Створіть похідний клас ProDocumentWorker. Перевизначте відповідні методи, при перевизначенні
* методів виводьте наступні рядки: "Документ відредаговано", "Документ збережено у старому форматі,
* збереження в інших форматах є у версії Експерт".
* 
* Створіть похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker.
* Перевизначте відповідний спосіб. При викликі даного методу необхідно виводити на екран "Документ збережений
* у новому форматі".
* 
* У тілі методу Main() реалізуйте можливість прийому від користувача номер ключа доступу pro і exp.
* Якщо користувач не вводить ключ, він може користуватися лише безкоштовною версією (створюється екземпляр
* базового класу), якщо користувач ввів номери ключа доступу pro і exp, то повинен створити екземпляр відповідної
* версії класу, наведений до базового - DocumentWorker.
*/
public class ProDocumentWorker:DocumentWorker
{
  public override void EditDocument()
  {
    Console.WriteLine("Документ відредаговано");
  }

  public override void SaveDocument()
  {
    Console.WriteLine("Документ збережено у старому форматі,\n* збереження в інших форматах є у версії Експерт");
  }
  
}