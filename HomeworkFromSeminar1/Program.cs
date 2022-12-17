//Задача 1

/*Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Max is {num1}");
}
else if(num1 < num2) 
{
    Console.WriteLine($"Max is {num2}");
}
else
{
    Console.WriteLine("Input two different numbers");
}
*/

// Задача 2

/*Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(max < num2) 
{   
    max = num2;
}

if(max < num3) 
{
    max = num3;
}

Console.WriteLine($"Max is {max}");
*/

//Задача 3

/*Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0) 
{
    Console.WriteLine($"Your number {number} is even");
}
else
{
    Console.WriteLine($"Your number {number} is odd");
}*/

//Задача 4

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= number)
{
    if(current % 2 == 0)
    {
    Console.Write(current + " ");
    }
    current++;
}