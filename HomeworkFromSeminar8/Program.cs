//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/* int[,] CreateRandom2dArray()
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

int[,] SortArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }

    }
    return array;
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

SortArray(myArray);
Show2dArray(myArray); */

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/* int[,] CreateRandom2dArray()
{

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[5, 4];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
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

int FindMinSum(int[,] array)
{
    
    int min = 0;
    int row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        if (i == 0) min = sum;
        else if (min > sum)
        {
            row = i;
            min = sum;
        }

    }
    return row;
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine($"The smallest sum in the row number {FindMinSum(myArray) + 1}"); */

/* int[,] CreateRandom2dArray()
{

    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
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

int[,] FindProduct(int[,] arrayA, int[,] arrayB)
{
    int[,] product = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

    for (var i = 0; i < arrayA.GetLength(0); i++)
    {
        for (var j = 0; j < arrayB.GetLength(1); j++)
        {
            product[i, j] = 0;

            for (var k = 0; k < arrayA.GetLength(1); k++)
            {
                product[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }

    return product;
}
int[,] myArray = CreateRandom2dArray();
Console.WriteLine("The first matrix: ");
Show2dArray(myArray);
int[,] array = CreateRandom2dArray();
Console.WriteLine("The second matrix: ");
Show2dArray(array);
if (myArray.GetLength(1) != array.GetLength(0))
{
    Console.WriteLine("The length of columns of the first matrix is not equal to the length of rows of the second matrix");

}
else
{
    int[,] productArray = FindProduct(myArray, array);
    Console.WriteLine("The product of two matrices: ");
    Show2dArray(productArray);
} */


//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void CreateRandom3dArray(int[,,] array3D)
{
    int[] array = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 100);
        number = array[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 100);
                    j = 0;
                    number = array[i];
                }
                number = array[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = array[count];
                count++;
            }
        }
    }
}

void Show3dArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
        }
    }
    Console.WriteLine();
}

Console.Write("Input a X of 3D matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Y of 3D matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Z of 3D matrix: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[x, y, z];
CreateRandom3dArray(array3D);
Show3dArray(array3D);

//Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralArray()
{
    Console.Write("Input a size of an array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[size, size];
    int num = 1;
    int minRow = 0;
    int maxRow = size - 1;
    int minCol = 0;
    int maxCol = size - 1;

    while (num <= array.GetLength(0) * array.GetLength(1))
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            array[minCol, i] = num;
            num++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)
        {
            array[i, maxCol] = num;
            num++;
        }
        maxCol--;
        for (int i = maxCol; i >= minCol; i--)
        {
            array[maxRow, i] = num;
            num++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--)
        {
            array[i, minCol] = num;
            num++;
        }
        minCol++;
    }
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
int[,] myArray = SpiralArray();
Show2dArray(myArray);