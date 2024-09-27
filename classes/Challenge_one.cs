public class Challenge_one
{
    public void PrintNumbers()
    {
        // Todo: Print out the numbers 1 - 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void PrintStrings(string[] arr)
    {
        /* Todo: Print out each string that is passed to the array as an argument*/
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    public void CheckIfNumberIsPositiveOrNegative(int number)
    {
        /*
        Todo: Check if a number is positive, negative or zero.
        */
        if (number > 0) 
        {
            Console.WriteLine("The number is positive.");
        } else
        {
            Console.WriteLine("The number is negative");
        }
    }


}