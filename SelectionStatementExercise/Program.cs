namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialize favorite number
            var favNumber = 33;
            var answer = 0;
            
            //adding a loop (I learned a little about while loops from early lessons in c++ selfstudying)
            while (answer != favNumber)
            {
                //Prompt for user to guess number
                Console.WriteLine("Guess my favorite number between 1 and 40:");
                answer = int.Parse(Console.ReadLine());

                //If and else to check guesses
                if (answer > favNumber)
                {
                    Console.WriteLine($"Too high! \nYour guess was: {answer}");
                }
                else if (answer < favNumber)
                {
                    Console.WriteLine($"Too Low! \nYour guess was: {answer}");
                }
                else
                {
                    Console.WriteLine($"You guessed it! \n My favorite number is {favNumber}");
                }
            }

        }
    }
}
