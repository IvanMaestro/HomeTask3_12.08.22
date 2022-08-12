// Задача 23
// Напишите программу, которая 
// принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;
double result = count;
Console.WriteLine($"Таблица кубов чисел от 1 до {number}: ");
while (count <= number)
{
    result = Math.Pow (count, 3);
    Console.WriteLine($"{count} | {result}");
    count++;
}