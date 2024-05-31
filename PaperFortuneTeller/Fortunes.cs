namespace PaperFortuneTeller;

public class Fortunes
{
    public static void CountBlueOrYellow()
    {
        Console.WriteLine("Now, pick a number: 1, 2, 5 or 6");
        var chooseANumber = int.Parse(Console.ReadLine());

        if (chooseANumber == 1 || chooseANumber == 5)
        {
            {
                Console.WriteLine("And for the last time, pick a number: 3, 4, 7 or 8");

                chooseANumber = int.Parse(Console.ReadLine());

                switch (chooseANumber)
                {
                    case 3:
                        Console.WriteLine(
                            "You are about to discover a new emoji that will change you're life forever!!");
                        break;
                    case 4:
                        Console.WriteLine(
                            "The Prime Minister hits you with his car and now he's going to pay all of your students debt");
                        break;
                    case 7:
                        Console.WriteLine(
                            "Don't worry about the error messages; they're just trying to spice up your life");
                        break;
                    case 8:
                        Console.WriteLine("Remember, every day is a good day for a run... or a nap");
                        break;
                }
            }
        }
        else if (chooseANumber == 2 || chooseANumber == 6)
        {
            Console.WriteLine("And for the last time, pick a number: 1, 2, 5 or 6");

            chooseANumber = int.Parse(Console.ReadLine());

            switch (chooseANumber)
            {
                case 1:
                    Console.WriteLine(
                        "A secret recipe will come your way, but only if you share your last slice of pizza");
                    break;
                case 2:
                    Console.WriteLine(
                        "Your next great idea will come while you're waiting in line at the grocery store");
                    break;
                case 5:
                    Console.WriteLine(
                        "Dream big! But remember to pack extra socks");
                    break;
                case 6:
                    Console.WriteLine(
                        "A lost trail will lead you to a place of peace and quiet... and maybe a bear");
                    break;
            }
        }
    }

    public static void CountGreenOrRed()
    {
        Console.WriteLine("Now, pick a number: 3, 4, 7 or 8");
        int chooseANumber = int.Parse(Console.ReadLine()); 
        
        if (chooseANumber == 3 || chooseANumber == 7) 
        { 
            Console.WriteLine("And for the last time, pick a number: 1, 2, 5 or 6"); 
            chooseANumber = int.Parse(Console.ReadLine()); 
            switch (chooseANumber)
            {
                case 1: 
                    Console.WriteLine(
                        "A secret recipe will come your way, but only if you share your last slice of pizza"); 
                    break;
                case 2: 
                    Console.WriteLine(
                        "Your next great idea will come while you're waiting in line at the grocery store");
                    break;
                case 5: 
                    Console.WriteLine(
                        "Dream big! But remember to pack extra socks");
                    break;
                case 6: 
                    Console.WriteLine
                        ("A lost trail will lead you to a place of peace and quiet... and maybe a bear");
                    break; 
            }
        }
        else if (chooseANumber == 4 || chooseANumber == 8)
        {
            Console.WriteLine("And for the last time, pick a number: 3, 4, 7 or 8");

            chooseANumber = int.Parse(Console.ReadLine());

            switch (chooseANumber)
            {
                case 3:
                    Console.WriteLine(
                        "You are about to discover a new emoji that will change you're life forever!!");
                    break;
                case 4:
                    Console.WriteLine(
                        "The Prime Minister hits you with his car and now he's going to pay all of your students debt");
                    break;
                case 7:
                    Console.WriteLine(
                        "Don't worry about the error messages; they're just trying to spice up your life");
                    break;
                case 8:
                    Console.WriteLine(
                        "Remember, every day is a good day for a run... or a nap");
                    break;
            }
        }
    }
}