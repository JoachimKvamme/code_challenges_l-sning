/*
These are very difficult.
*/
public class Challenge_three
{
    public void FizzBuzz(int number)
    {
        List<string> fizzBuzzRekke = [];
        // Todo: Implement fizzbuzz, if a number is divisible by 3: Fizz, if a number is divisible by 5: Buzz, if the number is divisible by both 3 and 5, FizzBuzz
        // https://www.geeksforgeeks.org/fizz-buzz-implementation/
        
        for (int i = 1; i <= number; i++)
        {
            string gameNumber = i.ToString();
            if (i % 3 == 0 && i % 5 == 0) {
                gameNumber = "FizzBuzz";
            } else if (i % 5 == 0) {
                gameNumber = "Buzz";
            } else if (i % 3 == 0) {
                gameNumber = "Fizz";
            }
            fizzBuzzRekke.Add(gameNumber);
            
        }
        fizzBuzzRekke.ForEach(i => Console.Write("{0}\n", i));
        
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        // n * Method(n - 1);
        return n;
    }

    public string ReverseString(string str)
    {
        // Todo: reverse the given string
        char[] charArray = str.ToCharArray();
        return str;
    }
}