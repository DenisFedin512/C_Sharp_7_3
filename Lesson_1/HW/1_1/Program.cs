// Задача 2: Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write b number: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine("number a больше чем number b");
}
else
{
    Console.WriteLine("number b больше чем number a");
}