Console.WriteLine("Программа рассчитывает расстояние между двумя точками");
Console.WriteLine("Введите систему координат 1 - 2D или 2 - 3D");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("######################################################");
if (a==1)
{
  Console.WriteLine("Рассчитывае расстояние между двумя точками в 2D");
  Console.WriteLine("######################################################");
  Console.WriteLine("Введите X первой точки");
  double x1 = double.Parse(Console.ReadLine());
  Console.WriteLine("Введите Y первой точки");
  double y1 = double.Parse(Console.ReadLine());
  Console.WriteLine("------------------------------------------------------");
  Console.WriteLine("Введите X второй точки");
  double x2 = double.Parse(Console.ReadLine());
  Console.WriteLine("Введите Y второй точки");
  double y2 = double.Parse(Console.ReadLine());
  Console.WriteLine("------------------------------------------------------");  
  double rez2D = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));
  Console.WriteLine(rez2D);
}

if (a==2)
{
  Console.WriteLine("Рассчитывае расстояние между двумя точками в 3D");
  Console.WriteLine("######################################################");
  Console.WriteLine("Введите X первой точки");
  double x1 = double.Parse(Console.ReadLine());
  Console.WriteLine("Введите Y первой точки");
  double y1 = double.Parse(Console.ReadLine());
  Console.WriteLine("Введите Z первой точки");
  double z1 = double.Parse(Console.ReadLine());
  Console.WriteLine("------------------------------------------------------");  
  Console.WriteLine("Введите X второй точки");
  double x2 = double.Parse(Console.ReadLine());
  Console.WriteLine("Введите Y второй точки");
  double y2 = double.Parse(Console.ReadLine());
  Console.WriteLine("Введите Z второй точки");
  double z2 = double.Parse(Console.ReadLine());
  Console.WriteLine("------------------------------------------------------");  
  double rez3D = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))+((z2-z1)*(z2-z1)));
  Console.WriteLine(rez3D);
}
