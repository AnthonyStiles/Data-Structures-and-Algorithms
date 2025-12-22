namespace DSA;

public static class JumpSearch
{
    public static int Run(int[] array)
    {
        int jumpAmount = (int)Math.Floor(Math.Sqrt(array.Length));

        int i = jumpAmount;
        for (; i <= array.Length; i += jumpAmount)
        {
            if (array[i] == 1)
            {
                break;
            }
        }

        i -= jumpAmount;

        for (int j = 0; j <= jumpAmount && i < array.Length; j++, i++)
        {
            if (array[i] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}