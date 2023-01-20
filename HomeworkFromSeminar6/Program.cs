//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/* int CountPositiveNumbers(int quantity)
{
    int count = 0;
    for (int i = 0; i < quantity; i++)
    {
        Console.Write("Input a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) count++;
    }

    return count;
}

Console.Write("How many numbers do you want to input: ");
int quant = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"There are {CountPositiveNumbers(quant)} positive numbers"); */

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void GetPoint()
{
    Console.Write("Input b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2-b1) / (k1 - k2) + b1;
    
    Console.WriteLine($"The point of intersection of the two lines is ({x}; {y})");
}

GetPoint();