namespace MethodsExercise
{
    public class Program
    {
        // Methods for Assignment #1
        public static void GreetUser(string name) 
        {
            Console.WriteLine($"Hello {name}!");
        }
        public static void JudgeTvShow(string tvShow)
        {
            Console.WriteLine($"Really?? {tvShow}??");
        }

        // Methods for Assignment #2
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static void Main(string[] args)
        {

            // Assignment #1 

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            GreetUser(name);
            Console.WriteLine("Today we will be getting to know you through a series of questions. There are no right or wrong answers, just answer honestly!\nWhen you are ready, press any key to start");
            Console.ReadKey();

            Console.WriteLine("What is your favorite TV show?");
            string tvShow = Console.ReadLine();
            JudgeTvShow(tvShow);
            Console.WriteLine("I know I said there are no wrong answers but... Nevermind. This is a judgement free zone. Let's continue.");

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

            // Assignment #2 

            Console.WriteLine("Enter number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number to add to your previous number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"Here is your equation: {num1} + {num2} = {sum}");

            Console.WriteLine("Enter number to multiply.");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number to multiply with your previous number.");
            int number2 = int.Parse(Console.ReadLine());

            int answer = Multiply(number1, number2);
            Console.WriteLine($"Here is you equation: {number1} * {number2} = {answer}");
        }
    }
}
