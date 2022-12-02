using Advent_of_code_2022.days;

public class Program
{
    public static void Main()
    {
        //Day1
        string path = "files/Calories.txt";
        //part 1
        List<string> stringValues = Day1.ReadFile(path);
        List<int> numberValues = Day1.StringToInt(stringValues);
        List<int> countedCalorieList = Day1.Count(numberValues);
        int highest = Day1.HighestCalorieCount(countedCalorieList);
        //part 2 
        int threeHighestSum = Day1.ThreeHighest(countedCalorieList);
        Console.WriteLine("Day one answer: " + threeHighestSum);


        //Day2

        string path2 = "files/puzzleInput.txt";
        //Part 1
        int totalScore = Day2.Play(path2);
        Console.WriteLine("Day two answer: " + totalScore);
    }



}