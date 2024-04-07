using ConsoleGameRpg.Views;
using ConsoleGameRpg.Views.UIViews;
using System.Text;

namespace ConsoleGameRpg.Engine.Graphics
{
    internal class LevelBuilder
    {
        private const byte _charInRowEnd = 2;
        private readonly ClockView _clockView = new ClockView();

        private char[] _screen = new char[ScreenLength];
        
        private string _pathToMapFile;
        private StringBuilder _map = new StringBuilder(10000);
        
        private static int _playerX = 0;
        private static int _playerY = 0;

        private static int _playerPosition = 0;

        public static int PlayerPosition
        {
            get { return _playerY * (ScreenWidth + _charInRowEnd) + _playerX; }
            set { _playerPosition = value; }
        }

        private ConsoleColor _backgroundColor;
        private ConsoleColor _foregroundColor;

        public static byte ScreenWidth { get; } = 170; // 170
        public static byte ScreenHeight { get; } = 47;  // 47
        public static int ScreenLength { get; } = ScreenWidth * ScreenHeight + ScreenHeight * _charInRowEnd - _charInRowEnd;  // 8082

        public bool IsAvailable { get; set; }

        public LevelBuilder(/*ConsoleColor backgroundColor, ConsoleColor foregroundColor*/)
        {
            //BackgroundColor = backgroundColor;
            //ForegroundColor = foregroundColor;
        }

        public LevelBuilder(string pathToMapFile,
                   int startPlayerPosX,
                   int startPlayerPosY,
                   bool isAvailable,
                   ConsoleColor backgroundColor,
                   ConsoleColor foregroundColor)
        {
            _pathToMapFile = pathToMapFile;
            _playerX = startPlayerPosX;
            _playerY = startPlayerPosY;
            IsAvailable = isAvailable;
            _backgroundColor = backgroundColor;
            _foregroundColor = foregroundColor;
        }

        private bool IsUnpassable(char symb1 = '█', char symb2 = '▓', char symb3 = '▒', char symb4 = '░', char symb5 = '#', char symb6 = 'X')
        {
            if (_map[PlayerPosition] == symb1 ||
                _map[PlayerPosition] == symb2 ||
                _map[PlayerPosition] == symb3 ||
                _map[PlayerPosition] == symb4 ||
                _map[PlayerPosition] == symb5 ||
                _map[PlayerPosition] == symb6)
                return true; 
            else 
                return false;
        }

        private bool IsUnpassableForMoveRight(char moveableObj = '■', char symb1 = '█', char symb2 = '▓', char symb3 = '▒', char symb4 = '░', char symb5 = '#', char symb6 = 'X')
        {
            if (
                (_map[PlayerPosition + 1] == symb1 && _map[PlayerPosition ] == moveableObj) ||
                (_map[PlayerPosition + 1] == symb2 && _map[PlayerPosition ] == moveableObj) ||
                (_map[PlayerPosition + 1] == symb3 && _map[PlayerPosition ] == moveableObj) ||
                (_map[PlayerPosition + 1] == symb4 && _map[PlayerPosition ] == moveableObj) ||
                (_map[PlayerPosition + 1] == symb5 && _map[PlayerPosition ] == moveableObj) ||
                (_map[PlayerPosition + 1] == symb6 && _map[PlayerPosition ] == moveableObj)
                //
                )
                return true;
            else
                return false;
        }

