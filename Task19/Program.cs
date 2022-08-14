// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пяятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Palindrome(int num)
{
    if (num < 100000 && 9999 < num)
    {
        if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10) Console.WriteLine($"{num} -> да");
        else Console.WriteLine($"{num} -> нет"); return;
    }
    Console.WriteLine("не коректный ввод");
}
Palindrome(number);
