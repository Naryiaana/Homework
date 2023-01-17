//Задача 1.  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*int[] CreateRandomArray (int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);   
    
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;
    
    return count;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(length);
ShowArray(newArray);
int result = CountEvenNumbers(newArray);
Console.WriteLine("The count of even numbers is " + result);*/

//Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*int[] CreateRandomArr (int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 10);   
    
    return array;
}

void ShowArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if(i % 2 != 0)
            sum = sum + array[i];
            
    return sum;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArr(length);
ShowArr(newArray);
int result = GetSum(newArray);
Console.WriteLine("The sum of numbers on odd positions is " + result);*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//NextDouble
//[3 7 22 2 78] -> 76

double[] CreateRandomDoubleArr (int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble();   
    
    return array;
}

void ShowDoubleArr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
                min = array[i];
            else if (max < array[i])
                max = array[i];
        }
    //Насколько помню, нельзя использовать в методе, который возвращает что-то Console.Write? Но вроде для информирования можно?
    Console.Write($"Max is {max} ");
    Console.Write($"Min is {min} ");

    double result = max - min;
    return result;
            
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomDoubleArr(length);
ShowDoubleArr(newArray);
double result = GetDifference(newArray);
Console.WriteLine("The difference between max and min is " + result);
