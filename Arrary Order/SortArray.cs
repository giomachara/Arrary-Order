namespace Arrary_Order
{
    public static class SortArray
    {
        public static void Sort(int[] array)
        {           
            int reduceSize = 1;
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - reduceSize; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array,i);
                    }
                }
                reduceSize++;
            }
        }

        private static void Swap(int[] array, int i)
        {           
            int value= array[i];
            array[i] = array[i + 1];
            array[i + 1] = value;            
        }
    }
}