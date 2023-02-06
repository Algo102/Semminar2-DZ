Console.WriteLine("Программа определяет, является ли число квадратом другого");
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int kvadrat1 = a*a;
int kvadrat2 = b*b;

if (kvadrat1 == b || kvadrat2 == a) Console.WriteLine ("Одно из введеных чисел является квадратом другого");
else Console.WriteLine ("Ни одно число НЕ является квадратом другого");