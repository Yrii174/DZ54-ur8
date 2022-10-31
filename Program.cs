/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
Console.WriteLine("Введите количество строк в массиве: "); 
int m = int.Parse(Console.ReadLine()); 
Console.WriteLine("введите количество столбцов: "); 
int n = int.Parse(Console.ReadLine());
int[,] CreatArray(int m, int n) 
{     
int[,] array1 = new int[m, n];     
Random rnd = new Random();     
for (int i = 0; i < array1.GetLength(0); i++)     
    {        for (int j = 0; j < array1.GetLength(1); j++)         
             {      array1[i, j] = rnd.Next(0, 10);         
             }     
    }     return array1; 
}
string ArrayToString(int[,] array1) 
{   string result = string.Empty;
    for (int i = 0; i < array1.GetLength(0); i++) 	
    { 		for (int j = 0; j < array1.GetLength(1); j++)
     		{ 			
                result += $"{array1[i, j]} "; 		
            }  		
            result += Environment.NewLine; 	
    }  	return result;
}
void ResultArray(int[,] array1) 
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1) - 1; k++)
            {
                if (array1[i, k] < array1[i, k + 1])
                {   int temp = array1[i, k + 1];
                    array1[i, k + 1] = array1[i, k];
                    array1[i, k] = temp; }
            }
        }
    }
}
void PrintArray(int[,] array1) 
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {   for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]} ");
        }        Console.WriteLine();
    }
}

int [,] array1 = CreatArray(m,n);  
Console.WriteLine("Ваш массив: ");
Console.WriteLine(ArrayToString(array1));
ResultArray(array1); 
Console.WriteLine("Выводим упорядоченный массив (по убыванию элементы каждой строки):");
PrintArray(array1);
