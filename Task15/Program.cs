System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a >7) 
{
    System.Console.WriteLine("Введите число от 1 до 7");
}
else if (a==6 || a==7)
{
    System.Console.WriteLine("да");
}
else System.Console.WriteLine("нет");