namespace _04Greet
{
    internal class Program
    {
        /// <summary>
        /// Define a function that takes a name parameter and prints a greeting
        /// </summary>
        /// <param name="name"></param>
        public static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
            Greet2(name);
            Console.WriteLine("Getting ready to say bye...");
            Bye();
        }

        /// <summary>
        /// Define a function that takes a name parameter and prints a question
        /// </summary>
        /// <param name="name"></param>
        public static void Greet2(string name)
        {
            Console.WriteLine("How are you, " + name + "?");
        }

        /// <summary>
        /// Define a function that prints a farewell message
        /// </summary>
        public static void Bye()
        {
            Console.WriteLine("Ok bye!");
        }


        static void Main(string[] args)
        {
            Greet("Mr Robot");
        }
    }
}