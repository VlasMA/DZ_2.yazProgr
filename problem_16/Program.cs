// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого;
int Input (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = Input("Введите первое число: ");
int numberB = Input("Введите второе число: ");

if (numberA == numberB * numberB || numberB == numberA * numberA)
{
    Console.WriteLine("Yas");
}
else
{
    Console.WriteLine("NO");
}


