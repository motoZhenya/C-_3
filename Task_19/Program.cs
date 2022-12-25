// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. (читается слева направо и справа налево одинаково)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
string number = (Console.ReadLine()!); // 14212
int num = number.Length;

if (num == 5)
{
 if (number[0] == number[4] && number[1] == number[3])
    {
 Console.WriteLine($"{number} - Палиндром");
    }
 else
    {
 Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
 Console.WriteLine($"FATAL: {number} - не является пятизначным");
}