/*
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    int n = 2;
    while (n <= number)
    {
        Console.Write(n);
        Console.Write(", ");
        n = n + 2;
    }
}
else 
{   
    Console.Write("Введите положительно число!");
}