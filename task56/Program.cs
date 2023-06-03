// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
MinSummaArray(array);

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

 void MinSummaArray(int[,] arr)
{
        int[] result = new int[arr.GetLength(0)];
for (int i = 0; i < arr.GetLength(0); i++)
  {  
int temp=0;
for (int j = 0; j < arr.GetLength(1); j++)
        {
            temp=temp+arr[i,j];
        }
     result[i]=temp;
     //Console.WriteLine($" сумма {i} строки {result[i]}");
  }
  int number=0;
  int min=result[0];
    for (int k=1; k < arr.GetLength(0); k++)
    {
        //Console.WriteLine($" {result[k]} {result[k-1]} {k} ");
        if (result[k] < min)  
        {
            min=result[k];
            number=k;
        }
//        Console.WriteLine(number);
    }
   Console.WriteLine($"Первый номер строки (c №1) с наименьшей суммой элементов: {number+1}");
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