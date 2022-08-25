/* // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
Console.Write("Введите первое число - "); 
double A = double.Parse(Console.ReadLine()); 
Console.Write("Введите второе число - "); 
double B = double.Parse(Console.ReadLine()); 

double max = A; 
double min = B; 
if (B>A) 
{ 
    max = B; 
    min = A; 
} 
Console.WriteLine("Ответ: "); 
Console.Write("max = "); 
Console.WriteLine(max); 
Console.Write("min = "); 
Console.WriteLine(min); 
 */

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/* Console.Write("Введите первое число - "); 
double A = double.Parse(Console.ReadLine()); 
Console.Write("Введите второе число - "); 
double B = double.Parse(Console.ReadLine()); 
Console.Write("Введите первое число - "); 
double C = double.Parse(Console.ReadLine());
if (A>B)
{
    if(A>C)
    {
        double max = A;
        Console.WriteLine("Ответ: ");
        Console.Write("max = "); 
        Console.WriteLine(max);
    }
    else
    {
        double max = C;
        Console.WriteLine("Ответ: ");
        Console.Write("max = "); 
        Console.WriteLine(max);
    }
    }
else
{
    if (B>C)
    {
        double max = B;
         Console.WriteLine("Ответ: ");
         Console.Write("max = "); 
         Console.WriteLine(max);
    }
    else
    {
        double max = C;
        Console.WriteLine("Ответ: ");
        Console.Write("max = "); 
        Console.WriteLine(max);
    }
}
 */

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число - ");
int A = int.Parse(Console.ReadLine());

if (A%2 == 0)
{
    Console.WriteLine("чётное число");
}
else
{
Console.WriteLine("нечётное число");
}

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/* Console.Write("Введите число - ");
int N = int.Parse(Console.ReadLine());
int Eventnumber = 2;
Console.Write("Ответ - ");
while(Eventnumber<=N)
{
    if(Eventnumber%2 == 0)
    {
        Console.Write(Eventnumber);
        Console.Write(";");
    }
    Eventnumber ++;
} */