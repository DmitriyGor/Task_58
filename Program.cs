/*
Задача 58: 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Write("Введите количество строчек 1-ой матрицы: ");
int rowFirstArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1-ой матрицы: ");
int columnFirstArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("количество сторок 2-ой матрицы = количеству столбцов 1-ой матрицы)");
Console.WriteLine("количество столбцов 2-ой матрицы = количеству строк 1-ой матрицы)");
int rowSecondArray = columnFirstArray;
int columnSecondArray = rowFirstArray;
Console.WriteLine();

Console.Write("Введите число (нижний диапазон) для заполнения элементами массивы  : ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число (верхний диапазон) для заполнения элементами массивы  : ");
int maxElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] firstArray = new int[rowFirstArray, columnFirstArray];
CreateArray(firstArray);
Console.WriteLine($"Первая матрица:");
WriteArray(firstArray);
Console.WriteLine();

int[,] secondArray = new int[rowSecondArray, columnSecondArray];
CreateArray(secondArray);
Console.WriteLine($"Вторая матрица:");
WriteArray(secondArray);
Console.WriteLine();

int[,] resMatrix = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
GetProductMatrix (firstArray, secondArray, resMatrix);
Console.WriteLine($"Произведение двух матриц:");
WriteArray(resMatrix);

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(minElement, maxElement+1);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void GetProductMatrix (int [,]firstArray, int [,]secondArray, int[,]resMatrix)
{  
    // строчки = количеству строк из первой матрицы(i), 
    // столбцы = количеству столбцов из второй матрицы(j).
    for (int i = 0; i < firstArray.GetLength(0); i++) // строчки первой матрицы
    {
       for (int j = 0; j < secondArray.GetLength(1); j++) // столбцы второй матрицы
       {
            for (int k = 0; k < firstArray.GetLength(1); k++) // столбцы первой матрицы
            {
                resMatrix[i, j] += firstArray[i, k] * secondArray[k, j];
                // resMatrix[i, j] = resMatrix[i, j] + firstMatrix[i, k] * secondMatrix[k, j]
            }
       } 
    }
    return;
}