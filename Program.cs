using System;
using System.Collections.Specialized;
using System.Drawing;

namespace Giraffe
{
    class Program
    {   
        // Main method
        static void Main(string[] args)
        {
            Console.WriteLine("--------- VARIABLES and datatypes  -----------"); 
            string characterName = "James";
            int characterAge;
            characterAge = 35;
            char grade = 'A';
            double pi = 3.14;
            bool isMale = true;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            // Change value of variable midway through the program
            characterName = "Bond";
            Console.WriteLine("He rather be called " + characterName);
            Console.WriteLine(grade);
            Console.WriteLine(pi);
            Console.WriteLine(isMale);

            Console.WriteLine("---------- Working with Strings ---------------");
            // Printing out on new line
            Console.WriteLine("Giraffe\nAcademy");
            // Caution with quotations
            Console.WriteLine("Giraffe\"Academy");
            // Cocantenation 
            string phrase = "james " + characterName;
            Console.WriteLine(phrase);
            // Find out the length of a string (including spaces)
            Console.WriteLine(phrase.Length);
            // Print out string all in UPPER CASE
            Console.WriteLine(phrase.ToUpper());
            // Print out string all in LOWER CASE
            Console.WriteLine(phrase.ToLower());
            // Boolean check for substrings within strings
            Console.WriteLine(phrase.Contains("Bond"));
            Console.WriteLine(phrase.Contains("Bong"));
            // Grab Index positions of strings
            Console.WriteLine(phrase[0]);
            // Grab index position
            Console.WriteLine(phrase.IndexOf('B'));
            // Returns -1 if it is not in original phrase
            Console.WriteLine(phrase.IndexOf('t'));
            // Grab characters at (starting index position, chars count)
            Console.WriteLine(phrase.Substring(6, 2));
            // Google for more C# string methods 


            Console.WriteLine("-------- WORKING WITH NUMBERS -------");
            Console.WriteLine(50);
            // Basic math operations + - * / and BIDMAS 
            Console.WriteLine((1 + 10) * 6);
            // Modulus 
            Console.WriteLine(5 % 2);
            // Careful with floats 
            Console.WriteLine(5 / 2);   // Returns 2
            Console.WriteLine(5 / 2.0); // Returns 2.5
            int count = 6;
            Console.WriteLine(count++);   // Inc
            Console.WriteLine(count--);   // Dec
            // In built MATH methods
            Console.WriteLine( Math.Abs(-40));  // Absolute value 
            Console.WriteLine( Math.Pow(3, 2)); // Powers 
            Console.WriteLine( Math.Sqrt(49));  // Square root
            Console.WriteLine( Math.Max( 10, 92)); // Which number is bigger
            Console.WriteLine( Math.Min(10, 92)); // Which number is smaller
            Console.WriteLine( Math.Round(4.2));   // Round numbers

            Console.WriteLine("------ ARRAYS -------");
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[10];  // Fixed size
            friends[0] = "Jim";
            friends[1] = "Kelly";
            luckyNumbers[1] = 900;
            Console.WriteLine( luckyNumbers[1] );

            Console.WriteLine("------ METHODS -------");
            SayHi("Mike",23);
            SayHi("Geo", 17);
            SayHi("Kuba", 22);
            Console.WriteLine(cube(3));

            Console.WriteLine("------ IF STATEMENTS -------");
            bool isTall = false;
            // && = AND Operator
            // || = OR Operator
            if (isMale && isTall)
            { 
                Console.WriteLine("You are tall male");
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You are short male");
            }
            else
            {
                Console.WriteLine("You are either not male or tall");
            }

            Console.WriteLine(GetMax(1, 20, 78));

            Console.WriteLine("------ SWITCH STATEMENTS -------");
            Console.WriteLine(GetDay(2));

            Console.WriteLine("-------- WHILE LOOPS ---------");
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine("------- DO WHILE LOOPS --------");
            int indexTwo = 6;
            do
            {
                Console.WriteLine(indexTwo);
                indexTwo++;
            } while (indexTwo <= 10);

            Console.WriteLine("------- FOR LOOPS --------");
            for (int i = 1; i <= 5; i++) {
                Console.WriteLine(i);
            }

            int[] evenNumbers = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }

            Console.WriteLine("------- EXPONENT METHOD --------");
            Console.WriteLine(GetPow(3, 2));

