namespace _02Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Recap

            /*
            
            A graph models a set of connections. 
            Breadthirst search is a diferent kind of search algorithm: one that runs on graphs. It can help answer two types of questions:
            • Question type 1: Is there a path from node A to node B?
            • Question type 2: What is the shortest path from node A to node B?

            Queues - Queues are similar to stacks. You can’t access random elements in the queue. Instead, there are two only operations, enqueue and dequeue.
            The queue is called a FIFO data structure: First In, First Out. In contrast, a stack is a LIFO data structure: Last In, First Out
            
            Running time
            If you search your entire network for a mango seller, that means you’ll follow each edge (remember, an edge is the arrow or connection from one person to another). 
            So the running time is at least O(number of edges).
            You also keep a queue of every person to search. Adding one person to the queue takes constant time: O(1). Doing this for every person will take O(number of people) total.
            Breadth-irst search takes O(number of people + number of edges), and it’s more commonly written as O(V+E) (V for number of vertices, E for number of edges).
            
            • Breadth-irst search tells you if there’s a path from A to B.
            • If there’s a path, breadth-irst search will ind the shortest path.
            • If you have a problem like “ind the shortest X,” try modeling your problem as a graph, and use breadth-irst search to solve.
            • A directed graph has arrows, and the relationship follows the direction of the arrow (rama -> adit means “rama owes adit money”).
            • Undirected graphs don’t have arrows, and the relationship goes both ways (ross - rachel means “ross dated rachel and rachel dated ross”).
            • Queues are FIFO (First In, First Out).
            • Stacks are LIFO (Last In, First Out).
            • You need to check people in the order they were added to the search list, so the search list needs to be a queue. Otherwise, you won’t get  the shortest path.
            • Once you check someone, make sure you don’t check them again.
            Otherwise, you might end up in an ininite loop.
            
            */
            
            #endregion

        }
    }
}
