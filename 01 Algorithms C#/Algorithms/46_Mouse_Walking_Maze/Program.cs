namespace _46_Mouse_Walking_Maze
{
    internal class Program
    {
        /// <summary>
        /// Solves the mouse walking maze using recursion.
        /// </summary>
        /// <param name="maze">The maze represented as a 2D array.</param>
        /// <param name="startX">Starting X-coordinate for the mouse.</param>
        /// <param name="startY">Starting Y-coordinate for the mouse.</param>
        /// <param name="endX">X-coordinate of the exit.</param>
        /// <param name="endY">Y-coordinate of the exit.</param>
        /// <returns>True if a solution is found, false otherwise.</returns>
        static bool SolveMaze(int[,] maze, int startX, int startY, int endX, int endY)
        {
            if (startX == endX && startY == endY)
            {
                // Mouse has reached the exit
                maze[startX, startY] = 1;
                return true;
            }

            if (maze[startX, startY] == 0)
            {
                // Mark the current position as part of the path
                maze[startX, startY] = 1;

                // Try moving in all four directions (up, down, left, right)
                if (SolveMaze(maze, startX - 1, startY, endX, endY) ||
                    SolveMaze(maze, startX + 1, startY, endX, endY) ||
                    SolveMaze(maze, startX, startY - 1, endX, endY) ||
                    SolveMaze(maze, startX, startY + 1, endX, endY))
                {
                    return true;
                }

                // If none of the directions lead to the exit, backtrack
                maze[startX, startY] = 0;
            }

            return false;
        }


        /// <summary>
        /// Prints the maze to the console.
        /// </summary>
        /// <param name="maze">The maze represented as a 2D array.</param>
        static void PrintMaze(int[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    Console.Write(maze[i, j] == 2 ? "|" : maze[i, j] == 1 ? ">" : "*");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // Initialize the maze
            int[,] maze = {
                {2, 2, 2, 2, 2, 2, 2},
                {2, 0, 0, 0, 2, 0, 2},
                {2, 2, 2, 0, 0, 0, 2},
                {2, 0, 0, 2, 0, 2, 2},
                {2, 2, 0, 2, 0, 0, 2},
                {2, 0, 0, 0, 0, 2, 2},
                {2, 2, 2, 2, 2, 2, 2}
            };

            Console.WriteLine("Maze before solving:");
            PrintMaze(maze);

            if (SolveMaze(maze, 1, 1, 5, 5))
            {
                Console.WriteLine("\nMaze after solving:");
                PrintMaze(maze);
            }
            else
            {
                Console.WriteLine("\nNo solution found.");
            }
        }
    }
}
