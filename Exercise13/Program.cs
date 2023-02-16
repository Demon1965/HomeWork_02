// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write($"Please, insert any integer number: ");
int num=Convert.ToInt32(Console.ReadLine());
int digit=0;

if (num<100)
{
    Console.WriteLine($"Your number hasn't third digit:!");
}
else
{
    while (num>999)        
    {
        num=num/10;
    }
    digit=num%10;
    Console.WriteLine($"Third digit of your number is: {digit}");
}