        private bool IsUnpassableForMoveLeft(char moveableObj = '■', char symb1 = '█', char symb2 = '▓', char symb3 = '▒', char symb4 = '░', char symb5 = '#', char symb6 = 'X')
        {
            if (
                //
                (_map[PlayerPosition - 1] == symb1 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition - 1] == symb2 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition - 1] == symb3 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition - 1] == symb4 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition - 1] == symb5 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition - 1] == symb6 && _map[PlayerPosition] == moveableObj)
               )
                return true;
            else
                return false;
        }

        private bool IsUnpassableForMoveDown(char moveableObj = '■', char symb1 = '█', char symb2 = '▓', char symb3 = '▒', char symb4 = '░', char symb5 = '#', char symb6 = 'X')
        {
            if (
                //
                (_map[PlayerPosition + (ScreenWidth + _charInRowEnd)] == symb1 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition + (ScreenWidth + _charInRowEnd)] == symb2 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition + (ScreenWidth + _charInRowEnd)] == symb3 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition + (ScreenWidth + _charInRowEnd)] == symb4 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition + (ScreenWidth + _charInRowEnd)] == symb5 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition + (ScreenWidth + _charInRowEnd)] == symb6 && _map[PlayerPosition] == moveableObj)
                //
                )
                return true;
            else
                return false;
        }

        private bool IsUnpassableForMoveUp(char moveableObj = '■', char symb1 = '█', char symb2 = '▓', char symb3 = '▒', char symb4 = '░', char symb5 = '#', char symb6 = 'X')
        {
            if (
                (_map[PlayerPosition - (ScreenWidth + _charInRowEnd)] == symb1 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition - (ScreenWidth + _charInRowEnd)] == symb2 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition - (ScreenWidth + _charInRowEnd)] == symb3 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition - (ScreenWidth + _charInRowEnd)] == symb4 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition - (ScreenWidth + _charInRowEnd)] == symb5 && _map[PlayerPosition] == moveableObj) ||
                (_map[PlayerPosition - (ScreenWidth + _charInRowEnd)] == symb6 && _map[PlayerPosition] == moveableObj)
               )
                return true;
            else
                return false;
        }

        private bool IsMovable(char movableObj = '■')
        {
            if (_map[PlayerPosition] == movableObj)
                return true;
            else
                return false;
        }

        private void MoveObjectRight()
        {
            _map = _map.Replace(' ', '■', PlayerPosition + 1, 1).Replace('■', ' ', PlayerPosition, 1);
        }

        private void MoveObjectLeft()
        {
            _map = _map.Replace(' ', '■', PlayerPosition - 1, 1).Replace('■', ' ', PlayerPosition, 1);
        }

        private void MoveObjectUp()
        {
            _map = _map.Replace(' ', '■', PlayerPosition - (ScreenWidth + _charInRowEnd), 1).Replace('■', ' ', PlayerPosition, 1);
        }

        private void MoveObjectDown()
        {
            _map = _map.Replace(' ', '■', PlayerPosition + (ScreenWidth + _charInRowEnd), 1).Replace('■', ' ', PlayerPosition, 1);
        }

        private bool IsReducibleFirstObstacle(char symbol = '▓')
        {
            if (_map[(PlayerPosition) + 1] == symbol ||
                _map[(PlayerPosition) - 1] == symbol ||
                _map[(PlayerPosition) + (ScreenWidth + _charInRowEnd)] == symbol ||
                _map[(PlayerPosition) - (ScreenWidth + _charInRowEnd)] == symbol)
                return true;
            else return false;
        }

        private bool IsReducibleSecondObstacle(char symbol = '▒')
        {
            if (_map[(PlayerPosition) + 1] == symbol ||
                _map[(PlayerPosition) - 1] == symbol ||
                _map[(PlayerPosition) + (ScreenWidth + _charInRowEnd)] == symbol ||
                _map[(PlayerPosition) - (ScreenWidth + _charInRowEnd)] == symbol)
                return true;
            else return false;
        }

        private bool IsReducibleThirdObstacle(char symbol = '░')
        {

            if (_map[(PlayerPosition) + 1] == symbol ||
                _map[(PlayerPosition) - 1] == symbol ||
                _map[(PlayerPosition) + (ScreenWidth + _charInRowEnd)] == symbol ||
                _map[(PlayerPosition) - (ScreenWidth + _charInRowEnd)] == symbol)
                return true;
            else return false;
        }

        public void InitializeScreen()
        {
            _map.AppendLine(File.ReadAllText(_pathToMapFile));          
        }

        public void ConstructScreen()
        {          
            for (int x = 0; x < ScreenWidth; x++)
            {
                for (int y = 0; y < ScreenHeight; y++)
                {
                    _screen[y * (ScreenWidth + _charInRowEnd) + x] = _map[y * (ScreenWidth + _charInRowEnd) + x];
                }
            }
            _clockView.DisplayClockAndPlayerPos(_screen);
        }

        public void DrawScreen()
        {
            Console.BackgroundColor = _backgroundColor;
            Console.ForegroundColor = _foregroundColor;
            Console.SetCursorPosition(0, 0);
            Console.Write(_screen, 0, ScreenLength);
        }

        public void DrawPlayer(char player = '☻')
        {
            _screen[PlayerPosition] = player;         
        }

        public void ReduceFirstObstacle(char oldChar = '▓', char newChar = '▒')
        {
            _map = _map.Replace(oldChar, newChar, PlayerPosition + 1, 1);
            _map = _map.Replace(oldChar, newChar, PlayerPosition - 1, 1);
            _map = _map.Replace(oldChar, newChar, PlayerPosition + (ScreenWidth + _charInRowEnd), 1);
            _map = _map.Replace(oldChar, newChar, PlayerPosition - (ScreenWidth + _charInRowEnd), 1);
        }

        public void ReduceSecondObstacle(char oldChar = '▒', char newChar = '░')
        {
            _map = _map.Replace(oldChar, newChar, PlayerPosition + 1, 1);
            _map = _map.Replace(oldChar, newChar, PlayerPosition - 1, 1);
            _map = _map.Replace(oldChar, newChar, PlayerPosition + (ScreenWidth + _charInRowEnd), 1);
            _map = _map.Replace(oldChar, newChar, PlayerPosition - (ScreenWidth + _charInRowEnd), 1);
        }

        public void ReduceThirdObstacle(char oldChar = '░', char newChar = ' ')
        {
            _map = _map.Replace(oldChar, newChar, PlayerPosition + 1, 1);
            _map = _map.Replace(oldChar, newChar, PlayerPosition - 1, 1);
            _map = _map.Replace(oldChar, newChar, PlayerPosition + (ScreenWidth + _charInRowEnd), 1);
            _map = _map.Replace(oldChar, newChar, PlayerPosition - (ScreenWidth + _charInRowEnd), 1);
        }

        public void ControlBehavior()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey consoleKey = Console.ReadKey(true).Key;

                switch (consoleKey)
                {
                    case ConsoleKey.A:
                        {
                            _playerX -= 1;

                            if (IsUnpassable() || IsUnpassableForMoveLeft())
                            {
                                _playerX += 1;
                            }
                            else if (IsMovable())
                            {
                                MoveObjectLeft();
                            }
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            _playerX += 1;

                            if (IsUnpassable() || IsUnpassableForMoveRight())
                            {
                                _playerX -= 1;
                            }
                            else if (IsMovable())
                            {
                                MoveObjectRight();
                            }
                            break;
                        }
                    case ConsoleKey.W:
                        {
                            _playerY -= 1;

                            if (IsUnpassable() || IsUnpassableForMoveUp())
                            {
                                _playerY += 1;
                            }
                            else if (IsMovable())
                            {
                                MoveObjectUp();
                            }
                            break;
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            _playerY += 1;

                            if (IsUnpassable() || IsUnpassableForMoveDown())
                            {
                                _playerY -= 1;
                            }
                            else if (IsMovable())
                            {
                                MoveObjectDown();
                            }
                            break;
                        }
                    case ConsoleKey.X:
                        {
                            if (IsReducibleFirstObstacle())
                            {
                                ReduceFirstObstacle();
                                break;
                            }
                            else if (IsReducibleSecondObstacle())
                            {
                                ReduceSecondObstacle();
                                break;
                            }
                            else
                            {
                                ReduceThirdObstacle();
                                break;
                            }
                        }
                    //case ConsoleKey.C:
                    //    {
                    //        if (IsReducibleSecondObstacle())
                    //            ReduceSecondObstacle();
                    //        break;
                    //    }
                    //case ConsoleKey.V:
                    //    {
                    //        if (IsReducibleThirdObstacle())
                    //            ReduceThirdObstacle();
                    //        break;
                    //    }
                    case ConsoleKey.Escape:
                        {
                            WindowView.DrawPauseMenu();
                            break;
                        }
                }
            }
        }
    }
}
