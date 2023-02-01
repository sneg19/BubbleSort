/* Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]
*/

/*
1, Задать рандомный массив;
2, Сортировать массив методом пузырька;
3, Вывести в консоль сгенерированный массив и отсортированный массив;
*/

int[] GetArray(int min_value, int max_value)
{
    Random TempRandom = new Random();
    int size = TempRandom.Next(6, 12); 
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = TempRandom.Next(min_value, max_value);
    }
    return res;
}


/*
int[] Sortirovka(int[] SortArray)
{
    for (int index = 0; index < SortArray.Length; index++)
    {
        if(SortArray[SortArray.Length - index - 1] < SortArray[SortArray.Length - index - 2]) SortArray[index] = SortArray[SortArray.Length - index - 1]; 
    }
    return SortArray;
}
*/


int[] BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
    }
    return inArray;
}




void Main()
{
int[] OurArray = GetArray(0, 50);
int[] SortArray = BubbleSort(OurArray);
Console.WriteLine($"[{String.Join(" ", OurArray)}] -> [{String.Join(" ", SortArray)}]");
}

Main();

