using Advent_of_code_2022.days;

public class Program
{
    public static void Main()
    {
        //Day1
        //part 1
        string path = "files/Calories.txt";
        List<string> stringValues = Day1.ReadFile(path);
        List<int> numberValues = Day1.StringToInt(stringValues);
        List<int> countedCalorieList = Day1.Count(numberValues);
        int highest = Day1.HighestCalorieCount(countedCalorieList);
        //part 2 
        Day1.ThreeHighest(countedCalorieList);

        //Day2
        string path2 = "files/puzzleInput.txt";
        Day2.Play(path2);

        // Day 3
        string path3 = "files/Backpack.txt";
        string test = "test.txt";

        string[] file = File.ReadAllLines(path3);

        Day3.SumOfPriority(file);

        Day3.SumOfBadges(file);
    }
}