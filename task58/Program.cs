// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк матрицы 1: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов матрицы 1: ");
int columns1 = int.Parse(Console.ReadLine()!);
int rows2;
do
{
Console.Write("Введите количество строк матрицы 2: ");
rows2 = int.Parse(Console.ReadLine()!);
if (rows2 != columns1) 
{
    Console.WriteLine ("Нельзя выполнить умножение на такую матрицу");
    Console.WriteLine ("Подсказка: Количество строк матрицы 2 должно быть равно ");
    Console.WriteLine ($"количеству столбцов матрицы 1, например, {columns1}");
}
}
while (rows2 != columns1);

Console.Write("Введите количество столбцов матрицы 2: ");
int columns2 = int.Parse(Console.ReadLine()!);


int[,] array1 = GetArray(rows1, columns1, 0, 10);
PrintArray(array1);
Console.WriteLine();

int[,] array2 = GetArray(rows2, columns2, 0, 10);
PrintArray(array2);

int[,] proizvArray1Array2;
proizvArray1Array2 = ProizvMatric(array1, array2);
Console.WriteLine();
PrintArray(proizvArray1Array2);


int[,] ProizvMatric(int[,] arr1, int[,] arr2)
{
    int rowsA = arr1.GetLength(0);
    int columnsB = arr2.GetLength(1);
    int[,] result = new int[rowsA, columnsB];
        for (int i=0; i<rowsA; i++)
        {
            for (int j=0; j<columnsB; j++)
            {
                for (int n=0; n<arr1.GetLength(1); n++)
                {
                    result[i, j] += arr1[i, n] * arr2[n, j];
                }
            }
        }

    return result;
}


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


