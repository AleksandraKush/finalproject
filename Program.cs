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

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
      if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
      else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

string[] FindArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count ++;
    }
    string[] newArr = new string[count];
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i].Length <= 3)
       {
         newArr[k] = arr[i];
         k++;
       }
    }
    return newArr;
}

Console.WriteLine("введите количество элементов, которое собираетесь вводить");
int size = Convert.ToInt32(Console.ReadLine());
string[] array4 = GetArray(size);
Console.WriteLine();
string[] newArray = FindArray(array4);
PrintArray(newArray);