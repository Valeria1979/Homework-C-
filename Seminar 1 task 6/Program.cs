// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int namber = int.Parse(Console.ReadLine());

if (namber % 2 ==0)

{
    Console.WriteLine($"число {namber} - четное число");
}
else

{
    Console.WriteLine($"число {namber} - нечетное число");
}