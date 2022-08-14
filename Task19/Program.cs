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

string Find3Digit(int num)
{
    int digit1 = num / 10000;
    int digit2 = num / 1000 % 10;
    int digit4 = num % 100 / 10;
    int digit5 = num % 10;

    if (num < 1000 || num > 99999) return $"{num} - не пятизначное число!";
    if (digit1 == digit5 && digit2 == digit4) return "Да!";
    else
    {
        return "Нет!";
    }
}

string result = Find3Digit(number);
Console.WriteLine(result);