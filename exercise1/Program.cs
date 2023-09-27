//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
int secondDigit = number / 10 % 10;

if (number < 100 || number > 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine($"Вторая цифра цисла - {secondDigit}");
}

