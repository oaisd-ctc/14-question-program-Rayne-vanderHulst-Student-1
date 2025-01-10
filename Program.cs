using System;

public class Program
{
    public static string name;
    public static int age;
    public static string eyeColor;
    public static string hairColor;
    public static string shoeSize;
    public static string favoriteColor;
    public static string favoriteTvorMovie;
    public static string favoriteTeacher;
    public static string favoriteClass;
    public static string favoriteHoliday;
    public static string favoriteSeason;
    public static string dreamJob;
    public static string numberOfSiblings;
    public static int ageIn5Years;

    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        CalculateAgeIn5Years();
        AskOtherDetails();
    }

    // Ask for Name
    public static void AskName()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
    }

    // Ask for Age
    public static void AskAge()
    {
        Console.WriteLine("How old are you?");
        if (int.TryParse(Console.ReadLine(), out int enteredAge))
        {
            age = enteredAge;
        }
        else
        {
            Console.WriteLine("Please enter a valid age.");
        }
    }

    // Calculate Age in 5 years
    public static void CalculateAgeIn5Years()
    {
        ageIn5Years = age + 5;
        Console.WriteLine($"In 5 years, you will be {ageIn5Years} years old.");
    }

    // Ask for other details
    public static void AskOtherDetails()
    {
        Console.WriteLine("What is your eye color?");
        eyeColor = Console.ReadLine();
        
        Console.WriteLine("What is your hair color?");
        hairColor = Console.ReadLine();
        
        Console.WriteLine("What is your shoe size?");
        shoeSize = Console.ReadLine();
        
        Console.WriteLine("What is your favorite color?");
        favoriteColor = Console.ReadLine();
        
        Console.WriteLine("What is your favorite movie?");
        favoriteTvorMovie = Console.ReadLine();
        
        Console.WriteLine("Who is your favorite teacher?");
        favoriteTeacher = Console.ReadLine();
        
        Console.WriteLine("What is your favorite class?");
        favoriteClass = Console.ReadLine();
        
        Console.WriteLine("What is your favorite holiday?");
        favoriteHoliday = Console.ReadLine();
        
        Console.WriteLine("What is your favorite season?");
        favoriteSeason = Console.ReadLine();
        
        Console.WriteLine("What is your dream job?");
        dreamJob = Console.ReadLine();
        
        Console.WriteLine("How many siblings do you have?");
        numberOfSiblings = Console.ReadLine();
    }
}

