namespace GuessingNumber;

public static class GuessTheNumber
{
    public static void Main(string[] args)
    {
        Random random = new Random(); //Random
        int numberToBeGuessed = random.Next(1, 101); //stores a random number ranges from 1 to 100
        int userGuess = 0;
        int attempts = 0;

        Console.WriteLine("Guess the number between 1 to 100");
        while(numberToBeGuessed != userGuess)
        {
            userGuess = Convert.ToInt32(Console.ReadLine());
            if(userGuess == numberToBeGuessed)
            {
                Console.WriteLine("Congratulations! You have guessed correctly in "+ attempts+" attempts");
            }
            else if(userGuess > numberToBeGuessed)
            {
                Console.WriteLine("Its High! Try again");
            }
            else
            {
                Console.WriteLine("Its Low! Try again");
            }
            attempts +=1; 
        }
    }
}