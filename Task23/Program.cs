// сделал функцию для возведения числа в любую степень, которую потом использовал внутри цикла.
// кода побольше, но делал с целью поупражняться с функцией

int grade(int a, int b) 
{
int result;
result =1;
for (int i = 0; i < b; i++)
{
    result =  result * a;
}
return (result);
}

System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i =1;
while (i<=n)
{
    System.Console.Write(" " + grade(i,3));
    i++;
}