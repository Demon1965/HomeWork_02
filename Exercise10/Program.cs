// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write($"Please, insert any three-digit number:   ");
int number=Convert.ToInt32(Console.ReadLine());
int temp=0;

number=number/10;
temp=number%10;

Console.WriteLine($"The second digit of your number is: {temp}");