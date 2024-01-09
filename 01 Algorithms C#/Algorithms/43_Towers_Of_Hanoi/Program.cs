namespace _43_Towers_Of_Hanoi
{
    internal class Program
    {
        /// <summary>
        /// Move a single disk from the source pillar to the destination pillar.
        /// </summary>
        /// <param name="source">The source pillar.</param>
        /// <param name="destination">The destination pillar.</param>
        static void MoveDisk(char source, char destination)
        {
            Console.WriteLine($"Move disk from {source} to {destination}");
        }

        /// <summary>
        /// Recursive method to solve the Towers of Hanoi problem.
        /// </summary>
        /// <param name="n">Number of discs to move.</param>
        /// <param name="source">The source pillar.</param>
        /// <param name="destination">The destination pillar.</param>
        /// <param name="auxiliary">The auxiliary pillar.</param>
        static void TowersOfHanoi(int n, char source, char auxiliary, char destination)
        {
            if (n == 1)
            {
                MoveDisk(source, destination);
            }
            else
            {
                // Move n-1 discs from source to auxiliary using destination as the auxiliary pillar.
                TowersOfHanoi(n - 1, source, destination, auxiliary);

                // Move the remaining disc from source to destination.
                MoveDisk(source, destination);

                // Move the n-1 discs from auxiliary to destination using source as the auxiliary pillar.
                TowersOfHanoi(n - 1, auxiliary, source, destination);
            }
        }


        /// <summary>
        /// Solves the Towers of Hanoi problem using a recursive approach.
        /// </summary>
        /// <param name="numberOfDiscs">Number of discs to move.</param>
        /// <param name="A">Source pillar.</param>
        /// <param name="B">Auxiliary pillar.</param>
        /// <param name="C">Destination pillar.</param>
        public static void Hanoi(int numberOfDiscs, char A, char B, char C)
        {
            if (numberOfDiscs == 1)
            {
                Console.WriteLine($"Move {numberOfDiscs} from {A} to {C}");
            }
            else
            {
                // Move the n-1 discs from A to B using C as an auxiliary pillar.
                Hanoi(numberOfDiscs - 1, A, C, B);
                Console.WriteLine($"Move {numberOfDiscs} from {A} to {C}");

                // Move the n-1 discs from B to C using A as an auxiliary pillar.
                Hanoi(numberOfDiscs - 1, B, A, C);
            }
        }

        static void Main(string[] args)
        {
            int numberOfDiscs = 2;
            Console.WriteLine($"Tower of Hanoi with {numberOfDiscs} discs:");
            TowersOfHanoi(numberOfDiscs, 'A', 'B', 'C');


            Console.Write("\nPlease enter the number of discs : ");
            int numberOfDiscs2 = Convert.ToInt32(Console.ReadLine());
            Hanoi(numberOfDiscs2, 'A', 'B', 'C');
        }
    }
}
