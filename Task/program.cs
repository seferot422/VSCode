using System;

class Program
{
    static void Main()
    {
        // Исходный массив строк
        string[] strings = { "apple", "banana", "cat", "dog", "elephant", "fox" };

        // Фильтрация строк
        string[] filteredStrings = FilterStrings(strings);

        // Вывод отфильтрованного массива
        Console.WriteLine("Отфильтрованный массив строк:");
        foreach (string str in filteredStrings)
        {
            Console.WriteLine(str);
        }
    }

    // Функция для фильтрации строк
    static string[] FilterStrings(string[] arr)
    {
        string[] filteredArr = new string[arr.Length];
        int filteredSize = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                filteredArr[filteredSize] = arr[i];
                filteredSize++;
            }
        }
        // Уменьшение размера массива до реального количества элементов
        Array.Resize(ref filteredArr, filteredSize);
        return filteredArr;
    }
}