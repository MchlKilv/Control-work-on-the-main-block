// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

string[] inputArray = new string[] { "Hello", "2", "world", ":-)" };
//string[] inputArray = new string[] { "1234", "1567", "-2", "computer science" };
//string[] inputArray = new string[] { "Russia", "Denmark", "Kazan" };

string[] resultArray = SelectionByLength(inputArray, 3);
Console.WriteLine($"Исходный массив: ['{string.Join("', '", inputArray)}']");
Console.WriteLine($"Полученный массив: ['{string.Join("', '", SelectionByLength(resultArray, 3))}']");

string[] SelectionByLength(string[] inputArray, int maxLength)
{
    int count = 0;

    // Сначала определяем, сколько элементов у нас будет в итоговом массиве
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= maxLength)
            count++;
    }

    // Создаем новый массив с подходящими элементами
    string[] resultArray = new string[count];
    int index = 0;

    // Копируем подходящие элементы в новый массив
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= maxLength)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }

    return resultArray;
}