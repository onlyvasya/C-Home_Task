
// C рандомным индексом не сделал, не знаю как оформить условию на заполненность элемента массива (гуглить не успевал)
// сделал функцию на заполнение и вывод рандомными числами, количество элементов задается пользователем

void ArrayFill (int a )
{
int[]array = new int[a];
for (int i = 0; i < a; i++)
{
    array[i] = new Random().Next(1,100);
    System.Console.Write(" " + array[i]);
}
}
System.Console.WriteLine("Введите количество элементов массива");
int b = Convert.ToInt32(Console.ReadLine());

ArrayFill (b);