// программа которая находит сумму элементов, стоящих на нечётных позициях
int[] array = new int[10];
CreateArray(array);
PrintArray(array);

void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 5);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }

}

int SumArray (int[]array)
{
    int sum =0;
    for(int i=0; i<array.Length; i++)
    {
        if(i%2!=0)
        {
          sum = sum + array[i];
        }
    }
    return sum;
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива на нечётных позициях {SumArray(array)}");