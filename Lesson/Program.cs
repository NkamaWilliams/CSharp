// See https://aka.ms/new-console-template for more information

//Variables
//Datatypes - boolean
//Operators - mathematical, comparison
//Control Structures - if else else if | switch case
//Loops - for loops, while loops

//bool - true or false
public class Lesson
{
    public static void Main(string[] args)
    {
        int secret = new Random().Next(100);
        int tries = 8;
        //>, <, ==, <=, >=, !=
        for (int i = 0; i < tries; i++)
        {
            Console.WriteLine("Guess a number between 0 and 100");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess < secret)
            {
                Console.WriteLine("Your guess is too small");
            } else if (guess > secret)
            {
                Console.WriteLine("Your guess is too big");
            } else
            {
                Console.WriteLine("YOU WIN");
                break;
            }
        }

        Console.WriteLine("The secret number was " + secret);

    }
}