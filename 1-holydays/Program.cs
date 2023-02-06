Console.WriteLine("Программа по заданному дню, говорит это выходной или нет");
Console.WriteLine("Введите число, соответсвующее дню недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7) Console.WriteLine ("Этот день выходной");
else Console.WriteLine ("Этот день не выходной");
