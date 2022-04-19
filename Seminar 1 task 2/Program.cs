//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int namberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int namberB = int.Parse(Console.ReadLine());

if (namberA > namberB)
{
    Console.WriteLine($"число {namberA} - максимальное число {namberB} - минимальное число");
}
else 
{
    Console.WriteLine($"число {namberB} - максимальное число {namberA} - минимальное число");
}