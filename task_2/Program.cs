/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberTwo = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numberThree = int.Parse(Console.ReadLine());

int max = numberOne;

if (numberTwo > max)
{
    max = numberTwo;
}
if (numberThree > max)
{
    max = numberThree;
}
Console.Write("Максимальное число ");
Console.WriteLine(max);

