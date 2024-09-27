using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


public class Challenge_two
{
    // Random-typen gjør det mulig å lage tilfeldige tall til GuessNumber
    Random tilfeldigTall = new Random();
    public void GuessNumber()
    {
        
        int? secret = tilfeldigTall.Next(0,101); // Assign the secret value
        int? guess = 0;
        while (guess != secret)
        {
            Console.WriteLine("Guess the secret number between 1 and 100: ");
            guess = int.Parse(Console.ReadLine());
            // Todo: Implement the correct conditionals inside the while loop.
            if (guess > secret) {
                Console.WriteLine("Your guess was too high.");
            } else if (guess < secret) {
                Console.WriteLine("Your guess was to low.");
            } else {
                Console.WriteLine("Congratulations, you guessed correctly!");
            }
        }
    }

    public void Fibonacci(int n)
    {
        int a = 0, b = 1, c;
        Console.WriteLine($"{a} + {b} + ");
        // Todo: Write out the Fibonacci sequence, tips: use a for loop.
        c = a + b;
        a = b;
        b = c;

        for (int i = 0; i < 10; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.WriteLine($"{a} + {b} + ");
        }
        // c = a + b;
        // a = b;
        // b = c;

    }

    public void CheckIfNumberIsEvenOrOdd(double a, double b)
    {
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"
        Console.WriteLine("");
    }
}