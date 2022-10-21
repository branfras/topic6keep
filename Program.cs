using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic6keep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brandon Fraser

            string choice = "";

            while (choice != "q")
            {
                Console.Clear(); 
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Part6a");
                Console.WriteLine("2 - Part6b");
                Console.WriteLine("3 - Prompter");
                Console.WriteLine("4 - PercentPassing");
                Console.WriteLine("5 - OddSum");
                Console.WriteLine("6 - RandomNumbers");
                Console.WriteLine("7 - DiceGame");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "q")
                {
                    Console.WriteLine("Goodbye.");
                }
                else if (choice == "1")
                {
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Part6a();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Part6b();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You chose option 3");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Prompter();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("You chose option 4");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    PercentPassing();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("You chose option 5");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    OddSum();
                }
                else if (choice == "6")
                {
                    Console.WriteLine("You chose option 6");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    RandomNumbers();
                }
                else if (choice == "7")
                {
                    Console.WriteLine("You chose option 7");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    DiceGame();
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }


        public static void Part6a()
        {
            int y = 0;
            int z = 1;
            for (int i = 1; i <= 10; i++)
                Console.Write(i + ", ");
            for (int j = 0; j <= 10; j++)
                Console.WriteLine(j * 5);
            for (int k = 99; k >= 55; k--)
                Console.WriteLine(k);
            for (int L = 20; L <= 40; L++)
                y = L + y;
            Console.WriteLine(y);
            for (int m = 5; m >= 1; m--)
                z = m * z;
            Console.WriteLine(z);
            int even = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter a number.");
                int x = Convert.ToInt32(Console.ReadLine());
                int q = x % 2;
                if (q != 0)
                    even++;
            }
            Console.WriteLine(even + " of the numders are even.");
            Console.WriteLine("Hit ENTER to continue.");
            Console.ReadLine();
        }
       
        public static void Part6b()
        {
            int TMNT = 3;
            int tNum = 0;
            bool done = false;
            int guesses = 5;
            int numW = 0;
            int numF = 0;
            int numG = 5;
            while (!done)
            {
                guesses--;
                Console.WriteLine("Enter the number next to the best TMNT.");
                Console.WriteLine("You have " + guesses + " guesses left.");
                Console.WriteLine("1.Leonardo");
                Console.WriteLine("2.Donatello");
                Console.WriteLine("3.Michelangelo");
                Console.WriteLine("4.Raphael");
                tNum = Convert.ToInt32(Console.ReadLine());
                if (TMNT == tNum)
                {
                    Console.WriteLine("Correct.");
                    done = true;
                }
                else if ((tNum != 4) && (tNum != 3) && (tNum != 2) && (tNum != 1))
                {
                    Console.WriteLine("Invalid answer.");
                    guesses = guesses + 1;
                }
                else if (guesses == 1)
                {
                    Console.WriteLine("Out of guesses.");
                    done = true;
                }
                else
                    Console.WriteLine("Incorrect.");
            }
            done = false;
            while (!done)
            {
                int age = 0;
                Console.WriteLine("What is your age?");
                while (!Int32.TryParse(Console.ReadLine(), out age))
                    Console.WriteLine("Invalid integer, try again.");
                if (age <= 0)
                    Console.WriteLine("Invalid answer.");
                else
                {
                    Console.WriteLine("Your age is " + age);
                    done = true;
                }
            }
            done = false;
            while (!done)
            {
                numW++;
                Console.Write(numW + ", ");
                if (numW == 10)
                    done = true;
            }
            done = false;
            while (!done)
            {
                numF = numG * numF;
                numG--;
                if (numG == 1)
                {
                    Console.WriteLine(numF);
                    done = true;
                }
            }
            done = false;
            Console.WriteLine("Hit ENTER to continue.");
            Console.ReadLine();
        }

        public static void Prompter()
        {
            int useMin;
            int useMax;
            int useNum;
            bool done = false;
            Console.WriteLine("Enter the min value.");
            useMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the max value.");
            useMax = Convert.ToInt32(Console.ReadLine());
            while (!done)
            {
                Console.WriteLine($"Enter a number in between {useMin} and {useMax}.");
                useNum = Convert.ToInt32(Console.ReadLine());
                if (useNum < useMin)
                    Console.WriteLine($"Number must be higher than {useMin}.");
                else if (useNum > useMax)
                    Console.WriteLine($"Number must be lower than {useMax}.");
                else if (useNum >= useMin && useNum <= useMax)
                {
                    Console.WriteLine("Number is in the range, thank you.");
                    done = true;
                }
            }
            Console.WriteLine("Hit ENTER to continue.");
            Console.ReadLine();
        }

        public static void PercentPassing()
        {
            float pass = 0;
            float total = 0;
            float percent;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Enter a mark without the \"%\" symbol. Enter the number 501 to finish entering marks.");
                float x = Convert.ToInt32(Console.ReadLine());
                if (x == 501)
                    done = true;
                else if (x >= 101 || x < 0)
                    Console.WriteLine("Invalid number");
                else if (x >= 70)
                {
                    pass = pass + 1;
                    total = total + 1;
                }
                else if (x < 70)
                {
                    total = total + 1;
                }
            }
            percent = (pass / total) * 100;
            Console.WriteLine($"{Math.Round(percent, 0)}% of the scores are above 70%.");
            Console.WriteLine("Hit ENTER to continue.");
            Console.ReadLine();
        }

        public static void OddSum()
        {
            int useNum;
            int oddSum = 0;
            int x = 1;
            Console.WriteLine("Enter a number.");
            useNum = Convert.ToInt32(Console.ReadLine());
            while(x <= useNum)
            {
                oddSum = oddSum + x;
                x = x + 2;
            }
            Console.WriteLine(oddSum);
            Console.WriteLine("Hit ENTER to continue.");
            Console.ReadLine();
        }

        public static void RandomNumbers()
        {
            Random generator = new Random();
            int useMin;
            int useMax;
            int ranNum;
            Console.WriteLine("Enter the min value.");
            useMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the max value.");
            useMax = Convert.ToInt32(Console.ReadLine());
            useMax = useMax + 1;
            for (int i = 1; i <= 25; i++)
            {
                ranNum = generator.Next(useMin, useMax);
                Console.Write(ranNum);
            }
            Console.WriteLine("Hit ENTER to continue.");
            Console.ReadLine();
        }

        public static void DiceGame()
        {
            Random generator = new Random();
            int die1;
            int die2;
            int dieSum;
            decimal money = 100.00m;
            decimal bet = 1.00m;
            bool done = false;
            while (!done)
            {
                Console.WriteLine($"You currently have ${Math.Round(money, 2)} in your bank account.");
                Console.WriteLine("Enter how much you want to bet.");
                bet = Convert.ToDecimal(Console.ReadLine());
                if (bet > money)
                    bet = 0.00m;
                Console.WriteLine("What do you want to bet on?");
                Console.WriteLine("1. Doubles");
                Console.WriteLine("2. Not double");
                Console.WriteLine("3. Even Sum");
                Console.WriteLine("4. Odd Sum");
                int roll = Convert.ToInt32(Console.ReadLine());
                die1 = generator.Next(1, 7);
                die2 = generator.Next(1, 7);
                dieSum = die1 + die2;
                int q = dieSum % 2;
                if (roll == 1)
                {
                    Console.WriteLine("You bet on doubles.");
                    Console.WriteLine($"The first die rolled a {die1}. The second die rolled a {die2}. The total rolled is {dieSum}.");
                    if (die1 == die2)
                    {
                        Console.WriteLine("You win.");
                        bet = bet * 2;
                        money = money + bet;
                    }
                    else
                    {
                        Console.WriteLine("You lose.");
                        money = money - bet;
                    }
                }
                else if (roll == 2)
                {
                    Console.WriteLine("You bet on not double.");
                    Console.WriteLine($"The first die rolled a {die1}. The second die rolled a {die2}. The total rolled is {dieSum}.");
                    if (die1 != die2)
                    {
                        Console.WriteLine("You win.");
                        bet = bet / 2;
                        money = money + bet;
                    }
                    else
                    {
                        Console.WriteLine("You lose.");
                        money = money - bet;
                    }
                }
                else if (roll == 3)
                {
                    Console.WriteLine("You bet on even sum.");
                    Console.WriteLine($"The first die rolled a {die1}. The second die rolled a {die2}. The total rolled is {dieSum}.");
                    if (q == 0)
                    {
                        Console.WriteLine("You win.");
                        money = money + bet;
                    }
                    else
                    {
                        Console.WriteLine("You lose.");
                        money = money - bet;
                    }
                }
                else if (roll == 4)
                {
                    Console.WriteLine("You bet on odd sum.");
                    Console.WriteLine($"The first die rolled a {die1}. The second die rolled a {die2}. The total rolled is {dieSum}.");
                    if (q == 1)
                    {
                        Console.WriteLine("You win.");
                        money = money + bet;
                    }
                    else
                    {
                        Console.WriteLine("You lose.");
                        money = money - bet;
                    }
                }
                else
                    Console.WriteLine("Invalid choice.");
                Console.WriteLine("Do you want to quit this game? Yes or No. (Your money will reset to $100 when you quit.)");
                string leave = Console.ReadLine().ToLower().Trim();
                if (leave == "yes")
                    done = true;
            }
            Console.WriteLine("Hit ENTER to continue.");
            Console.ReadLine();
        }
    }
}
