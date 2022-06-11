// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число обозначающее день недели, от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("YES, HOLLIDAY");
}
else 
{
Console.WriteLine("NO, HOLLIDAY");
}