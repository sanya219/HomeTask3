/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
bool IsPalindrome (int number)
{
    int numberToDivide = number, reverseNumber = 0;
    while (numberToDivide > 0)
    {
        reverseNumber = reverseNumber * 10 + numberToDivide % 10;
        numberToDivide /= 10;
    }
    return reverseNumber == number;
}

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The numer {number} is " + (IsPalindrome(number)?"":"not ") + "a palindrome.");
*/
/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double LineLength3D (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xProjectionLength = x2 - x1;
    double yProjectionLength = y2 - y1;
    double zProjectionLength = z2 - z1;
    double result = Math.Sqrt(Math.Pow(xProjectionLength, 2) + Math.Pow(yProjectionLength, 2) + Math.Pow(zProjectionLength, 2));

    return result;
}

Console.Write("Enter X coordinate of the 1st point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y coordinate of the 1st point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Z coordinate of the 1st point: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter X coordinate of the 2st point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y coordinate of the 2st point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Z coordinate of the 2st point: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The length of the line is " + Math.Round(LineLength3D(x1, y1, z1, x2, y2, z2), 2));