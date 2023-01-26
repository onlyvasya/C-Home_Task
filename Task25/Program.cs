
//Функцию написал еще для прошлого дз когда в куб возводили ;)

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

System.Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе  число");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write(grade(a,b));
    
