//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random random = new Random();

        
        int[] numbers = new int[10]; 
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100); 
        }

        
        int sum = 0;
        for (int i = 1; i < numbers.Length; i += 2) 
        {
            sum += numbers[i];
        }

        
        Console.WriteLine("Сумма элементов на нечетных индексах: " + sum);

        Console.ReadLine();
    }
}

