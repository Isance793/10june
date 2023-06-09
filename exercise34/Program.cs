//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2




using System;

class Program
{
    static void Main(string[] args)
    {
    
        Random random = new Random();

        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000); 
        }

        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чётных чисел в массиве: " + count);

        Console.ReadLine();
    }
}

