// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/* double[,] CreateRandomDouble2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of rows: ");
    int columns = Convert.ToInt32(Console.ReadLine());
        
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().NextDouble();

    return array;   
}

void ShowDouble2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandomDouble2dArray();
ShowDouble2dArray(myArray); */

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*  int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of rows: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;   
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowElement(int[,] array, int row, int column)
{
    if(row < array.GetLength(0) && column < array.GetLength(1)) Console.Write(array[row, column] + " ");
    else Console.WriteLine("There is no such an element");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.Write("Input a row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column: ");
int column = Convert.ToInt32(Console.ReadLine());
ShowElement(myArray, row, column); */

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandomArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of rows: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;   
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] GetMean(int[,] array)
{
    double[] meanArray = new double[array.GetLength(1)];
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double mean = 0;
        double sum = 0;
        int count = 0;

        for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, j];
                count++;
            }

        mean = sum / count;
        meanArray[j] = mean;     
    }
    
    return meanArray;
}

void ShowArr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int[,] myArray = CreateRandomArray();
ShowArray(myArray);
double[] array = GetMean(myArray);
ShowArr(array);


