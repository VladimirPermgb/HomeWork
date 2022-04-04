// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8

//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int stolb = 4;
int strok = 4;
int[,] massiv = new int[stolb, strok];
int[] srarifm = new int[stolb];
int sum = 0;

for (int i = 0; i < stolb; i++)
{
    for (int j = 0; j < strok; j++)
    {
        massiv[i, j] = new Random().Next(1, 5);
        Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
}

int c = 0;
for (int i = 0; i < stolb; i++)
{

    for (int j = 0; j < strok; j++)
    {
        srarifm[c] = massiv[c, j] + srarifm[c];
    }
    Console.WriteLine($"Сумма чисел строки {i + 1}: " + srarifm[c]);
    Console.WriteLine();
    c++;
}
int min = srarifm[0];
for (int i = 0; i < strok; i++)
{
    if (srarifm[i] < min) min = srarifm[i];
}
Console.WriteLine("min=" + min);



Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)
75(0,1,0) 31(0,1,1)
45(1,0,0) 53(1,0,1)
32(1,1,0) 23(1,1,1)

Задача 4: Заполните спирально массив 4 на 4.

На выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
