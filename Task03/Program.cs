// программа которая находит разницу между максимальным и минимальным элементом массива
int[] array = new int[10];
CreateArray(array);
PrintArray(array);

void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }

}

int FindMax(int[] array)
{
    int max = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}



int FindMin(int[] array)
{
    int min=array[0];
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]<min)
        {
            min = array[i];
        }
    }
    return min;
}
System.Console.WriteLine();

int result = FindMax(array)-FindMin(array);
System.Console.WriteLine($"Разница между максимальным и минимальным {result}");