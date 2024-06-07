using System;

namespace StringFilterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя ввод строк, разделённых запятыми
            Console.WriteLine("Введите строки, разделённые запятыми:");
            string input = Console.ReadLine(); // Считываем введённую строку

            // Разделяем введённую строку на массив строк по запятым
            string[] initialArray = input.Split(',');

            // Фильтруем строки длиной меньше или равной 3 символам
            string[] filteredArray = FilterShortStrings(initialArray);

            // Выводим отфильтрованные строки
            Console.WriteLine("Отфильтрованные строки:");
            foreach (string str in filteredArray)
            {
                Console.WriteLine(str);
            }
        }

        // Метод для фильтрации строк длиной меньше или равной 3 символам
        static string[] FilterShortStrings(string[] inputArray)
        {
            int count = 0;
            foreach (string str in inputArray)
            {
                if (str != null && str.Trim().Length <= 3) // Учитываем строки с пробелами по краям
                {
                    count++;
                }
            }

            string[] resultArray = new string[count];
            int index = 0;
            foreach (string str in inputArray)
            {
                if (str != null && str.Trim().Length <= 3)
                {
                    resultArray[index] = str.Trim(); // Удаляем пробелы по краям строки
                    index++;
                }
            }

            return resultArray;
        }
    }
}    