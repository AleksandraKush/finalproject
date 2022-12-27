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

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
      if(i < array.Length - 1) Console.Write($"{array[i]}, ");
      else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


Console.WriteLine("введите количество элементов, которое собираетесь вводить");
int size = Convert.ToInt32(Console.ReadLine());
string[] array4 = GetArray(size);
Console.WriteLine();
