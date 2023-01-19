// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num %2 == 0)
{
    System.Console.WriteLine("число четное");
}
else 
{
    System.Console.WriteLine("число нечетное");
}