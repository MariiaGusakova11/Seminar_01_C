//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет


int number = new Random().Next(10, 100);
System.Console.WriteLine($"Случайное число: {number}");
int numberA = number % 2;

if (numberA == 0)
{
    Console.WriteLine($"{number} - четное число");
}
else
{
   Console.WriteLine($"{number} - нечетное число"); 
}