namespace SelectionSort;

internal static class SelectionSort
{
    public static void SelectionSortAlgorithm(IList<int> arr)
    {
        var n = arr.Count;

        for (var i = 0; i < n - 1; i++)
        {
            // Find the minimum element in the remaining unsorted array
            var minIndex = i;

            for (var j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the element at index i
            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
        }
    }
}