System.Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(1,10);
    System.Console.Write(" " + array[i]);
}
double sum=0;
for (int i = 0; i < n; i++)
{
    if((i%2)>0) sum=sum+array[i];
}
System.Console.WriteLine();
System.Console.WriteLine("Сумма элементов с нечетным индексом равна "+sum);