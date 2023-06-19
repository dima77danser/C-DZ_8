﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность первой матрицы: ");
            int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите размерность второй матрицы: ");
            int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("B[{0},{1}] = ", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
 
            Console.WriteLine("\nМатрица A:");
            Print(A);
            Console.WriteLine("\nМатрица B:");
            Print(B);
            Console.WriteLine("\nМатрица C = A * B:");
            int[,] C = Multiplication(A, B);
            Print(C);
 
        }
        static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return r;
        }
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}



// Console.WriteLine("Введите Кол-во строчек ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Кол-во строчек ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int columns2 = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];
// int[,] array2 = new int[rows2,columns2];


// void GetArray(int[,] massiv)
// {
//     for (int i = 0; i <massiv.GetLength(0); i++)
//     {
//         for (int j = 0; j < massiv.GetLength(1); j++)
//         {
//             massiv[i,j]=new Random().Next(0,10);
            
//         }
//     }
// }
// void PrintArray(int[,]result)
// {
//     for (int i = 0; i <result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
// void Proizvedenie(int[,]massiv2)
// {
//    for (int i = 0; i <massiv2.GetLength(0); i++)
//     {
//         for (int j = 0; j < massiv2.GetLength(1); j++)
//          {
//             massiv2[i,j] = 
//          }

//     }


// }
// GetArray(array);
// PrintArray(array);
// Console.WriteLine("_______________");
// GetArray(array2);
// PrintArray(array2);
