class Program
{
    /// <summary>
    /// Finds an index N where the sum of the integers to the left 
    /// of N is equal to the sum of the integers to the right of N. 
    /// If there is no index that would make this happen, return -1.
    /// </summary>
    /// <param name="arr">Input Int32 array</param>
    /// <returns>required index</returns>
    public static int FindEvenIndex(int[] arr)
    {
        int firstHalf = 0, secondHalf = 0;

        for (int i = 0; i < arr.Length; i++)            //for each index in the array
        {
            for (int f = 0; f < i; f++)
            {
                firstHalf += arr[f];                    //counting first half
            }
            for (int s = arr.Length - 1; s > i; s--)
            {
                secondHalf += arr[s];                   //counting second half
            }
            if (firstHalf == secondHalf) return i;      //check equality
            firstHalf = secondHalf = 0;                 //clear data for the next iteration
        }
        return -1;                                      //if there is no equality, return -1
    }
    static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 3, 2, 1 };           //  3
        int[] arr2 = { 20, 10, 30, 10, 10, 15, 35 };    //  3
        int[] arr3 = { 1, 100, 50, -51, 1, 1 };         //  1
        int[] arr4 = { 1, 2, 3, 4, 5, 6 };              // -1 the condition of equality between the first and second half is not met
        Console.WriteLine(FindEvenIndex(arr1));
        Console.WriteLine(FindEvenIndex(arr2));
        Console.WriteLine(FindEvenIndex(arr3));
        Console.WriteLine(FindEvenIndex(arr4));
    }
}