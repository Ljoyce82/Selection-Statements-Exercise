namespace SelectionStatementExercise
{
    public class Program
    {   
        static void Main(string[] args)
        {
            
            var r = new Random();

            var favNumber = r.Next(1, 1000);
            int userInput;

            //var favNumber = 10; //used to testing

            bool favnumber = false;
            bool exitRequested = false;

            Console.WriteLine("Welcome to watelands favorite guessing game!\nGuess my favorite number between 1 and 1000\n Win 500 CAPS!");


            while (!exitRequested)
            {
               
                userInput = int.Parse(Console.ReadLine());
                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} That is to low guess again!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} That is to high guess again!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"
$$\     $$\                           $$\      $$\ $$\           
\$$\   $$  |                          $$ | $\  $$ |\__|          
 \$$\ $$  /  $$$$$$\  $$\   $$\       $$ |$$$\ $$ |$$\ $$$$$$$\  
  \$$$$  /  $$  __$$\ $$ |  $$ |      $$ $$ $$\$$ |$$ |$$  __$$\ 
   \$$  /   $$ /  $$ |$$ |  $$ |      $$$$  _$$$$ |$$ |$$ |  $$ |
    $$ |    $$ |  $$ |$$ |  $$ |      $$$  / \$$$ |$$ |$$ |  $$ |
    $$ |    \$$$$$$  |\$$$$$$  |      $$  /   \$$ |$$ |$$ |  $$ |
    \__|     \______/  \______/       \__/     \__|\__|\__|  \__|
                                                                 
                                                                 
                                                                 
");
                   exitRequested = true;
                }
                
                
            }  
        }
    }
}
