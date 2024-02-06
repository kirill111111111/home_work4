using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(array, array.Length - 1);

        Console.ReadLine(); // Чтобы консольное окно не закрылось сразу
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{array[index]} ");
            PrintArrayReverse(array, index - 1);
        }
    }
}