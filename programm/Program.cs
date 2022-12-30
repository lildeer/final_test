try
{
    string list = Console.ReadLine();
    string[] array = list.Split(", ");
    string[] newar = NewArray(array);
    foreach (string el in newar)
        System.Console.Write($"{el} ");
}

catch
{ System.Console.WriteLine("Error"); }

string[] NewArray(string[] array)
{
    int k = 0;
    foreach (string el in array)
        if (el.Length <= 3) k++;
    string[] newar = new string[k];
    k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) { newar[k] = array[i]; k++; }
    };
    return newar;
}