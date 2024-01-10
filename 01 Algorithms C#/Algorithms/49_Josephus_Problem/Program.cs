namespace _49_Josephus_Problem
{
    internal class Program
    {
        private const int N = 11;
        private const int M = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("Solution 1");

            int[] man = new int[N];
            int count = 1;
            int i = 0;
            int pos = -1;
            //int alive = 0;

            while(count <= N)
            {
                do
                {
                    pos = (pos + 1) % N; // Ring
                    if (man[pos] == 0)
                    {
                        i++;
                    }
                    if (i == M)
                    {
                        i = 0;
                        break;
                    }
                } while (true);

                man[pos] = count;
                count++;
            }

            Console.WriteLine("Joseph sequence : ");
            for (i = 0; i < N; i++)
            {
                Console.Write(man[i] + ", ");
            }
            Console.WriteLine("\n\n");




            Console.WriteLine("Solution 2");
            int totalPeople = 11;
            int eliminationCount = 3;

            List<int> people = new List<int>();
            for (i = 1; i <= totalPeople; i++)
            {
                people.Add(i);
            }

            int currentPosition = 0;
            while (people.Count > 2)
            {
                // Find the next person to be eliminated
                currentPosition = (currentPosition + eliminationCount - 1) % people.Count;
                Console.WriteLine($"Person at position {people[currentPosition], 2} is eliminated.");
                people.RemoveAt(currentPosition);
            }

            Console.WriteLine($"\nSurvivors: {people[0]} and {people[1]}");
            Console.WriteLine();
        }
    }
}
