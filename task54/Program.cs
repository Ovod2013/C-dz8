// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
PrintArray(SortArray(array));

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

 int [,] SortArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
  {  
    int temp;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k=j+1;k < arr.GetLength(1); k++)
        {
            if (arr[i,j] < arr[i,k])
            {
                temp=arr[i,j];
                arr[i,j]=arr[i,k];
                arr[i,k]=temp;
            }
        }   
    }
   Console.WriteLine();
  }
  return arr;
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