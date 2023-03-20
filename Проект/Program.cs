string[] GetArray()
{
    Console.Write("Введите количество строк в массиве: ");
    int length = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write("Введите элемент массива под номером " + Convert.ToString(i) + ": ");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return array;
}

void PrintArray(string[] array, string text)
{
    Console.Write(text);
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(", ");
        if (i == array.Length - 1) Console.Write("]");
    }
    Console.WriteLine();
}

string[] LessThanFour(string[] strArray)
{
    int arrayLength = strArray.Length;
    int maxStrLength = 3;
    int counter = 0;
    string[] secAnswer = {string.Empty};
    for (int i = 0; i < arrayLength; i++)
    {
        if (strArray[i].Length <= maxStrLength)
        {
            counter++;
        }
    }
    if (counter > 0)
    {
        string[] newArray = new string[counter];
        counter = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            if (strArray[i].Length <= maxStrLength)
            {
                newArray[counter] = strArray[i];
                counter++;
            }
        }
        return newArray;
    }
    else
    {
        return secAnswer;
    }
}

string[] array = GetArray();
PrintArray(array, "Введенный массив: ");
string[] newArray = LessThanFour(array);
PrintArray(newArray, "Решение задачи: ");