/* DONE Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/*  int [,] Set_array(int N, int M)                  //метод для создания массива из N элементов из целых чисел
{
    int [,] array = new int [(int)N, (int) M];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        for (int j=0;j < M; j++)
        array[i,j] = rnd.Next(0,10);              

    return (array);
}
void Print_array (int [,] array)                    // метод для печатания массива
{
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
      {  for (int j=0; j< array.GetUpperBound(1) + 1; j++)
         { Console.Write($"{array[i,j]} \t");}
        Console.WriteLine();
      }     
} 

Console.WriteLine("ВВедите число элементов массива в формате NxM: ");         //здесь просим ввести число элементов
string ? s = Console.ReadLine();
string [] numbs = s.Split('x');

int N = Convert.ToInt32(numbs[0]);         // количество строк
int M = Convert.ToInt32(numbs[1]);         // количество столбцов

int [,] array = Set_array(N,M);          //создаем массив

int [] sort_array = new int [M];         //массив для сортировки
Console.WriteLine("Созданный массив:");
Print_array(array);
Console.WriteLine();

for (int i = 0; i < N; i++)
{
    
    for (int j = 0; j < M; j++)
    {
        sort_array[j] = array[i,j];
       
    }
    Array.Sort(sort_array);
    
    for (int j = 0; j < M; j++)
    {
        array[i,j] = sort_array[M-1-j];
        
    }
}
Console.WriteLine("Отсортированный массив:");
Print_array(array);
 */

/*DONE Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

 /*  int [,] Set_array(int N, int M)                  //метод для создания массива из N элементов из целых чисел
{
    int [,] array = new int [(int)N, (int) M];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        for (int j=0;j < M; j++)
        array[i,j] = rnd.Next(-10,10);              

    return (array);
}

void Print_array (int [,] array)                    // метод для печатания массива
{
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
      {  for (int j=0; j< array.GetUpperBound(1) + 1; j++)
         { Console.Write($"{array[i,j]} \t");}
        Console.WriteLine();
      }     
}


Console.WriteLine("ВВедите число элементов массива в формате NxM: ");         //здесь просим ввести число элементов
string ? s = Console.ReadLine();
string [] numbs = s.Split('x');

int N1 = Convert.ToInt32(numbs[0]);         // количество строк
int M1 = Convert.ToInt32(numbs[1]);         // количество столбцов

int [,] array1 = Set_array(N1,M1);          //создаем массив
int [] arr_result = new int [N1];           // массив для результата

for (int i = 0; i < N1; i++)
{
    for (int j= 0; j < M1; j++)
    {
        arr_result[i] += array1[i,j];
    }
    
}
Console.WriteLine("Созданный массив:");
Print_array (array1);

Console.WriteLine();

int min = arr_result[0];
int min_index = 0;
for (int i = 0; i < arr_result.Length; i++)
{
    if (arr_result[i] < min)  
    {   min = arr_result[i];
        min_index = i;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов:{min_index}"); */
//конец задачи

/* DONE Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
/* 
 int [,] Set_array(int N, int M)                  //метод для создания массива из N элементов из целых чисел
{
    int [,] array = new int [(int)N, (int) M];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        for (int j=0;j < M; j++)
        array[i,j] = rnd.Next(-10,10);              

    return (array);
}

void Print_array (int [,] array)                    // метод для печатания массива
{
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
      {  for (int j=0; j< array.GetUpperBound(1) + 1; j++)
         { Console.Write($"{array[i,j]} \t");}
        Console.WriteLine();
      }     
}
Console.WriteLine("ВВедите число элементов массива 1 в формате NxM: ");         //здесь просим ввести число элементов
string ? s1 = Console.ReadLine();
string [] numbs1 = s1.Split('x');

int N1 = Convert.ToInt32(numbs1[0]);         // количество строк
int M1 = Convert.ToInt32(numbs1[1]);         // количество столбцов
int [,] array1 = Set_array(N1,M1);          //создаем массив 1

Console.WriteLine("ВВедите число элементов массива 2 в формате NxM: ");         //здесь просим ввести число элементов
string ? s2 = Console.ReadLine();
string [] numbs2 = s2.Split('x');

int N2 = Convert.ToInt32(numbs2[0]);         // количество строк
int M2 = Convert.ToInt32(numbs2[1]);         // количество столбцов
int [,] array2 = Set_array(N2,M2);          //создаем массив 2

if (M1 != N2)
{
    Console.WriteLine("Такие матрицы невозможно перемножить!");
}  

 Console.WriteLine("Созданный массив 1:");
Print_array (array1);
Console.WriteLine();

Console.WriteLine("Созданный массив 2:");
Print_array (array2);
Console.WriteLine();

int [,] arr_result = new int [N1,M2];         //создаем массив для результата

for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < M2; j++)
    {
        for (int k = 0; k < N2; k++)
        {
          arr_result[i,j] += array1[i,k]*array2[k,j];
        }
    }
}

Console.WriteLine("Перемножение двух массивов:");
Print_array (arr_result);
Console.WriteLine(); */
 //конец задачи

/* DONE Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

/* int [,,] Set_array(int N, int M, int K)                  //метод для создания массива из N элементов из целых чисел
{
    int [,,] array = new int [(int)N, (int) M, (int) K];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        for (int j=0;j < M; j++)
           for (int k = 0; k < K; k++)
              {
               array[i,j,k] = rnd.Next(10,100);  
             }
                    

    return (array);
}
void Print_array (int [,,] array)                    // метод для печатания массива
{
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
      {  
        for (int j=0; j< array.GetUpperBound(1) + 1; j++)
            { 
             for (int k = 0; k < array.GetUpperBound(2)+1; k++)
             {
                 Console.Write($"{array[i,j,k]} ({i},{j},{k}) \t");
             }    
               Console.WriteLine(); 
            }
         Console.WriteLine();    
      }     
}
Console.WriteLine("ВВедите число элементов массива в формате NxMxK: ");         //здесь просим ввести число элементов
string ? s = Console.ReadLine();
string [] numbs = s.Split('x');

int N = Convert.ToInt32(numbs[0]);         // количество строк
int M = Convert.ToInt32(numbs[1]);         // количество столбцов
int K = Convert.ToInt32(numbs[1]);         
int [,,] array = Set_array(N,M,K);          //создаем массив 
Print_array (array); */
//конец задачи
/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int [,] array = new int [4,4];
int N=4;
int i=0;
int x = 0;
int y = -1;
int d_row = 0;
int d_column  = 1;

while (i <N*N)
{   
    if ((x+d_row >=0) && (x+d_row <N) && (y+d_column < N) && (y+d_column >= 0) && (array[x+d_row,y+d_column]==0))
   { x += d_row;
     y += d_column;
     i++;
     array[x,y] = i;
    
   }
   else
   {
    if (d_column==1) 
    {
        d_column=0;
        d_row =1;
    }
    else if(d_row ==1) 
    {
        d_row =0;
        d_column =-1;
    }
    else if (d_column ==-1)
    {
        d_column =0;
        d_row =-1;
    }
    else if (d_row == -1)
    {
        d_row =0;
        d_column =1;
    }
   }

}
void Print_array(int[,] array)                    // метод для печатания массива
{
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
        { Console.Write($"{array[i, j]} \t"); }
        Console.WriteLine();
    }
}
Print_array(array);