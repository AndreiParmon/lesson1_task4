// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
Console.WriteLine("Введите 1-е число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
Console.WriteLine("max = " + max);