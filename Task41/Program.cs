// 1 вариант с поочередным вводом элементов

System.Console.WriteLine("Введите количество чисел");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
int sum = 0;
for (int i = 0; i < m; i++)
{
    System.Console.WriteLine("Введите число");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i]>0) sum = sum+1;
}
for (int i = 0; i < m; i++)
{
    System.Console.Write(" " + array[i]);
}
System.Console.WriteLine();
System.Console.WriteLine("Количество числе больше 0 равно "+ sum);


// 2 вариант. ВВод элементов одной строкой

// System.Console.WriteLine("Введите количество чисел");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите "+m+" элементов массива через пробел или запятую");
// string str = Console.ReadLine();
// string[] array = str.Split(' ',',');
// int[] arrint = new int[m];
// for (int i = 0; i < m; i++)
// {
//     arrint[i] = Convert.ToInt32(array[i]);
//     System.Console.Write(" "+arrint[i]);
// }
// int sum =0;
// foreach (var item in arrint)
// {
//     if(item >0) sum++;
// }
// System.Console.WriteLine();
// System.Console.WriteLine("Количество числе больше 0 равно "+ sum);
