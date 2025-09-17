// Creativity: this program randomly selects one out of five verses each time.
using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = RandomVerse();

        string input = "";
        while (input != "quit")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            Console.Clear();
            if (input == "")
            {
                scripture.HideRandomWords();
            }
        }

    }

    static Scripture RandomVerse()
    {
        string book = "";
        int chapter = 0;
        int verse = 0;
        int endVerse = 0;
        string text = "";

        Random random = new Random();
        int r = random.Next(0, 4);
        if (r == 0)
        {
            book = "Mosiah";
            chapter = 29;
            verse = 12;
            text = "Now it is better that a man should be judged of God than of man, for the judgments of God are always just, but the judgments of man are not always just.";
        }
        else if (r == 1)
        {
            book = "Moses";
            chapter = 6;
            verse = 63;
            text = "And behold, all things have their likeness, and all things are created and made to bear record of me, both things which are temporal, and things which are spiritual; things which are in the heavens above, and things which are on the earth, and things which are in the earth, and things which are under the earth, both above and beneath: all things bear record of me.";
        }
        else if (r == 2)
        {
            book = "Mark";
            chapter = 9;
            verse = 23;
            text = "Jesus said unto him, If thou canst believe, all things are possible to him that believeth.";
        }
        else if (r == 3)
        {
            book = "Alma";
            chapter = 37;
            verse = 44;
            endVerse = 45;
            text = "For behold, it is as easy to give heed to the word of Christ, which will point to you a straight course to eternal bliss, as it was for our fathers to give heed to this compass, which would point unto them a straight course to the promised land; And now I say, is there not a type in this thing? For just as surely as this director did bring our fathers, by following its course, to the promised land, shall the words of Christ, if we follow their course, carry us beyond this vale of sorrow into a far better land of promise.";
        }
        else if (r == 4)
        {
            book = "Moroni";
            chapter = 10;
            verse = 20;
            endVerse = 21;
            text = "Wherefore, there must be faith; and if there must be faith there must also be hope; and if there must be hope there must also be charity; And except ye have charity ye can in nowise be saved in the kingdom of God; neither can ye be saved in the kingdom of God if ye have not faith; neither can ye if ye have no hope.";
        }

        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, text);

        return scripture;
    }
}