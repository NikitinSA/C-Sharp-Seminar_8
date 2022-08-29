/*Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int lines = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[lines, columns];

FillArray(array, lines, columns);
PrintArray(array);
Console.WriteLine();
ReplacingThePlacesOfTheFirstAndLastLine(array);
PrintArray(array);

void FillArray(int[,] array, int lines, int columns)
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReplacingThePlacesOfTheFirstAndLastLine(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}