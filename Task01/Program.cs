
int[] array = new int[20];
CreateArray(array);
PrintArray(array);

void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }

}

int FindEvenNum (int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2==0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine();
Console.WriteLine($"Колличество чётных элементов в массиве {FindEvenNum(array)}");