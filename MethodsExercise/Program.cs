namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}! Today we will be getting to know you through a series of questions. There are no right or wrong answers, just answer honestly!\n");
            Console.WriteLine("When you are ready to begin, press any key to begin");
            Console.ReadKey();
            Console.WriteLine("What is your favorite TV show?");
            string tvShow = Console.ReadLine();
            Console.WriteLine($"Really? {tvShow}?? I know I said there are no wrong answers but... Nevermind. This is a judgement free zone. Let's continue.");
            Console.WriteLine("Next question.\n What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"Okay, interesting. You being a fan of {band} makes up for the fact that you like {tvShow}... Just barely though.\nYou're on thin ice now, so answer this last question carefully.");
            Console.WriteLine("Would you rather be a cowboy or a pirate? (Please answer in all lowercase, this code is case sensative)");
            string userInput = Console.ReadLine();

            if (userInput == "cowboy")
            {
                Console.WriteLine($"Congratulations!! You chose {userInput}, which is the correct answer!");
            }
            else if (userInput == "pirate")
            {
                Console.WriteLine($"Sorry, I know we said there are no wrong answers, but {userInput}s are not nearly as cool as cowboys.");
            }
            else
            {
                Console.WriteLine($"I'm sorry, '{userInput}' was not one of the provided options. While we do appreciate creativity, we are very disapointed that you have chosen to answer this way.");
            }

            Console.WriteLine("We have no further questions. Thank you for your participation, your answers have been recorded!");
        }
    }
}
