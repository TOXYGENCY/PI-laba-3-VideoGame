namespace PI_laba_3_VideoGame
{
    public class Level
    {
        protected string LevelName { get; private set; }

        /// <summary>
        /// Конструктор класса Level
        /// </summary>
        /// <param name="LevelName">Текст типа string</param>
        public Level(string lname)
        {

            if (lname == null || lname.GetType() != typeof(string))
            {
                Console.WriteLine($"Значение LevelName должно быть типа {typeof(string)}! Сейчас: {lname.GetType()}");
            }
            else
            {
                this.LevelName = lname;
            }
        }

        public string GetLevelName()
        {
            return this.LevelName;
        }
    }
}
