// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа: ");
int namberA = int.Parse(Console.ReadLine()); 
int namberB = int.Parse(Console.ReadLine());
int namberC = int.Parse(Console.ReadLine()); 
int max = namberA;

if (namberB > max) max = namberB;
    
if (namberC > max) max = namberC;

{
    Console.WriteLine($"число {max} - максимальное число");
}