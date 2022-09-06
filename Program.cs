string[] arr = { "hello", "2", "world", ":-)"};

string [] SelectChar(string[] array)
{
    string[] newArray = new string[array.GetLength(0)];
    for (int i = 0; i < array.Length; i++)
    {

        if (arr[i].Length <= 3)
            newArray[i] = array[i];
        

    }
    return newArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

ShowArray(arr);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа");
ShowArray(SelectChar(arr));