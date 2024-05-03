namespace PI_laba_3_VideoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var E1M1_level = new Level("E1M1");
            var E1M2_level = new Level("E1M2");
            var Moon_level = new Level("Isn't it a cheese?");
            var VW_level = new Level("I would like to purchase a 2017 Polo.");
            var ending_level = new Level("Why are you still alive?");

            List<Level> AllGameLevels = new List<Level>
            {
                E1M1_level,
                E1M2_level,
                Moon_level,
                VW_level,
                ending_level
            };

            var Roblox = new VideoGame<Level>(AllGameLevels);
            var RobloxLevels = Roblox.GetLevels();

            var GTA_Mario_Edition = new VideoGame<Level>();
            GTA_Mario_Edition.GetLevels();

            var TheProject = new VideoGame<Level>(new Level("TheLevel"));
            TheProject.GetLevels();
        }
    }
}