            Console.WriteLine("------- 2D ARRAYS --------");
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4 },
                {5, 6 }
            };
            // [ROW, COL]
            Console.WriteLine(numberGrid[2, 1]);

            // THIS IS A SINGLE COMMENT
            /*
             * 
             * THIS IS A MULTI LINE COMMENT
             * 
             */

            Console.WriteLine("------- OBJECTS AND CLASSES --------");
            // An object is an instance of a class
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            // Instead of doing it manually like this ...
            // book1.title = "Harry Potter";
            // book1.author = "JK Rowling";
            // book1.pages = 400;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);
            // book2.title = "Lord of the Rings";
            // book2.author = "Tolkein";
            // book2.pages = 700;

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            Book book3 = new Book();
            // Values can be modified and updated 
            book3.title = "The Hobbit";
            Console.WriteLine(book3.title);

            Console.WriteLine("------- OBJECT METHODS --------");
            // Is a method that we can define inside a class so that the objects in that class can be found/defined/modified
            Console.WriteLine(book1.ThickBook());
            Console.WriteLine(book2.ThickBook());

            Console.WriteLine("------- GETTERS AND SETTERS --------");
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);

            Console.WriteLine("------- STATIC CLASS ATTIRBUTES --------");
            // A special kind of attribute in a class which is shared by all the objects / instances of that class 
            // NORMAL ATTRIBUTE 
            Song holiday = new Song("Holiday", "Green Day", 200);
            // STATIC ATTRIBUTE is specific to the class itself not the objects
            Console.WriteLine(Song.songCount);

            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(holiday.title);
            
            Console.WriteLine(kashmir.title);
            // use getter method if you want individual objects to access the attribute
            Console.WriteLine(kashmir.getSongCount());
            
            Console.WriteLine("------- STATIC METHOD and CLASSES ATTRIBUTES --------");
            // STATIC METHOD - method that already belongs to the class
            // You don't need to make instances of it to use it
            // e.g. Math is a STATIC class 
            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayYo("Mike");

            Console.WriteLine("------- INHERITANCE --------");
            // One sub-class inherits all the functinality of a super class
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            // The Italian Chef (sub-class) inherits attributes from the Chef (super class) 
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            // Method Overriding
            italianChef.MakeSpecialDish();

            Console.WriteLine("------- EXCEPTION HANDLING --------");
            try
            {
                Console.WriteLine("Enter a number: ");
                int numbaOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int numbaTwo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(numbaOne / numbaTwo);
            }
            // Catch any or specific situations e.g. divide by zero or format exceptions
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // finally - This code runs no matter what 
            finally
            {
                Console.WriteLine("Hi, this runs no matter what");
            }


            Console.WriteLine("------ GET USER INPUT -------");
            // Prompt user for information
            Console.Write("Enter your name: ");
            // Takes user input and store it as a variable
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);


            Console.WriteLine("------ CONVERSIONS --------");
            // Convert string into int
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 6);

            Console.WriteLine("------ CALC app --------");
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator: ");
            string op = Console.ReadLine();
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if (op == "+")
            {
                Console.Write(num1 + num2);
            } 
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }


            Console.WriteLine("------ Mad Lib --------");
            string colour, pluralNoun, celebrity;
            Console.WriteLine("Enter a colour: ");
            colour = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + colour);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.WriteLine("------- GUESSING GAME --------");
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                    Console.WriteLine("Sorry you are out of guesses!");
                }

            }
            if (outOfGuesses)
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("You win!");
            }


            Console.ReadLine();
        }

        // Method is a block of code (container) to perform a specific task
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static int cube(int number)
        {
            int result = number * number * number;
            return result;
        }

        static int GetMax(int number1, int number2, int number3)
        {
            // IF STATEMENTS
            int resultTwo;
            if (number1 >= number2 && number1 >= number3)
            {
                resultTwo = number1;
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                resultTwo = number2;
            }
            else
            {
                resultTwo = number3;
            }
            return resultTwo;
        }

        static string GetDay(int dayNum)
        {
            // SWITCH STATEMENTS
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }

        // POSITIVE EXPONENT METHOD
        static int GetPow(int baseNum, int powNum)
        {
            int res = 1;

            for (int i = 0; i < powNum; i++)
            {
                res = res * baseNum; 
            }

            return res; 
        }
    }
}
