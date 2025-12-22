namespace DSA;

public static class BinarySearch
{
    public static int Run(int[] sortedArray, int target)
    {
        int low = 0;
        int high = sortedArray.Length - 1;

        while(low < high)
        {
            int mid = low + (high - low) / 2;
            int val = sortedArray[mid];

            if(val == target)
            {
                return mid;
            }
            else if(val > target)
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }

        return -1;
    }
}