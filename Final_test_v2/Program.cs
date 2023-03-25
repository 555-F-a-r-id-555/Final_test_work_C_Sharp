string[] InputArray()
{
    Console.WriteLine($"Введите длину(size) массива: ");
    string size = Console.ReadLine();
    int size1;
    if (int.TryParse(size, out size1))
    {
        if (size1 > 0) Console.WriteLine($"size = {size1}");
        else size1 = 0;
    }
    else Console.WriteLine("Ваш массив состоит из ноль элементов.");
    string[] input = new string[size1];
    Console.WriteLine($"Вводите каждый элемент массива с новой строки: ");
    int i = 0;
    while (i < size1)
    {
        input[i] = Console.ReadLine();
        i++;
    }
    return input;
}

string[] CreatNewArray(string[] array)
{
    PrintArray(array);
    int size = 0;
    foreach (var item in array)
    {
        if (item.Length <= 3) size++;
    }
    string[] newString = new string[size];
    int i = 0;
    foreach (var item in array)
    {
        if (item.Length <= 3)
        {
            newString[i] = item;
            i++;
        }
    }
    Console.Write(" -> ");
    PrintArray(newString);
    Console.WriteLine();

    return newString;
}

void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        Console.Write($"\"{array[array.Length - 1]}\"");
        Console.Write($"]");
    }
    else Console.Write($"[]");
}



string[] newString = InputArray();
// PrintArray(newString);
CreatNewArray(newString);