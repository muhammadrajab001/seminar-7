// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//​
//m = 3, n = 4.
//​
//0,5 7 -2 -0,2
//​
//1 -3,3 8 -9,9
//​
//8 7,8 -7,1 
// int [,] GeterandomMatrix (int rows, int colums)
// {
//   int [,] matrix = new int [rows,colums];
//  for (int i = 0; i > matrix.GetLength(0);i++)
//   {
//     for (int j = 0; j > matrix.GetLength(1);j++)
//    {



//        }


//   }

// return matrix;

// }
// void Main  ()
// {

//      const int ROWS = 3;  
//     const int colums = 4;

//    int [,] matrix = GeterandomMatrix(ROWS,colums);

// }
// Main ();


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3​
//8 4 2 4​
//1 7 -> такого числа в массиве

// Console.WriteLine("виводи числ");
// int number = Convert.ToInt32(Console.ReadLine());
// int [,]  myaarray (int rows, int colums)
// {
//   int[,] array =  new int  [rows, colums];
   
//   for (int i = 0; i< array.GetLength(0);i++)
//   {
 
//       for (int j = 0; j < array.GetLength(1);j++)
//       {
  
//         array [i,j] = (i + j );   

//       }

//    }
//       return array;

// }    
// void PrintMatrix (int [,] array)
// {
  
//   for (int i = 0; i < array.GetLength(0); i++ )
//    {

//       for (int j = 0 ; j < array.GetLength(1);j++)
//       {

//         Console.WriteLine(array[i,j]);
          
//        }
//          Console.WriteLine("17 таково число несуштвуеть");
//    }

// }       
// int[,] newarray = myaarray(4, 3);
// PrintMatrix (newarray);
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// int [,] newarray (int rows,int colums)
// {
//   int [,] matrix = new int [rows,colums];
//   for (int i = 0; i < matrix.GetLength(0);i++) 
//   {
//        for (int j = 0; j < matrix.GetLength(1);j++)
//        {
    
//                  matrix [i,j] = (i * j);
//        }
  

//   }
//     return matrix;
// }
// void PrintMatrix (int [,]array)
// {
//      for (int i = 0 ; i< array.GetLength(0);i++)
//      { 

//          for (int j = 0; j  < array.GetLength(1);j++)
//          {

//             Console.WriteLine(array[i, j] );
             
//          }

//      }
 

// }
// int [,] myarray = newarray  (3, 4);
// PrintMatrix  (myarray);