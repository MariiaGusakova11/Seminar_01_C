//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine("Введите значение: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    int number = 0;
    while ((number <= N) && (number % 2 == 0))
    {
        Console.Write(number + ", "); // == Console.Write($"{number}, ") // -4 -3 -2 -1 0 1 2 3 4
        number += 2;
    }
}
else
{
    Console.WriteLine("Введите значение больше 0!");
}