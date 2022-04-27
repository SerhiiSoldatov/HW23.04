// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.Write("Введите число   : ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите степень : ");
int b = int.Parse(Console.ReadLine());

int x = 1;
for (int i = 0; i < b; i++)
{
    x *= a;
}
Console.WriteLine($"{a} ^ {b} = {x}");
