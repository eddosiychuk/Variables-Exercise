namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName; //declaration syntax

            dogName = "diesel"; //initialized

            int dogAge = 1; //declaring and initializing

            char firstInitial = 'D';

            bool isHungry = true;

            double dogWeight = 30.2;

            decimal dogHeight = 22.5m;

            Console.WriteLine($"Hello, my dogs is {dogName}, his initials are {firstInitial} and he is {dogAge} years old.");
            Console.WriteLine($"He weights {dogWeight} pounds, and is {dogHeight} inches tall.");
            Console.WriteLine($"It is {isHungry.ToString().ToLower()} he is always hungry.");
        }
    }
}
