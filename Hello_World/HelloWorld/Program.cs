class Wordle
{
    static string Guess()
    {   
        string guess = "";
        System.Console.WriteLine("Guess a 5 Letter Word");
        while (guess.Length != 5)
        {
            guess = Console.ReadLine();
            if (guess.Length < 5)
            {
                System.Console.WriteLine("Guess is Too Short");
            }
            else if (guess.Length > 5)
            {
                System.Console.WriteLine("Guess is Too Long");
            }
        }
        return guess;
    }

    static string GuessCheck(string guessMade)
    {
        string guessBreakdown = "";
        System.Console.WriteLine("Guess a 5 Letter Word");
        

        return guessBreakdown;
    }

    static void Main(string[] args)
    {
        string wordleAnswer = "Dodge";    //Answer to seek
        string guessMade = "";
        int guessNo = 1;

        guessMade = Guess();
        guessNo++;

    }
}