// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Попытка самой решить, напридумывала всякого, но не получилось.

// Console.WriteLine("Первую размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторую размерность массива");
// int coloms = Convert.ToInt32(Console.ReadLine());
// int maxNum = matrix[0, j];
// int[,] matrix = new int[rows, coloms];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     if (matrix[1, j] > maxNum)
//     {
//         maxNum = matrix[1, j];
//         i++;
//     }
//     int changer = matrix.GetLength(0) - 1;
//     int temp = matrix[0, j];
//     matrix[0, j] = matrix[changer, j];
//     matrix[changer, j] = temp;
// }
// Console.WriteLine();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// } /что то я намудрила((

//Решение

int[,] matrix = new int[3, 4];
CreateArrayRandom(matrix);
PrintArray(matrix);
SortToLower(matrix);
Console.WriteLine();
PrintArray(matrix);

void CreateArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
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


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] matrix = new int[4, 4];
CreateArrayRandom(matrix);
PrintArray(matrix);
Console.WriteLine();
MinSumElementsRow(matrix);
Console.WriteLine();

void CreateArrayRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void MinSumElementsRow(int[,] array)
{
    int minRow = 0;
    int minSumElements = 0;
    int sumElements = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumElements += matrix[i, j];
        if (sumElements < minRow)
        {
            minRow = sumElements;
            minSumElements = i;
        }
        sumElements = 0;
    }
    Console.Write($"{minSumElements + 1} строка");
}

// Попытка придумать решение: 

// void MinSumElementsRow(int[,] array)
// {
//     for (int int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             if (array[i] < 4)
//             {
//                 int rowNumber = 1
//                 int sumElements = +;
//             }
//         }
//     }
// }

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


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array3D = new int[2, 2, 2];
CreateArray(array3D);
PrintIndex(array3D);

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void CreateArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}