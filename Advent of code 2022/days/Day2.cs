namespace Advent_of_code_2022.days
{
    public static class Day2
    {
        static Dictionary<string, int> scores = new Dictionary<string, int>()
        {
            {"A", 1 }, // rock
            {"X", 1 },
            {"B", 2 }, // paper
            {"Y", 2 },
            {"C", 3 }, // scissor
            {"Z", 3 },
        };

        public static int CountMatchScore(string att, string def)
        {
            int score = 0;
            if (scores[att] == scores[def])
            {
                score += 3;
            }
            else if (SuccessfulDef(att, def))
            {
                score += 6;
            }
            score += scores[def];
            return score;
        }

        static Dictionary<string, string> loose = new Dictionary<string, string>()
        {
            {"A" , "Z" },
            {"B" , "X" },
            {"C" , "Y" },
        };

        static Dictionary<string, string> win = new Dictionary<string, string>()
        {
            {"A" , "Y" },
            {"B" , "Z" },
            {"C" , "X" },
        };

        static Dictionary<string, string> draw = new Dictionary<string, string>()
        {
            {"A" , "X" },
            {"B" , "Y" },
            {"C" , "Z" },
        };

        public static bool SuccessfulDef(string att, string def)
        {

            return att == "C" && def == "X" || att == "B" && def == "Z" || att == "A" && def == "Y";
        }


        public static int Play(string path)
        {
            int totalScore = 0;
            string[] file = File.ReadAllLines(path);
            foreach (string line in file)
            {
                string[] pair = line.Split(" ");
                if (pair[1] == "X")
                {
                    pair[1] = loose[pair[0]];
                }
                else if (pair[1] == "Z")
                {
                    pair[1] = win[pair[0]];
                }
                else
                {
                    pair[1] = draw[pair[0]];
                }
                int score = CountMatchScore(pair[0], pair[1]);
                totalScore += score;

            }
            return totalScore;
        }

    }
}
