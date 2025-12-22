namespace DSA;

public static class QuickSort
{
    public static void Run(int[] array, int start, int end)
    {
        if(end <= start)
        {
            return;
        }

        int pivot = partition(array, start, end);
        Run(array, start, pivot - 1);
        Run(array, pivot + 1, end);
    }

    private static int partition(int[] array, int start, int end)
    {
        int pivot = array[end];
        int j = start - 1;

        for (int i = start; i <= end - 1; i++)
        {
            if(array[i] < array[end])
            {
                j++;
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }

        j++;
        int temp2 = array[j];
        array[j] = array[end];
        array[end] = temp2;

        return j;
    }
}