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
        // string[] newArray = array;
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


string[] x1 = { "hello", "2", "world", ":-)" };
string[] x2 = { "1234", "1567", "-2", "computer science" };
string[] x3 = { "Russia", "Denmark", "Kazan" };
CreatNewArray(x1);
CreatNewArray(x2);
CreatNewArray(x3);