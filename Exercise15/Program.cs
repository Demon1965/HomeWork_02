// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write($"Please, insert any digit from 1 to 7:  ");
int number=Convert.ToInt32(Console.ReadLine());

if (number==6 || number==7)
    {
        Console.WriteLine($"Congradulations! Today is your rest day!");
    }
else
    {
        Console.WriteLine($"Sorry! You should go to the work!");
    }



