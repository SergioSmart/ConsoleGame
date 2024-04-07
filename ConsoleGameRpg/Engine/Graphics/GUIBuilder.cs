using System.Text;

namespace ConsoleGameRpg.Engine.Graphics
{
    internal static class GUIBuilder
    {
        private static int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach (var line in lines)
            {
                if (line.Length > maxLength)
                    maxLength = line.Length;
            }

            return maxLength;
        }

        public static void WriteElement(string pathToFile, int cursorPosLeft, 
                                 int cursorPosTop, int delay, 
                                 ConsoleColor backgroundColor, 
                                 ConsoleColor foregroundColor) 
        {
            string[] file = File.ReadAllLines(pathToFile);

            char[,] graphicElement = new char[GetMaxLengthOfLine(file), file.Length];

            for (int x = 0; x < graphicElement.GetLength(0); x++)
                for (int y = 0; y < graphicElement.GetLength(1); y++)
                    graphicElement[x, y] = file[y][x];

            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            for (int y = 0; y < graphicElement.GetLength(1); y++)
            {
                for (int x = 0; x < graphicElement.GetLength(0); x++)
                {
                    Console.SetCursorPosition(cursorPosLeft + x, cursorPosTop + y);                   
                    Console.Write(graphicElement[x, y]);
                }
                Console.Write("\n");
                Thread.Sleep(delay);
            }    
        }

        public static int PlaceInCenter(string guiString)
        {
            return (LevelBuilder.ScreenWidth - guiString.Length) / 2;
        }

        public static void WriteHorizontalText(string text, int cursorPosLeft, 
                              int cursorPosTop, int delay,  
                              ConsoleColor backgroundColor, 
                              ConsoleColor foregroundColor, 
                              int lengthOfRow = int.MaxValue)
        {
            int amountOfEnters = 1;
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.SetCursorPosition(cursorPosLeft, cursorPosTop);

            if(text.Length > lengthOfRow)
            {
                text = text.Insert(lengthOfRow, "\0");
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\0')
                {
                    Console.SetCursorPosition(cursorPosLeft, cursorPosTop + amountOfEnters);
                    amountOfEnters++;
                }
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
        }    
        
        public static void WriteVerticalText(string text, int height,
                             int cursorPosLeft,
                              int cursorPosTop, int delay,
                              ConsoleColor backgroundColor,
                              ConsoleColor foregroundColor,
                              int lengthOfRow = int.MaxValue)
        {
            for (int i = 0; i < height; i++)
            {
                WriteHorizontalText(text, cursorPosLeft, cursorPosTop + i, 0, backgroundColor, foregroundColor);
            }
        }
    }
}
