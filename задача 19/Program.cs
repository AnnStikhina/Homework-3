// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
void Palindrom(int x)
{
    if (x / 10000 == x % 10 && (x / 1000) % 10 == (x / 10) % 10)
    {
      Console.WriteLine("Да, это полиндром");  

    }
    else 
    {
        Console.WriteLine("Нет, это не полиндром");
    }
} 
Console.Write("Введите пятизначное число: ");
int I = int.Parse(Console.ReadLine()!);
Palindrom(I);