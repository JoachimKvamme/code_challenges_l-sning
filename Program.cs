namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {
        Challenge_one one = new Challenge_one();
        Challenge_two two = new Challenge_two();
        Challenge_three three = new Challenge_three();

        
        // validate some methods

        // Oppgave 1


        string[] testArray = ["Heihei", "Jeg virker"];
        // Sjekker at metodene fra Challenge_one gjør det de skal.
        one.PrintNumbers();
        one.PrintStrings(testArray);
        one.CheckIfNumberIsPositiveOrNegative(5);
        one.CheckIfNumberIsPositiveOrNegative(-5);

        // Oppgave 2

        // two.GuessNumber();

        // Av en eller annen grunn printer denne hvert tall i rekken to ganger, men bare
        // den delen av rekken som bor innenfor for-løkken. Jeg tror det har 
        // noe med hvordan for-løkken virker å gjøre, men jeg har stirret meg blind på problemet
        // uten å finne en løsning.
        two.Fibonacci(0);

        two.CheckIfNumberIsEvenOrOdd(8);
        two.CheckIfNumberIsEvenOrOdd(7);

        // Oppgave 3

        // Denne tar hvert tall mellom 1 og det brukeren leggeren inn, og sjekker om tallet er fizz, buzz eller fizzBuzz.
        three.FizzBuzz(20);

        
        void ValidateRecursiveFactorial()
        {
            int n = 5;
            int expected = 120; // 5! = 120
            int result = three.RecursiveFactorial(n);

            if (result == expected)
            {
                Console.WriteLine($"Test passed: RecursiveFactorial({n}) = {expected}");
            }
            else
            {
                Console.WriteLine($"Test failed: RecursiveFactorial({n}) = {result}, expected: {expected}");
            }
        }

        ValidateRecursiveFactorial();
    }
}
