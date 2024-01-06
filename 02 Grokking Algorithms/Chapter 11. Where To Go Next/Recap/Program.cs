namespace Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Trees
            Binary search tree is a lot faster for insertions and deletions on average O(log n). Binary search trees have some downsides too. You don’t get random access.
            There are special binary search trees that balance themselves. One example is the red-black tree algorithm.
            So when are binary search trees used? B-trees, a special type of binary tree, are commonly used to store data in databases. 
            If you’re interested in databases or more-advanced data structures, check these out:
            • B-trees
            • Red-black trees
            • Heaps
            • Splay trees

            Inverted indexes
            This is a useful data structure: a hash that maps words to places where they appear. This data structure is called an inverted index, and it’s commonly used to build search engines. 
            If you’re interested in search, this is a good place to start.

            The Fourier transform - https://betterexplained.com/articles/an-interactive-guide-to-the-fourier-transform/
            The Fourier transform is great for processing signals. You can also use it to compress music. First you break an audio file down into its ingredient notes. 
            The Fourier transform tells you exactly how much each note contributes to the overall song. So you can just get rid of the notes that aren’t important. That’s how the MP3 format works!
            Music isn’t the only type of digital signal. 
            The JPG format is another compressed format, and it works the same way. People use the Fourier transform to try to predict upcoming earthquakes and analyze DNA.
            You can use it to build an app like Shazam, which guesses what song is playing.

            Parallel algorithms
            The next three topics are about scalability and working with a lot of data. The best you can do with a sorting algorithm is roughly O(n log n).
            It’s well known that you can’t sort an array in O(n) time—unless you use a parallel algorithm! here’s a parallel version of quicksort that will sort an array in O(n) time
            Parallel algorithms are hard to design. And it’s also hard to make sure they work correctly and to igure out what type of speed boost you’ll see. One thing is for sure—the time gains aren’t linear. 
            So if you have two cores in your laptop instead of one, that almost never means your  algorithm will magically run twice as fast. here are a couple of reasons for this:
            • Overhead of managing the parallelism—Suppose you have to sort  an array of 1,000 items. How do you divide this task among the two cores? 
            Do you give each core 500 items to sort and then merge the two sorted arrays into one big sorted array? Merging the two arrays takes time.
            • Load balancing—Suppose you have 10 tasks to do, so you give each core 5 tasks. But core A gets all the easy tasks, so it’s done in 10 seconds, whereas core B gets all the hard tasks, 
            so it takes a minute. That means core A was sitting idle for 50 seconds while core B was  doing all the work! How do you distribute the work evenly so both  cores are working equally hard?
            If you’re interested in the theoretical side of performance and scalability, parallel algorithms might be for you! 

            MapReduce
            There’s a special type of parallel algorithm that is becoming increasingly popular: the distributed algorithm. The MapReduce algorithm is a popular distributed algorithm. 
            You can use it through the popular open source tool Apache Hadoop.
            Why are distributed algorithms useful?
            Distributed algorithms are great when you have a lot of work to do and want to speed up the time required to do it. 
            MapReduce in particular is built up from two simple ideas: the map function and the reduce function. 
            The map function is simple: it takes an array and applies the same function to each item in the array.
            The reduce function confuses people sometimes. he idea is that you “reduce” a whole list of items down to one item. 
            With map, you go from one array to another. With reduce, you transform an array to a single item.
            MapReduce uses these two simple concepts to run queries about data across multiple machines. When you have a large dataset (billions of rows), 
            MapReduce can give you an answer in minutes where a traditional database might take hours. 


            Bloom filters and HyperLogLog
            Bloom ilters ofer a solution. Bloom ilters are probabilistic data structures. hey give you an answer that could be wrong but is probably correct. 
            Instead of a hash, you can ask your bloom ilter if you’ve crawled this URL before. A hash table would give you an accurate answer. 
            A bloom ilter will give you an answer that’s probably correct:
            • False positives are possible. Google might say, “You’ve already crawled this site,” even though you haven’t.
            • False negatives aren’t possible. If the bloom ilter says, “You haven’t crawled this site,” then you deinitely haven’t crawled this site.
            Bloom ilters are great because they take up very little space. 
            A hash table would have to store every URL crawled by Google, but a bloom filter doesn’t have to do that. hey’re great when you don’t need an exact answer, as in all of these examples. 
            HyperLogLog
            Along the same lines is another algorithm called HyperLogLog. HyperLogLog approximates the number of unique elements in a set. 
            Just like bloom ilters, it won’t give you an exact answer, but it comes very close and uses only a fraction of the memory a task like this would otherwise take.
            If you have a lot of data and are satisied with approximate answers, check out probabilistic algorithms! 

            The SHA algorithms (secure hashing algorithm)
            This allows you to do constant-time lookups. When you want to know the value for a key, you can use the hash function again, and it will tell you in O(1) time what slot to check. 
            Comparing files
            Another hash function is a secure hash algorithm (SHA) function. Given a string, SHA gives you a hash for that string.
            SHA is a hash function. It generates a hash, which is just a short string.
            The hash function for hash tables went from string to array index, whereas SHA goes from string to string. 
            SHA generates a diferent hash for every string. 
            'hello' => 2cf24db.........
            'algorithm' => b1eb2ec........
            SHA hashes are long. They’ve been truncated here.
            You can use SHA to tell whether two iles are the same. his is useful when you have very large iles. Suppose you have a 4 GB file. You want to check whether your friend has the same large file. 
            You don’t have to try to email them your large ile. Instead, you can both calculate the SHA hash and compare it.
            Checking passwords
            SHA is also useful when you want to compare strings without revealing what the original string was.
            When you type in your password, Google by example hashes it and checks it against the hash in its database.
            So it’s only comparing hashes—it doesn’t have to store your password! SHA is used very commonly to hash passwords like this. It’s a one-way hash. You can get the hash of a string.
            But you can’t get the original string from the hash. You can convert a password to a hash, but not vice versa. 
            SHA is actually a family of algorithms: SHA-0, SHA-1, SHA-2, and SHA-3. As of this writing, SHA-0 and SHA-1 have some weaknesses.
            If you’re using an SHA algorithm for password hashing, use SHA-2 or SHA-3.
            Locality-sensitive hashing
            SHA has another important feature: it’s locality insensitive.
            If you change just one character of the string and regenerate the hash, it’s totally diferent!
            Locality-sensitive hash function. hat’s where Simhash comes in. If you make a small change to a string, Simhash generates a hash that’s only a little diferent.
            • Google uses Simhash to detect duplicates while crawling the web.
            • A teacher could use Simhash to see whether a student was copying an essay from the web.
            • Scribd allows users to upload documents or books to share with others. But Scribd doesn’t want users uploading copyrighted content! 
            The site could use Simhash to check whether an upload is similar to a Harry Potter book and, if so, reject it automatically.
            Simhash is useful when you want to check for similar items.

            Diffie-Hellman key exchange
            The Diffie-Hellman algorithm deserves a mention here, because it solves an age-old problem in an elegant way. 
            How do you encrypt a message so it can only be read by the person you sent the message to?
            Diffie-Hellman solves both problems:
            • Both parties don’t need to know the cipher. So we don’t have to meet and agree to what the cipher should be.
            • The encrypted messages are extremely hard to decode. 
            Diffie-Hellman has two keys: a public key and a private key. he public key is exactly that: public. 
            You can post it on your website, email it to friends, or do anything you want with it. You don’t have to hide it. 
            An encrypted message can only be decrypted using the private key. As long as you’re the only person with the private key, only you will be able to decrypt this message!
            The Diffie-Hellman algorithm is still used in practice, along with its successor, RSA.
            
            Linear programming
            Linear programming is used to maximize something given some constraints. 
            All the graph algorithms can be done through linear programming instead. Linear programming is a much more general framework, and graph problems are a subset of that.
            Linear programming uses the Simplex algorithm. It’s a complex algorithm. If you’re interested in optimization, look up linear programming!


            */

            Console.WriteLine("Recap!");
        }
    }
}
