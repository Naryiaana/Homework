//Задача 1.
/*int GetPalindrome(int number)
{
    string reverse = "";
    while (number > 0)
    {
        reverse = reverse + number % 10;
        number = number / 10;
    }
    int reverseNumber = Convert.ToInt32(reverse);
    return reverseNumber;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num == GetPalindrome(num)) Console.WriteLine("Yes, it is a Palindrome");
else Console.WriteLine("No, it is not a Palindrome");*/

//Задача 2.

/*double GetDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res1 = Math.Pow(x2 - x1, 2);
    double res2 = Math.Pow(y2 - y1, 2);
    double res3 = Math.Pow(z2 - z1, 2);
    double result = Math.Sqrt(res1 + res2 + res3);
    return result;
}

Console.Write("Input coordinates of the first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates of the second point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The distance between points is: " + GetDistance(x1, x2, y1, y2, z1, z2));*/

//Задача 3

void GetCube(int num)
{
    int count = 1;
    Console.WriteLine("The cube of the numbers are: ");
        while (count <= num)
        {
        Console.Write(Math.Pow(count, 3) + " ");
        count++; 
        }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
GetCube(number);





