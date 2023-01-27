System.Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(1,10);
    System.Console.Write(" " + array[i]);
}
double max=array[0];
double min=array[0];
foreach (var item in array)  // foreach попробовал
{
   if (item>max) max=item;
   if (item<min) min=item;
}
double delta = max-min;
System.Console.WriteLine();
System.Console.WriteLine("Разница между максимальным и минимальным элементом массива равна "+delta);