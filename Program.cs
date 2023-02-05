/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
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