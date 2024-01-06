namespace _01Recapitulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Recap

            /*
            Dynamic programming - Dynamic programming starts by solving subproblems and builds up to solving the big problem.
            Dynamic programming is powerful because it can solve subproblems and use those answers to solve the big problem. 
            Dynamic programming only works when each subproblem is discrete—when it doesn’t depend on other subproblems.

            The way the algorithm is set up, you’re combining two knapsacks at most—you’ll never have more than two sub-knapsacks. 
            But it’s possible for those sub-knapsacks to have their own sub-knapsacks.

            Longest common substring
            Dynamic programming is useful when you’re trying to optimize something given a constraint.
            You can use dynamic programming when the problem can be broken into discrete subproblems, and they don’t depend on each other.
            • Every dynamic-programming solution involves a grid.
            • The values in the cells are usually what you’re trying to optimize.
            • Each cell is a subproblem, so think about how you can divide your problem into subproblems. hat will help you igure out what the axes are.

            In dynamic programming, you’re trying to maximize something. In this case, you’re trying to find the longest substring that two words have in common.
            For the knapsack problem, this last cell always had the final solution.
            But for the longest common substring, the solution is the largest number in the grid—and it may not be the last cell.

            Longest common subsequence - the number of letters in a sequence that the two words have in common
            • Biologists use the longest common subsequence to ind similarities in DNA strands. hey can use this to tell how similar two animals or two diseases are. 
            The longest common subsequence is being used to find a cure for multiple sclerosis.
            • Have you ever used dif (like git diff)? Dif tells you the diferences between two iles, and it uses dynamic programming to do so.
            • We talked about string similarity. Levenshtein distance measures how similar two strings are, and it uses dynamic programming.
            Levenshtein distance is used for everything from spell-check to figuring out whether a user is uploading copyrighted data. 
            • Have you ever used an app that does word wrap, like Microsot Word? How does it igure out where to wrap so that the line length stays consistent? Dynamic programming!

            Recap
            • Dynamic programming is useful when you’re trying to optimize something given a constraint.
            • You can use dynamic programming when the problem can be broken into discrete subproblems.
            • Every dynamic-programming solution involves a grid.
            • he values in the cells are usually what you’re trying to optimize.
            • Each cell is a subproblem, so think about how you can divide your problem into subproblems.
            • here’s no single formula for calculating a dynamic-programming solution.

            */

            #endregion
            
            Console.WriteLine("Recapitulation!");
        }
    }
}
