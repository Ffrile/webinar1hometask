System.Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 >= number2 & number1 >= number3)
    {
    System.Console.WriteLine(number1);
    }
if (number2 >= number1 & number2 >= number3)
   {
    System.Console.WriteLine(number2);
   }    
if (number3 >= number1 & number3 >= number2)
    {
    System.Console.WriteLine(number3);
    }