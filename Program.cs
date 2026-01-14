using DiceSimulator;

internal class Program
{
    public static void Main(string[] args)
    {
        int numRolls = 0;
        int[] results = new int[13];
        int total = 0;

        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("\nHow many dice rolls would you like to simulate?");
        numRolls = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n" +
            "Each \"*\" represents 1% of the total number of rolls.\n" +
            "Total number of rolls = " + numRolls + ".\n");

        results = DiceRoller.Roll(numRolls);

        for (int iCount = 2; iCount < 13; iCount++)
        {
            int percentage = (int)Math.Round((double)results[iCount] / numRolls * 100);
            Console.WriteLine(iCount + ": " + new string('*', percentage));
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}