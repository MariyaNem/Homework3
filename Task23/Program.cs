//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//5 ->
//1 | 1
//2 | 8
//3 | 27
//4 | 64
//5 | 125

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    TableCube(number);
}
else Console.Write("Введено не натуральное число");

void TableCube(int num)
{
    int index = 0;
    while (index <= num)
    {
        Console.WriteLine($"{index,4} {Math.Pow(index, 3), 8}");
        index++;
    }
}
