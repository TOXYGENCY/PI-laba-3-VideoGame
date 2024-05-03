using System.Reflection;

namespace PI_laba_3_VideoGame
{
    public class VideoGame<L> where L : Level
    {
        protected List<L> Levels { get; private set; }

        public VideoGame()
        {
            this.Levels = new List<L>();
        }
        // Конструктор для создания игры со списком уровней
        public VideoGame(List<L> levels)
        {
            this.Levels = levels ??
                    throw new ArgumentNullException();
        }

        // Конструктор для создания игры с одним уровнем
        public VideoGame(L level) { 
            this.AddLevel(level);
        }

        // Добавление уровня в список
        public void AddLevel(L level)
        {
            if (this.Levels == null)
            {
                this.Levels = new List<L>();
            }

            try
            {
                this.Levels.Add(level);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Argument 'level' is null {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        // Получение уровней
        public List<L> GetLevels()
        {
            Console.Write($"VideoGame levels: ");
            foreach (var level in Levels)
            {
                Console.Write($"\"{level.GetLevelName()}\"");
                Console.Write("; ");
            }
            Console.Write("\n");
            return Levels;
        }
    }
}
