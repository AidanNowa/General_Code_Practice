using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Exercise 1
        int n = 7;
        if (n % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }

        // Exercise 2
        int age = 70;
        if (age < 18)
        {
            Console.WriteLine("Minor");
        }
        else if (age < 65)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Senior");
        }

        // Exercise 3
        int[] scores = {72, 85, 90, 65, 70};
        foreach (int score in scores)
        {
            if (score >= 85)
            {
                Console.WriteLine($"{score}: Hot");
            }
            else if (score >= 70)
            {
                Console.WriteLine($"{score}: Warm");
            }
            else
            {
                Console.WriteLine($"{score}: Cool");
            }
        }

        // Exercise 4
        (string name, int sale)[] sales = {("Ana", 3500), ("Ben", 1800), ("Chloe", 2500)};

        foreach (var(salesperson, sale) in sales)
        {
            if (sale > 3000)
            {
                Console.WriteLine($"{salesperson}: Top Bonus");
            }
            else if (sale > 2000)
            {
                Console.WriteLine($"{salesperson}: Standard Bonus");
            }
            else
            {
                Console.WriteLine($"{salesperson}: No Bonus");
            }
        }

        // Exercise 5
        var players = new List<Player> {
            new Player("Maya", 950),
            new Player("Liam", 1150),
            new Player("Zoe", 780)
        };

        foreach (var player in players)
        {
            player.AssignRank();
            Console.WriteLine($"{player.Name} scored {player.Score} and earned {player.Rank} rank.");
        }

        // Bonus
        int lives = 3;
        while (lives > 0)
        {
            lives -= 1;
            if (lives > 0)
            {
                Console.WriteLine($"Player has {lives} lives left!");
            }
            else
            {
                Console.WriteLine("Player is dead!");
            }
        }

        List<int[]> weekly_scores = [[850, 900, 870, 910, 890, 920, 880],  [930, 940, 950, 920, 910, 960, 970]];
        int week_num = 0;
        foreach (var week in weekly_scores)
        {
            week_num += 1;
            int weekly_total = 0;
            foreach (int score in week)
            {
                weekly_total += score;
            }
            Console.WriteLine($"Week {week_num} Score: {weekly_total}");
        }


        string[] values = { null, "160519", "9432.0", "16,667", "   -322   ", "+4302", "(100);", "01FA", "300", "-12" };
        foreach (var value in values)
        {
            int number;
            bool success = int.TryParse(value, out number);
            if (success) 
            {
                Console.WriteLine($"Converted '{value}' to {number}.");
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{value ?? "<null>"}' failed.");
            }
        }
    }
}

class Player
{
    public string Name;
    public int Score;
    public string? Rank;

    public Player(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public void AssignRank()
    {
        if (Score >= 1000)
            Rank = "Gold";
        else if (Score >= 800)
            Rank = "Silver";
        else
            Rank = "Bronze";
    }
}