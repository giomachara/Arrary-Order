namespace Arrary_Order
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 6, 5, 4, 3, 2, 1 };
            SortArray.Sort(array);

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }        
    }
}