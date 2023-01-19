// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    System.Console.WriteLine("Числа равны");
}
else
if (number1 > number2)
{
    System.Console.WriteLine(number1 + " - max");
    System.Console.WriteLine(number2 + " - min");

}
else
{
    System.Console.WriteLine(number2 + " - max");
    System.Console.WriteLine(number1 + " - min");

}


