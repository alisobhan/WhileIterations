namespace WhileIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayStatus = true;
            while (displayStatus)
            {
                displayStatus = MainMenu();
            }
            
        }
        // Display Main Menu Method
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Numbers Game");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;    
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            } 
            else if (result == "3")
            {
                return false; 
            }
            else
            {
                return true; 
            }
            
        }
        // Numbers Game Method
        private static void PrintNumbers()
        {
            Console.Clear();
            Console.Write("Please Enter a number: ");
            int myNumber = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < myNumber+1)
            {
                
                Console.Write(counter);
                Console.Write("-");
                counter++; 
            }
            Console.ReadLine();
        }

        //Guessing game Method
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("It's a Guessing game");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool inCorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                    inCorrect = false;
                else
                    Console.WriteLine("Wrong!");

            } while (inCorrect);
            Console.WriteLine("It took you {0} to Answer!", guesses);
            Console.ReadLine();

        }
    }
}