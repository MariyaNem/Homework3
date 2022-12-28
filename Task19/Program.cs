//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100000 && number > 9999)
{
    int first = number / 10000 % 10;
    int second = number / 1000 % 10;
    int four = number / 10 % 10;
    int five = number % 10;
    
    Console.WriteLine(Palindrome(first, second, four, five) ? "Число является полиндромом" : "Число не является полиндромом");
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}

bool Palindrome(int num1, int num2, int num4, int num5)
{
    return num1 / num5 == 1 && num2 / num4 == 1;
}