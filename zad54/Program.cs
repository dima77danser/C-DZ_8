// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
void PrintArray()
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
}
void ChangArray()
{
    for (int i = 0; i <array.GetLength(0); i++)
    {      
        int temp;
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            while (array[i,j]<array[i,j+1])
            {
                temp = array[i,j+1];
                array[i,j+1] = array[i,j];
                array[i,j] = temp;
                
            }
           
        } 
        
    }
}

GetArray();
PrintArray();
ChangArray();
Console.WriteLine("_________________");
PrintArray();






// 53. Задайте двумерный массив.Напишите программу кот
// поменяет местами 1 и последнюю строку массива

// Console.WriteLine("Введите Кол-во строчек ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];

// void GetArray()
// {
//     for (int i = 0; i <array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]=new Random().Next(0,10);
//         }
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i <array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             //double i = new Random().NextDouble()+new Random().Next();
//             Console.Write(array[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
// void ChangArray()
// {
//     int maxIndex = array.GetLength(0)-1;
//     for (int j = 0; j <array.GetLength(1); j++)
//     {
//         int temp = array[0,j];
//         array[0,j]=array[maxIndex,j];
//         array[maxIndex,j]=temp;
        
//     }
// }

// GetArray();
// PrintArray();
// ChangArray();
// Console.WriteLine("_________________");
// PrintArray();



//55. Задайте двумерный массив . Напишитепрог
//кот заменяет строки на столбцы. если это невозможно
//выводим сообшение.

// Console.WriteLine("Введите Кол-во строчек ");
// int rows = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,rows];
// int [,] array2 = new int[array.GetLength(0),array.GetLength(1)];

// void GetArray()
// {
//     for (int i = 0; i <array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]=new Random().Next(0,10);
//         }
//     }
// }
// void PrintArray(int[,]result)
// {
//     for (int i = 0; i <result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             //double i = new Random().NextDouble()+new Random().Next();
//             Console.Write(result[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
// void ChangArray()
// {  for (int i = 0; i < array.GetLength(0); i++)
//      {
//        for (int j = 0; j < array.GetLength(1); j++)
//          {
//            array2[j,i]=array[i,j];
//          }
//      }
// }

// GetArray();
// PrintArray(array);
// ChangArray();
// Console.WriteLine("_________________");
// PrintArray(array2);

// 59. Задайте двумерный массив. Напишите прог кот удалит
//строку и столбец, на пересечении кот расположен
// наименьший элемент массива

// Console.WriteLine("Введите Кол-во строчек ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];
// int minVulue = int.MaxValue; //max число в int,,, 
// int minIndexRows = 0;
// int minIndexColumns = 0; 

// void GetArray()
// {
//     for (int i = 0; i <array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]=new Random().Next(0,10);
//             if (array[i,j]<minVulue)
//             {
//                 minVulue=array[i,j];
//                 minIndexRows=i;
//                 minIndexColumns=j;
//             }
//         }
//     }
// }
// void PrintArray(int[,]result)
// {
//     for (int i = 0; i <result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             //double i = new Random().NextDouble()+new Random().Next();
//             Console.Write(result[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
// void ChangArray()
// {  
//     for (int i = 0; i < array.GetLength(0); i++)
//      {
//         if (i!= minIndexRows)
//          {
//            for (int j = 0; j < array.GetLength(1); j++)
//            {
//               if (j!=minIndexColumns)
//                  {
//                   Console.Write(array[i,j]);
//                  }
//            }
             
//          }
//          Console.WriteLine();
//      }
// }

// GetArray();
// PrintArray(array);

// Console.WriteLine("_________________");
// ChangArray();