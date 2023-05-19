// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.WriteLine ("Введите порядковый номер дня недели");
string num = Console.ReadLine();
    if (num=="1")
    {
       Console.WriteLine("Пн"); 
    }
    else  if (num=="2")
    {
       Console.WriteLine("Вт"); 
    }
    else  if (num=="3")
    {
       Console.WriteLine("Ср"); 
    }
    else  if (num=="4")
    {
       Console.WriteLine("Чт"); 
    }
    else  if (num=="5")
    {
       Console.WriteLine("Пт"); 
    }
    else  if (num=="6")
    {
       Console.WriteLine("Сб"); 
    }
    else  if (num=="7")
    {
       Console.WriteLine("Вс");
    }
else 
{
    Console.WriteLine("Некорректный ввод");
}