Console.WriteLine("Программа подсказывает дипозоны по заданной четверти в оси координат");
Console.WriteLine("Введите необходимую четверть от 1 до 4 включительно");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1) Console.WriteLine ("Вы можете использовать координаты X>0 и Y>0");
else if (a == 2) Console.WriteLine ("Вы можете использовать координаты X<0 и Y>0");
else if (a == 3) Console.WriteLine ("Вы можете использовать координаты X<0 и Y<0");
else Console.WriteLine ("Вы можете использовать координаты X>0 и Y<0");

Console.WriteLine("Спасибо за внимание, обращайтесь еще");