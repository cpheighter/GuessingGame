var favNum = 0;

do
{
    Console.Write("Guess my favorite number \nYour guess: ");
    var guessNum = int.Parse(Console.ReadLine());

    if (guessNum < 0)
    {
        Console.WriteLine("You're guess is too low. Try Again :(");
    }
    else if (guessNum > 0)
    {
        Console.WriteLine("You're guess is too high. Try Again :(");
    }
    else
    {
        Console.WriteLine("You're Right! :)");
        break;
    }
}
while (favNum == 0);




