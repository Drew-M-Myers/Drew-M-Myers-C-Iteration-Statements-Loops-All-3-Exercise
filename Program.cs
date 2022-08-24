namespace IterationStatementsandLoopsExercise
{
    class Program
    {

        static void Main(string[] args)

        {
            //Exercise 1

            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine($"{i}");
            }


            /*  static void Main(string[] args)
            {

                for (int i = 0; i <= 15; i++)
                {
                    Console.WriteLine($"{i}");
                }

            }
           */

            /*  static void Main(string[] args)
           {

               for (int i = 0; i <= 15; i++)
               {
                   Console.WriteLine($"{i}");
               }

           }
          */

            /*  static void Main(string[] args)
           {

               for (int i = 0; i <= 15; i++)
               {
                   Console.WriteLine($"{i}");
               }

           }
          */

            /*  static void Main(string[] args)
           {

               for (int i = 0; i <= 15; i++)
               {
                   Console.WriteLine($"{i}");
               }

           }
          */

            /*  static void Main(string[] args)
           {

               for (int i = 0; i <= 15; i++)
               {
                   Console.WriteLine($"{i}");
               }

           }
          */

            /*  static void Main(string[] args)
           {

               for (int i = 0; i <= 15; i++)
               {
                   Console.WriteLine($"{i}");
               }

           }
          */

            //Exercise 2

            //If/Else Statement
            int favNumber = 777;

            Console.WriteLine("Try to guess my favorite number. Hint it is betwwen 1 and 1000.");
            var userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
            {
                Console.WriteLine("That is to low!");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine("That is to high!");
            }
            else if (userGuess == favNumber)
            {
                Console.WriteLine($"That is correct! My favorite number is {favNumber}");
            }
            else
            {
                Console.WriteLine("Nevermind.");
            }

            //Switch/Case Statement
            Console.WriteLine("What is your favoirte school subject?");
            string variable = Console.ReadLine();

            switch (variable)
            {
                case "Math":
                    Console.WriteLine("That is my favorite subject too!");
                    break;
                case "Sience":
                    Console.WriteLine("e=mc^2!");
                    break;
                case "English":
                    Console.WriteLine("I do not like english at all.");
                    break;
                case "Histroy":
                    Console.WriteLine("Lets learn from our mistakes.");
                    break;
                case "Tech":
                    Console.WriteLine("The future is here!");
                    break;
                default:
                    Console.WriteLine("Did not know that was even an option.");
                    break;
            }




            //Exercise 3

            Console.WriteLine("Give me the number that is at the top of your range.");
            var max = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Give me the number that is at the bottom of your range");
            var min = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Method Recall
            PrintRange(max, min);

            Console.WriteLine("");

            Console.WriteLine("Lets count by threes! Where do you want to start?");
            var z = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Great, how high do you want to count?");
            var w = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Method Recall
            CountingByThrees(z, w);

            Console.WriteLine("");

            Console.WriteLine("Lets see if you have the same amount. How many marbels does Tom have?");
            var paramater1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("How many marbels do you have?");
            var parameter2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Method Recall
            GuessAndCheck(paramater1, parameter2);

            Console.WriteLine("");

            Console.WriteLine("Let'see if your favorite number is odd or even. Give me your favorite number?");
            var favoriteNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("");


            //Method Recall
            OddOrEven(favoriteNumber);

            Console.WriteLine("");


            Console.WriteLine("Let'see if your favorite number is positive or negative. Give me your favorite number?");
            var favoriteNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");


            //Method Recall
            PositiveOrNegative(favoriteNumber1);

            Console.WriteLine("");


            Console.WriteLine("Let'see if you are old enough to vote. What is your age?");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("");


            //Method Recall
            OldEnoughToVote(age);

            Console.WriteLine("");


            Console.WriteLine("Let'see if you dog lost or gained weight. We do not want weight to fluctuate 10 lbs. Last time you checked, how much did they weigh?");
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            //Puts dog on scale. 
            Console.WriteLine("Perfect. This time they weight...(reads scale)");
            var d = double.Parse(Console.ReadLine());
            Console.WriteLine("");


            //Method Recall
            WeightChange(c, d);

            Console.WriteLine("");


            Console.WriteLine("Lets build a multiplication table. What number do you want to see in the multiplication table?");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Method Recall
            MultiplicationTable(m);

            Console.WriteLine("");

        }

        //Write a method that will print to the console all numbers 1000 through -1000.
        //I made the method so it will do any user input range
        public static void PrintRange(int max, int min)
        {
            for (int i = max; i >= min; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.
        //I made the method so it will count by threes with any user input.
        public static void CountingByThrees(int z, int w)
        {
            for (int a = z; a <= w; a += 3)
            {
                Console.WriteLine(a);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.
        //Did a fun one that gives feedback options
        public static void GuessAndCheck(int parameter1, int parameter2)
        {
            if (parameter1 > parameter2)
            {
                Console.WriteLine("Tom has more marbels than you.");
            }
            else if (parameter1 < parameter2)
            {
                Console.WriteLine("You have more marbels than Tom");
            }
            else if (parameter1 == parameter2)
            {
                Console.WriteLine("You have the same amount of marbels.");
            }
            else
            {
                Console.WriteLine("What do you mean you lost all your marbels?");
            }
        }
        //Write a method to check whether a given number is even or odd.
        //Done
        public static void OddOrEven(int favoriteNumber)
        {
            if (favoriteNumber % 2 == 0)
            {
                Console.WriteLine("Your favorite number is even.");
            }
            else
            {
                Console.WriteLine("Your favorite number is odd.");
            }
        }
        //Write a method to check whether a given number is positive or negative
        //Done
        public static void PositiveOrNegative(int favoriteNumber1)
        {
            if (favoriteNumber1 > 0)
            {
                Console.WriteLine("Your favorite number is positive.");
            }
            else
            {
                Console.WriteLine("Your favorite number is negative.");
            }

        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Done
        public static void OldEnoughToVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
            }
            else
            {
                Console.WriteLine("You are to young to vote.");
            }

        }
        //BONUS ON THE BONUS (Heating Up)
        //Write a method to check if an integer (from the user) is in the range -10 to 10.
        //I know you just wanted one integer, but I wanted to myself with comparing two integers. I did doubles so that decimals could be added for an exact weight. 
        public static void WeightChange(double c, double d)
        {
            if (c <= d + 10 && c >= d - 10)
            {
                Console.WriteLine("Your dog is still a good weight.");
            }
            else if (c >= d - 10)
            {
                Console.WriteLine("Your dogs weight is concerning. Are they eating enough food?");
            }
            else if (c <= d + 10)
            {
                Console.WriteLine("Your dog has put some weight on. How often are they exercised?");
            }
            else
            {
                Console.WriteLine("It appears our scale is not working.");
            }

        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void MultiplicationTable(int m)
        {
            for (int j = 1; j <= 12; j++)
            {
                int result = m * j;
                Console.WriteLine($"{m} x {j} = {result}");
            }


        }
    }
}