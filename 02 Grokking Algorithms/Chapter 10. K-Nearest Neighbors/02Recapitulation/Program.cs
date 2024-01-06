namespace _02Recapitulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Recapitulation
            
            /*
            
            Classifying oranges vs grapefruit - The KNN algorithm is simple but useful! If you’re trying to classify something, you might want to try KNN first.
            Building a recommendations system - Feature extraction and Regression 
            These are the two basic things you’ll do with KNN—classiication and regression:
            • Classiication = categorization into a group
            • Regression = predicting a response (like a number)
            
            Cosine similarity - So far, you’ve been using the distance formula to compare the distance between two users. Is this the best formula to use? A common one used in practice is cosine similarity.
            Cosine similarity doesn’t measure the distance between two vectors. Instead, it compares the angles of the two vectors. It’s better at dealing with cases like this.

            Picking good features
            When you’re working with KNN, it’s really important to pick the right features to compare against. Picking the right features means
            • Features that directly correlate to the movies you’re trying to recommend
            • Features that don’t have a bias (for example, if you ask the users to only rate comedy movies, that doesn’t tell you whether they like action movies)

            Introduction to machine learning
            KNN is a really useful algorithm, and it’s your introduction to the magical world of machine learning! Machine learning is all about making your computer more intelligent.
            
            OCR - OCR stands for optical character recognition. It means you can take a photo of a page of text, and your computer will automatically read the text for you. Google uses OCR to digitize books.
            How would you automatically igure out what number this is? You can  KNN for this:
            1. Go through a lot of images of numbers, and extract features of those numbers.
            2. When you get a new image, extract the features of that image, and see what its nearest neighbors are!
            Generally speaking, OCR algorithms measure lines, points, and curves
            
            You could use the same ideas for speech recognition or face recognition. When you upload a photo to Facebook, sometimes it’s smart enough to tag people in the photo automatically. 
            That’s machine learning in action! 
            The first step of OCR, where you go through images of numbers and extract features, is called training. 
            Most machine-learning algorithms have a training step: before your computer can do the task, it must be trained.
            
            Building a spam filter - Spam filters use another simple algorithm called the Naive Bayes classiier.
            First, you train your Naive Bayes classiier on some data. Naive Bayes igures out the probability that something is likely to be spam. It has applications similar to KNN.

            Recap

            I hope this gives you an idea of all the diferent things you can do with KNN and with machine learning! 
            Machine learning is an interesting field that you can go pretty deep into if you decide to:
            • KNN is used for classiication and regression and involves looking at the k-nearest neighbors.
            • Classiication = categorization into a group.
            • Regression = predicting a response (like a number).
            • Feature extraction means converting an item (like a fruit or a user) into a list of numbers that can be compared.
            • Picking good features is an important part of a successful KNN algorithm.

            */
            
            #endregion

            Console.WriteLine("Recapitulation!");
        }
    }
}
