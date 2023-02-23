using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Lithara";
            int age = 21;

            sing(name, age);
            sing(name, age);
            sing(name, age);



            /*String[] cars = {"BMW", "Mustang", "Corvett"};

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //above for loop or below foreach loop

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }*/




            /*do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.WriteLine("Enter number 1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number 2 : ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option : ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Substract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter a option : ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result : {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result : {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result : {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result : {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option.");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = no) : ");
            }
            while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");*/




            /*Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                
                while (player != "ROCK" && player != "PAPER" && player != "SCISSOR")
                {
                    Console.Write("Enter ROCK, PAPER or SCISSOR : ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                }

                switch (random.Next(1, 4))
                {
                    case 1 :
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSOR";
                        break;
                }

                Console.WriteLine("Player : " + player);
                Console.WriteLine("Computer : " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Its's draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else
                        {
                            Console.WriteLine("You Win!");
                        }
                        break;

                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("Its's draw!");
                        }
                        else if (computer == "SCISSOR")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else
                        {
                            Console.WriteLine("You Win!");
                        }
                        break;
                    case "SCISSOR":
                        if (computer == "SCISSOR")
                        {
                            Console.WriteLine("Its's draw!");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else
                        {
                            Console.WriteLine("You Win!");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again? (Y/N) : ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");*/




            /*Random random = new Random();

            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;
            
            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess : " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low");
                    }
                    guesses++;
                }
                Console.WriteLine("Number : " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses : " + guesses);

                Console.WriteLine("Would you like to play again? (Y/N) : ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing! ... I guess");*/

            /*int[,] arr = new int[2, 4];

            for (int i = 0; i < 2; i++)
            {
                for (int j=0; j < 4; j++)
                {
                    Console.WriteLine("Enter a value : ");
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0;i < 2; i++)
            {
                for (int j=0; j < 4; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine("");
            }*/




            /*int[] numbers = new int[10];
            int i;
            int temp;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a value : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i <10; i++)
            {
                for (int j=i+1; j < 10; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }


            Console.WriteLine("Ascending Order : ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            for (i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }


            Console.WriteLine("Descending Order : ");
            for (i = 0; i < 9; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/




            /*int[] numbers = new int[10];
            int max;
            int min;

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("Enter a value : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            max = numbers[0];
            min = numbers[0];

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("Max is " + max);
            Console.WriteLine("Min is " + min);*/




            /*int[] numbers = { 25, 41, 10, 78, 68, 36, 89, 37 };
            int max;
            int min;

            max = numbers[0];
            min = numbers[0];

            for (int i=0; i<8; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("Max is " + max);
            Console.WriteLine("Min is " + min);*/

            /*int n;
            int oddC = 0;
            int evenC = 0;

            for (int i=1; i<=10; i++)
            {
                Console.WriteLine("Enter a value : ");
                n = Convert.ToInt32(Console.ReadLine());

                if ( n%2 == 0 )
                {
                    evenC++;
                }
                else
                {
                    oddC++;
                }
            }
            Console.WriteLine("Number of odd numbers are " + oddC);
            Console.WriteLine("Number of even numbers are " + evenC);*/




            /*double r;
            Console.WriteLine("Enter the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area of the circle is " + (3.14 * r * r));
            Console.WriteLine("The circumference of the circle is " + (2 * 3.14 * r));*/

            /*int n1, n2, operation;

            Console.WriteLine("Enter the first number : ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the arithmetic operation : \n 1 - Addition \n 2 - Substraction\n 3 - Multiplication\n 4 - Division");
            operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1 )
            {
                Console.WriteLine("Addition is " + (n1 + n2));
            }
            else if (operation == 2 )
            {
                Console.WriteLine("Substraction is " + (n1 - n2));
            }
            else if (operation == 3 )
            {
                Console.WriteLine("Multiplication is " + (n1 * n2));
            }
            else
            {
                Console.WriteLine("Division is " + (n1 / n2));
            }*/




            /*string name = "";

            while( name == "")
            {
                Console.WriteLine("Enter your name : ");
                name= Console.ReadLine();
            }
            
            Console.WriteLine("Hello" + name);*/

            /*Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();

            while (1 == 1)
            {
                Console.WriteLine("I'm stuck in this infinite loop!");
            }*/




            /*double a;
            double b;
            double c;

            Console.WriteLine("Enter side A : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B : ");
            b = Convert.ToDouble(Console.ReadLine());

            c = Math.Sqrt( (a * a) + (b * b) );
            Console.WriteLine("The hypotenuse is " + c + ".");*/




            /*int age;
            string name;
            Console.WriteLine("Enter your name : ");
            name= Console.ReadLine();
            Console.WriteLine("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age>=18)
            {
                Console.WriteLine("Hi! " + name + ". You are eligible for voting.");
            }
            else
            {
                Console.WriteLine("Hi! " + name + ". You are not eligible for voting.");
            }*/
            Console.ReadLine();
        }

        static void sing(String name, int age)
        {
            Console.WriteLine("Happy Birthday to You!");
            Console.WriteLine("Happy Birthday to You!");
            Console.WriteLine("Happy Birthday Dear " + name + "!");
            Console.WriteLine("You're " + age + "years old!");
            Console.WriteLine("Happy Birthday to You!");
            Console.WriteLine();
        }
}
