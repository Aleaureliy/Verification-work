string[] GetArray(int length) // Создание массива
{
    string[] array = new string[length];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите строку: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] CheckArray(string[] array) // Проверка массива и создание результирующего массива
{
    string[] result = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            result[i] = array[i];
        }
    }
    return result;
}

void PrintArray(string[] array) // Проверка введенного массива
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

string[] DeleteThisWord(string word, string[] array) // Удаление пустых элементов из результирующего массива
{
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == word)
            {
                array[i] = null;
                array = array.Where(x => x != null).ToArray();
            }
        }
    return array;
}

Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine()); // Задаем длинну масства
string[] array = GetArray(length); // Создаем массив строк
PrintArray(array); // Печатаем массив
string[] result = CheckArray(array);
Console.WriteLine();
string del = null;
string[] finalResult = DeleteThisWord(del, result);
PrintArray(finalResult);