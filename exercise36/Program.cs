//Задача 38: Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и минимальным элементов массива.




using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random random = new Random();

        
        double[] numbers = new double[10]; 
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.NextDouble() * 100; 
        }

        
        double max = numbers[0];
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        
        double difference = max - min;

        
        Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);

        Console.ReadLine();
    }
}
