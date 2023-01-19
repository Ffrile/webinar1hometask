// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 2)
{
    for (int count = 2; count <= num; count = count + 2)
    {
        System.Console.WriteLine(count);
    }
}
else
{
    System.Console.WriteLine("нет чисел удволетворяющих условию");
}