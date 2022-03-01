// Задача 1
    
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    {
        Console.WriteLine("Первое число больше");
            }
else
{
        Console.WriteLine("Второе число больше");
        }

// Задача 2

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a >= b)
    {
        max = a;
    }
else
    {
        max = b;
    }

if (c >= max)
{  
    max = c;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);
