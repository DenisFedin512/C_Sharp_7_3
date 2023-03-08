// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

bool not = true;
int a = 1;
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Четные числа от 1 до " + number);
while (a <= number)
{
    if (a % 2 != 1)
    {
        Console.Write(a + ", ");
        not = false;
    }
    a++;
}

if (not)
{
    Console.WriteLine("Нет четных чисел!");
}