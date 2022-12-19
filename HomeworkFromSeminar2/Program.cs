/*// Задача 1

int ShowSecondDigit(int number)
{
    int ed = -1;
    if (number >= 100 && number < 1000)
    {
    int sot = number % 100;
    ed = sot / 10;
    }
    return ed;
    
}

Console.WriteLine("Input a three-digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
int result = ShowSecondDigit(threeDigitNumber);
Console.WriteLine("The second digit in your number is " + result + ". (If you got -1, then you need to input a three-digit number)");*/

/*//Задача 2.

int ShowThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
    while (number > 999)
    {
        number /= 10;
    }
        result = number % 10;
    }
        return result;
    
}

Console.WriteLine("Input a number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
int result = ShowThirdDigit(threeDigitNumber);
Console.WriteLine("The third digit in your number is " + result + ". (If you got -1, then you need to input at least a three-digit number)");*/

//Задача 3.

bool IsWeekend (int num) 
{
    if(num == 6 || num == 7) return true;
    else return false; 
}

Console.Write("Input a number from 1 to 7: ");
int num1 = Convert.ToInt32(Console.ReadLine());


if (IsWeekend(num1))
{
    Console.WriteLine("It is a weekend");
}
else
{
    Console.WriteLine("It is not a weekend or you input a number not in the range from 1 to 7");
}