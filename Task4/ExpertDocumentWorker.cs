namespace Task4;
/* Створіть похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker.
* Перевизначте відповідний спосіб. При викликі даного методу необхідно виводити на екран "Документ збережений
* у новому форматі".
    * 
* У тілі методу Main() реалізуйте можливість прийому від користувача номер ключа доступу pro і exp.
* Якщо користувач не вводить ключ, він може користуватися лише безкоштовною версією (створюється екземпляр
* базового класу), якщо користувач ввів номери ключа доступу pro і exp, то повинен створити екземпляр відповідної
* версії класу, наведений до базового - DocumentWorker.
*/
public class ExpertDocumentWorker:ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ збережений у новому форматі");
    }
}