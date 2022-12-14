namespace Advent_of_code_2022.days
{
    public class Day1
    {
        public static void ThreeHighest(List<int> caloryCountList)
        {
            int totalSum = 0;
            List<int> list = caloryCountList;
            int highest = 0;

            for (int i = 0; i < 3; i++)
            {
                highest = HighestCalorieCount(list);

                for (int k = 0; k < list.Count; k++)
                {
                    if (list[k] == highest)
                    {
                        totalSum += list[k];
                        list.RemoveAt(k);
                    }
                }
            }

            Console.WriteLine($"Total sum of three highest calorie counts: {totalSum}");
        }
        public static int HighestCalorieCount(List<int> caloryCountList)
        {
            int highest = 0;

            foreach (int calorie in caloryCountList)
            {
                if (calorie > highest)
                {
                    highest = calorie;
                }
            }

            return highest;

        }
        public static List<int> Count(List<int> numberedList)
        {
            List<int> sumOfCalories = new List<int>();
            int calorieSum = 0;
            foreach (int num in numberedList)
            {
                if (num != 0)
                {
                    calorieSum += num;
                }
                else
                {
                    sumOfCalories.Add(calorieSum);
                    calorieSum = 0;
                }
            }
            return sumOfCalories;
        }
        public static List<int> StringToInt(List<string> listOfCalories)
        {
            List<int> numberValues = new List<int>();

            foreach (string line in listOfCalories)
            {
                if (line.Length != 0)
                {
                    int number = int.Parse(line);
                    numberValues.Add(number);
                }
                else
                {
                    numberValues.Add(0);
                }
            }
            return numberValues;
        }
        public static List<string> ReadFile(string path)
        {

            string[] lines = File.ReadAllLines(path);
            List<string> listOfCalories = new List<string>();
            listOfCalories.AddRange(lines);
            return listOfCalories;

        }
    }
}

