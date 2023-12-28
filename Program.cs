// Задача 1: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет
// Пример:
// 4 3 1   (1,2) => 9
// 2 6 9 



// int[,] array = new int [2,3];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }

// }

// Console.WriteLine("Введите индекс строки элемента в двумерном массиве");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите индекс столбца элемента в двумерном массиве");
// int num2 = Convert.ToInt32(Console.ReadLine());

// void FindElementsArray()
// {
//     if (num1+1 >array.GetLength(0) || num2+1 >array.GetLength(1))
//     {
//        System.Console.WriteLine("Такого элемента нет"); 
//     }
// }

// void FindElementsArray1()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i ==num1 && j ==num2)
//             {
//                 System.Console.WriteLine(array[i,j]);
//             }


//         }          

//     }


// }    

// CreateArray();
// PrintArray();
// FindElementsArray();
// FindElementsArray1();





// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Пример:
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2



// int[,] array = new int [3,3];
// int[] array2 = new int [array.GetLength(0)];


// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
    
// }

// void SumElements()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumElement =0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumElement += array[i,j];
            
//         }
            
//     }
// }



// void FindLine()
// {
//     int minIndex = 0;
//     int minSum = 1;
//     for (int i = 0; i < array2.Length; i++)
//     {
//         if(array2[i] <minSum)
//         {
//             minSum =array2[i];
//             minIndex= i;

//         }
//          System.Console.WriteLine("\nСтрока с индексом " + minIndex);
   
              
                 
                   
           
//     }
    
// }

// CreateArray();
// PrintArray();
// SumElements();
// FindLine();


    



