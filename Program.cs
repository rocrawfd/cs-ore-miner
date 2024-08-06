Console.WriteLine("Welcome to Ore Miner! You have just finished a long shift down the mine collecting ore and need to know how much it is worth. Here are the rules:\n\nThe first 10 pieces you sell are worth more than the next 5.\nThese 5 are worth more than the next 3.\nAnd after that each is worth the same amount.\n\nYou want to know what the 11th and 19th piece of ore are worth.\nHow many guesses will you take???\n\n");
string ready = "no";
int attempts = 0;
while (ready != "y")
{
    Console.Write("Input the amount of ore you would like to see the value of: ");
    int oreLeft = int.Parse(Console.ReadLine()!);

    int tenOre = Math.Min(oreLeft, 10);
    int coinsEarned = tenOre * 10;
    oreLeft -= tenOre;

    int fiveOre = Math.Min(oreLeft, 5);
    coinsEarned += fiveOre * 5;
    oreLeft -= fiveOre;

    int threeOre = Math.Min(oreLeft, 3);
    coinsEarned += threeOre * 2;
    oreLeft -= threeOre;

    coinsEarned += oreLeft;

    attempts++;
    Console.WriteLine("Congratulations! You earned " + coinsEarned + " coins\n");
    Console.WriteLine("Are you ready to guess (y or n)?");
    ready = Console.ReadLine()!;

};

Console.Write("How much is the 11th piece of ore worth? : ");
int guessOne = int.Parse(Console.ReadLine()!);
if (guessOne == 5)
{
    Console.Write("Correct Answer :)\nHow much is the 19th piece of ore worth? : ");
    int guessTwo = int.Parse(Console.ReadLine()!);
    if (guessTwo == 1)
    {
        Console.WriteLine("Congratulations! You solved the puzzle in " + attempts + " guess(es)!");
    }
    else
    {
        Console.WriteLine("Almost... but nahhhhhh");
    }
}
else
{
    Console.WriteLine("Wrooooooong");
}

