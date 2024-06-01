
Console.WriteLine("Enter something:");
string userInput = Console.ReadLine();
PrintAnyWord(userInput); //userInput-argument


static void PrintAnyWord(string Anystring)//anyString-parameter
{
    Anystring = Anystring.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(Anystring);
    }
}
