int[] arr = { 64, 25, 12, 22, 11 };

Console.WriteLine("Original array:");
PrintArray(arr);

SelectionSort.SelectionSort.SelectionSortAlgorithm(arr);

Console.WriteLine("\nSorted array:");
PrintArray(arr);

static void PrintArray(IEnumerable<int> arr)
{
    foreach (var num in arr)
    {
        Console.Write(num + " ");
    }

    Console.WriteLine();
}