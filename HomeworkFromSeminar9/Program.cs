/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/* void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
}

ShowNums(5); */

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/* void GetSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    GetSum(m, n - 1, sum);
}

Console.Write("Input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}

Console.Write($"{m}, {n} ->");
GetSum(m, n, sum); */


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

 int AckermannFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0 && m > 0) return AckermannFunction(m - 1, 1);
  else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write("Input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int ackermann = AckermannFunction(m, n);
Console.Write($"A({m},{n}) = {ackermann} ");