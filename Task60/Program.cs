// Ну я тут схитрил исходя из условия - ни слова о случайных числах не было ;)
// в дискорде  обсуждали , понравился вариант Дмитрия с функцией из цикла while и булевой переменной 
// повторять не стал, т.к. не мое решение

System.Console.WriteLine("input dimension X");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input dimension Y");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input dimension Z");
int z = Convert.ToInt32(Console.ReadLine());
if ((x*y*z)>90) System.Console.WriteLine("Array is too big for two-digit numbers");
else
{
int[,,] col = new int[x, y, z];
int n = 10;
for (int i = 0; i < col.GetLength(0); i++)
{
    for (int j = 0; j < col.GetLength(1); j++)
    {
        for (int k = 0; k < col.GetLength(2); k++)
        {
            col[i, j, k] = n;
            System.Console.Write(col[i, j, k] + " " + "[" + i + "," + j + "," + k + "] ");
             n++;       
        }
    }
    System.Console.WriteLine();
}
}
