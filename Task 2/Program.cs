/*Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int lines = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (lines < columns || columns < lines)
{
    Console.Write("Действие с массивом невозможно");
}
else
{
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
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i; j < array.GetLength(1); j++)
            {

                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;

            }
        }
    }
}