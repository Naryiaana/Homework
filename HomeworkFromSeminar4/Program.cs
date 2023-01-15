//Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int CustomPower (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

/*Console.Write("Input a first number ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int numberB = Convert.ToInt32(Console.ReadLine());

int powResult = CustomPower(numberA, numberB);
Console.WriteLine(powResult);*/

//Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSum (int a)
{
    int sum = 0;
    while (a != 0)
    {
        int num = a % 10;
        a = a / 10;
        sum = sum + num;
    }
    return sum;
}

/*Console.Write("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = GetSum(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);*/

//Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input {m} elements: ");
int[] newArray = CreateArray(m);

ShowArray(newArray);