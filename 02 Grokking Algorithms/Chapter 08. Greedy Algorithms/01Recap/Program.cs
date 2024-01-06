namespace _01Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Recap
            /*
            Set
            A set is like a list, except that each item can show up only once in a set. Sets can’t have duplicates.
            A set union means “combine both sets”
            A set intersection means “ind the items that show up in both sets” 
            A set diference means “subtract the items in one set from the items in the other set.”
            • Sets are like lists, except sets can’t have duplicates.
            • You can do some interesting operations on sets, like union, intersection, and diference.

            The classroom scheduling problem 
            1. Pick the class that ends the soonest. his is the irst class you’ll hold in this classroom.
            2. Now, you have to pick a class that starts ater the irst class. Again, pick the class that ends the soonest. his is the second class you’ll hold.
            A greedy algorithm is simple: at each step, pick the optimal move. 
            In technical terms: at each step you pick the locally optimal solution, and in the end you’re let with the globally optimal solution. 
            Believe it or not, this simple algorithm inds the optimal solution to this scheduling problem!

            The knapsack problem
            Sometimes, perfect is the enemy of good. Sometimes all you need is an algorithm that solves the problem pretty well. 
            And that’s where greedy algorithms shine, because they’re simple to write and usually get pretty close.

            The set-covering problem
            Approximation algorithms
            Greedy algorithms to the rescue! Here’s a greedy algorithm that comes pretty close:
            1. Pick the station that covers the most states that haven’t been covered yet. It’s OK if the station covers some states that have been covered already.
            2. Repeat until all the states are covered. This is called an approximation algorithm. When calculating the exact solution will take too much time, an approximation algorithm will work. 
            Approximation algorithms are judged by
            • How fast they are
            • How close they are to the optimal solution
            Greedy algorithms are a good choice because not only are they simple to come up with, but that simplicity means they usually run fast, too.

            NP-complete problems "nondeterministic polynomial-time complete"
            The traveling-salesperson problem and the set-covering problem both have something in common: you calculate every possible solution and pick the smallest/shortest one. 
            Both of these problems are NP-complete.
            What’s a good approximation algorithm for the traveling salesperson? Something simple that finds a short path.
            Arbitrarily pick a start city. hen, each time the salesperson has to pick the next city to visit, they pick the closest unvisited city

            How do you tell if a problem is NP-complete?
            NP-complete problems show up everywhere! It’s nice to know if the problem you’re trying to solve is NP-complete. 
            At that point, you can stop trying to solve it perfectly, and solve it using an approximation algorithm instead. 
            But it’s hard to tell if a problem you’re working on is NP-complete. 
            Usually there’s a very small diference between a problem that’s easy to solve and an NP-complete problem.
            Here are some giveaways:
            • Your algorithm runs quickly with a handful of items but really slows down with more items.
            • “All combinations of X” usually point to an NP-complete problem.
            • Do you have to calculate “every possible version” of X because you can’t break it down into smaller sub-problems? Might be NP-complete.
            • If your problem involves a sequence (such as a sequence of cities, like traveling salesperson), and it’s hard to solve, it might be NP-complete.
            • If your problem involves a set (like a set of radio stations) and it’s hard to solve, it might be NP-complete.
            • Can you restate your problem as the set-covering problem or the traveling-salesperson problem? hen your problem is deinitely NP-complete.


            • Greedy algorithms optimize locally, hoping to end up with a global optimum.
            • NP-complete problems have no known fast solution.
            • If you have an NP-complete problem, your best bet is to use an approximation algorithm.
            • Greedy algorithms are easy to write and fast to run, so they make good approximation algorithms.
            */
            #endregion

            Console.WriteLine("Greedy Algorithms");
        }
    }
}
