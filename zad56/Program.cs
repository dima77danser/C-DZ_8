// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите Кол-во строчек ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows,columns];


void GetArray()
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(0,10);
            
        }
    }
}
void PrintArray(int[,]result)
{
    for (int i = 0; i <result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i,j]);
        }
        Console.WriteLine();
    }
}
int minVulue = int.MaxValue;
 int minIndexRows = 0;
void FindArray()
{  
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
     {  
        for (int j = 0; j <array.GetLength(1); j++)
          {
             sum = sum + array[i,j];
          }
          Console.WriteLine(sum);
          Console.WriteLine($"stroka: {i}");
          if (sum<minVulue)
            {
                minVulue=sum;
                minIndexRows=i;
            }
          sum =0;
     }
     Console.WriteLine();
     Console.WriteLine($"наименьшая сумма элементов в строке номер {minIndexRows}");
}
GetArray();

PrintArray(array);

Console.WriteLine("_________________");
FindArray();



