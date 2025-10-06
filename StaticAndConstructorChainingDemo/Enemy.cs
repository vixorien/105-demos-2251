// Chris Cascioli
// 10/6/25
// Enemy class to explore the use of
// static, optional params and constructor chaining

namespace StaticAndConstructorChainingDemo
{
    internal class Enemy
    {
        // Fields
        private int x;
        private int y;
        private char sprite;
        private ConsoleColor color;

        /// <summary>
        /// A static number that exists as a single
        /// value in memory "shared" by all instances
        /// of this class
        /// </summary>
        private static int enemyCount;

        // Constructor

        /// <summary>
        /// Creates a default enemy at the top
        /// left corner of the window
        /// 
        /// An example of CONSTRUCTOR CHAINING, where
        /// one constructor calls another as part of
        /// its setup process.
        /// </summary>
        public Enemy() : this(0, 0, '@', ConsoleColor.White)
        {
        }

        /// <summary>
        /// Creates an enemy with a default color
        /// 
        /// Another example of CONSTRUCTOR CHAINING
        /// </summary>
        /// <param name="x">Position from left</param>
        /// <param name="y">Position from top</param>
        /// <param name="sprite">Displayable character</param>
        public Enemy(int x, int y, char sprite) :
            this(x, y, sprite, ConsoleColor.White)
        {
        }

        /// <summary>
        /// Creates a custom enemy
        /// </summary>
        /// <param name="x">Position from left</param>
        /// <param name="y">Position from top</param>
        /// <param name="sprite">Displayable character</param>
        /// <param name="color">Color of character</param>
        public Enemy(int x, int y, char sprite, ConsoleColor color)
        {
            this.x = x;
            this.y = y;
            this.sprite = sprite;
            this.color = color;

            enemyCount++;
        }


        // Methods

        /// <summary>
        /// Gets the total enemy count
        /// </summary>
        /// <returns>Number of enemies created</returns>
        public static int GetEnemyCount()
        {
            return enemyCount;
        }


        /// <summary>
        /// Displays the character - with an OPTIONAL PARAMETER
        /// </summary>
        /// <param name="bgColor">Optional background color</param>
        public void Display(ConsoleColor bgColor = ConsoleColor.Black)
        {
            // Move the cursor
            Console.CursorLeft = x;
            Console.CursorTop = y;

            // Display using the proper color
            Console.ForegroundColor = color;
            Console.BackgroundColor = bgColor;
            Console.Write(sprite);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
