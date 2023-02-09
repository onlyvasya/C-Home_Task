void FillPrintArray (int [,] array)                        // функция на заполнение и печать массива       
{
Random  rnd = new Random(); 
for (int i = 0; i < array.GetLength(0); i++)
 {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rnd.Next(100);
        System.Console.Write(" "+ array[i,j]+" ");
    }
    System.Console.WriteLine();    
 }
}
Random  rnd = new Random(); 
int m= rnd.Next(2,10); 
int n=rnd.Next(2,10);                                    //генерация размерности массива
int[,] col = new int[m,n];
FillPrintArray(col);
System.Console.WriteLine();
int[] row = new int[col.GetLength(0)];
for (int i = 0; i < col.GetLength(0); i++)
{
    int sum=0;
    for (int j = 0; j < col.GetLength(1); j++)
        {
           sum = sum+col[i,j];
        }
    row[i] = sum;                                                               //одномерный массив из сумм элементов строк
    System.Console.WriteLine("cумма элементов "+i+" строки равна "+row[i]);     //по условиям задачи печатать не обязательно
}                                                                               // сделано для удобства проверки
System.Console.WriteLine();
int minindex=0;
for (int i = 0; i < row.Length; i++)
{                                                                                // поиск индекса наименьшего элемента массива
    if(row[i]<row[minindex]) minindex=i;
}    
System.Console.WriteLine("Строка с наименьшей суммой элементов --> "+ minindex);