// Задача 19
// Напишите программу, которая принимает 
// на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Для проверки является ли число палиндромом");
Console.Write("Введите любое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit1 = number / 10000;
int digit2 = number / 1000 % 10;
int digit4 = number % 100 / 10;
int digit5 = number % 10;

if (number < 1000 || number > 99999) Console.WriteLine($"{number} - не пятизначное число!");
else if (digit1 == digit5 && digit2 == digit4) Console.WriteLine("Да!");
else
{
    Console.WriteLine("Нет!");
}
