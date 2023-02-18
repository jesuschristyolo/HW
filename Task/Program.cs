using static System.Console;
Clear();


string[] arrayOfStrings = Convert("Введите элементы массива строк через точку с запятой и пробел: ");
string[] arrayOfSymbols = SymbolsArray(arrayOfStrings);

WriteLine("массив из введенных элементов: ");
PrintArray(arrayOfStrings);

WriteLine(" массив из 3 и меньше элементов: ");
PrintArray(arrayOfSymbols);



string[] Convert(string spl)
{
    Write(spl);
    return ReadLine().Split("; ");
}



string[] SymbolsArray(string[] array)
{
    int count = 0;
    string[] temp = new string[count];
    string[] res = temp;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
            temp = new string[count];
            for (int j = 0; j < temp.Length - 1; j++)
            {
                temp[j] = res[j];
            }
            temp[count - 1] = array[i];
            res = temp;
        }
    }
    return res;
}

void PrintArray(string[] array)
{
    string separator = "[";
    if (array.Length > 0)
    {
        separator += "\"" + array[0] + "\"";
        for (int i = 1; i < array.Length; i++)
        {
            separator += ", \"" + array[i] + "\"";
        }
    }
    separator += "]";
    Write(separator);
}

