/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("ВВедите первое число ");
int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int numberTwo = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;



if (numberOne > numberTwo) 
{
    max = numberOne;
    min = numberTwo;
    Console.WriteLine("Большее число = " + max);
    Console.Write("Меньшее число = " + min);
}
if (numberOne < numberTwo) 
{
    max = numberTwo;
    min = numberOne;
    Console.WriteLine("Большее число = " + max);
    Console.Write("Меньшее число = " + min);
}
if (numberOne == numberTwo)
{
    Console.WriteLine(" Введите разные числа!");
}





