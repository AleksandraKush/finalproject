string[] GetArray(int num)
{
    string[] array = new string [num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("введите элемент");
        array[i] = (Convert.ToString(Console.ReadLine()));
    }
    return array;
}

Console.WriteLine("введите количество элементов, которое собираетесь вводить");
int size = Convert.ToInt32(Console.ReadLine());
string[] array4 = GetArray(size);
Console.WriteLine();