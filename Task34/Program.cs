// поупражнялся с double , понял что индекс массива не дружит с ним ;)

System.Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(100,1000);
    System.Console.Write(" " + array[i]);
}
double count =0;
for (int i = 0; i < n; i++)
{
 if (array[i]%2==0) count=count+1;   
}
double perc = ((count/n)*100); //  сразу и в процентах посчитал, чтобы удобней было теорию вероятности проверять
System.Console.WriteLine();
System.Console.WriteLine("Количество четных элементов массива равно "+count+" "+"или "+perc+"%" ); 
