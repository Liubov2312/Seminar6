// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число М");
int M = Convert.ToInt32(Console.ReadLine());
var array = FillArray(M);
Print(array);
Console.WriteLine();
Console.Write($"чисел больше 0 : {CountMoreZero(array)}");

int CountMoreZero(int[] array)
{
    int count = 0;
    foreach(int item in array)
    {
        if(item >= 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}

