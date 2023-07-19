
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArray = Console.ReadLine().Split();

        // Фильтрация массива строк
        string[] resultArray = FilterStrings(inputArray);

        // Вывод результата
        Console.WriteLine("Массив строк длиной <= 3 символов:");
        foreach (string str in resultArray)
        {
            Console.Write(str + " ");
        }
    

    static string[] FilterStrings(string[] inputArray)
    {
        int resultSize = 0;

        // Подсчет количества строк, удовлетворяющих условию
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultSize++;
            }
        }

        // Создание нового массива с размером resultSize
        string[] resultArray = new string[resultSize];

        // Заполнение нового массива
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }

