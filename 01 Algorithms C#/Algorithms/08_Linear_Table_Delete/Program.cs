namespace _08_Linear_Table_Delete
{
    internal class Program
    {
        public static int[] Delete(int[] array, int index)
        {
            // Create a new array, Length = array.Length - 1
            int[] tempArray = new int[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                // Copy the data in front of index to the front of tempArray
                if (i < index)
                {
                    tempArray[i] = array[i];
                }
                // Copy the array after index to the end of tempArray
                if (i > index)
                {
                    tempArray[i - 1] = array[i];
                }
            }
            return tempArray;
        }

        static void Main(string[] args)
        {
            // Delete the value of the index=2 from scores array
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            Console.Write("Please enter the index to be deleted : ");
            int index = Convert.ToInt32(Console.ReadLine());
            scores = Delete(scores, index);
            for (int i = 0; i < scores.Length ; i++)
            {
                Console.Write(scores[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
