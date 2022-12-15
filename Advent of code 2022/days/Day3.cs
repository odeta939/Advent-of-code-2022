namespace Advent_of_code_2022.days
{
    public class Day3
    {
        //part1
        public static void SumOfPriority(string[] file)
        {
            int sumOfPriorities = 0;
            foreach (string line in file)
            {
                int len = line.Length / 2;
                char[] comp1 = line.Substring(0, len).ToCharArray();
                char[] comp2 = line.Substring(len).ToCharArray();

                sumOfPriorities += ItemPriority(comp1, comp2);

            }
            Console.WriteLine($"sum of matching item priorities: {sumOfPriorities}");
        }

        public static int ItemPriority(char[] comp1, char[] comp2)
        {
            int priority = 0;

            foreach (char c in comp1)
            {
                if (comp2.Contains(c))
                {
                    if (char.IsUpper(c))
                    {
                        priority = c - 38;

                    }
                    else
                    {
                        priority = c - 96;
                    }

                    break;
                }
            }
            return priority;
        }

        // Part 2
        public static void SumOfBadges(string[] file)
        {
            int badgePriority = 0;
            string line1 = "";
            string line2 = "";
            string line3 = "";


            //iterate file
            for (int i = 1; i < file.Length + 1; i++)
            {
                if (i % 3 == 1)
                {
                    line1 = file[i - 1];
                }
                else if (i % 3 == 2)
                {
                    line2 = file[i - 1];
                }
                else if (i % 3 == 0)
                {

                    line3 = file[i - 1];
                    char match = Match(line1, line2, line3);
                    line1 = ""; line2 = ""; line3 = "";
                    badgePriority += BadgePriority(match);
                    Console.WriteLine(match);
                }
            }

            Console.WriteLine($"total sum of badge priorities: {badgePriority}");
        }

        public static char Match(string line1, string line2, string line3)
        {
            var common = line1.Intersect(line2);

            char match = common.Intersect(line3).First();
            return match;
        }

        public static int BadgePriority(char c)
        {
            int priority = 0;
            if (char.IsUpper(c))
            {
                priority = c - 38;

            }
            else
            {
                priority = c - 96;
            }

            return priority;
        }
    }
}
