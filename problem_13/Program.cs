// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
  Console.WriteLine ("третьего числа - нет");  
}
  while (number >= 1000)
  {
    number = number / 10;
  }
    if (number <= 1000 && number >= 100)
    {
      Console.WriteLine("третье число - " + number%10);
    }