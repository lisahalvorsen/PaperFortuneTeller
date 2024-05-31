namespace PaperFortuneTeller;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Howdy! Pick a color: blue, green, red or yellow");
        var chooseAColor = Console.ReadLine();

        if (chooseAColor == "blue" || chooseAColor == "yellow")
        {
            Fortunes.CountBlueOrYellow();
        } else if(chooseAColor == "green" || chooseAColor == "red")
        {
            Fortunes.CountGreenOrRed();
        }
    }
}