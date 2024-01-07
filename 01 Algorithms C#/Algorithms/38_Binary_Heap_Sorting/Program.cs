namespace _38_Binary_Heap_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeapSort heapSort = new HeapSort();
            int[] scores = { 10, 90, 20, 80, 30, 70, 40, 60, 50 };
            Console.WriteLine("Before building a heap : ");

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + ",");
            }
            Console.Write("\n\n");

            Console.WriteLine("After building a heap : ");
            heapSort.CreateHeap(scores);
            for (int i = 0;i < scores.Length; i++)
            {
                Console.Write(scores[i] + ",");
            }
            Console.Write("\n\n");

            Console.WriteLine("After Heap Sorting : ");
            heapSort.PerformHeapSort();
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
