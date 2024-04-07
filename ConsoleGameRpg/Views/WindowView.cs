using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using ConsoleGameRpg.Engine.Graphics;
using ConsoleGameRpg.Engine.Sounds;
using ConsoleGameRpg.ViewModels;
using ConsoleGameRpg.Models.UIModels;

namespace ConsoleGameRpg.Views
{
    internal class WindowView
    {
        private static string _currentOutcomeView = "mainMenuView";

        public static void InitializeConsole(int screenWidth, int ScreenHeight, bool cursorVisible)
        {
            Console.SetWindowSize(screenWidth, ScreenHeight);
            Console.SetBufferSize(screenWidth, ScreenHeight);
            Console.CursorVisible = cursorVisible;
        }       

        public static void DrawIntro()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            GUIBuilder.WriteElement(LocalizationModel.LocalizedPaths["intro"], 36, 6, 5, ConsoleColor.White, ConsoleColor.Blue);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["introPressAnyKey"], 
                                 GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["introPressAnyKey"]), 34, 5, ConsoleColor.Blue, ConsoleColor.White);

            Console.ReadKey();
            DrawMainMenu(); 
        }

        public static void DrawPauseMenu() 
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            _currentOutcomeView = "pauseMenuView";
            Console.Clear();

            GUIBuilder.WriteHorizontalText(new string('▄', 170), 0, 0, 0, ConsoleColor.Green, ConsoleColor.White);
            GUIBuilder.WriteElement(LocalizationModel.LocalizedPaths["pathPauseMenuHeader"], 0, 1, 0, ConsoleColor.DarkGreen, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(new string('▀', 170), 0, 16, 0, ConsoleColor.Green, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(new string('╦', 170), 0, 17, 0, ConsoleColor.Magenta, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(new string('╩', 170), 0, 18, 0, ConsoleColor.Magenta, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText("╬" + new string('=', 30) + "╬", 69, 22, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);
            GUIBuilder.WriteHorizontalText("╬" + new string('=', 30) + "╬", 69, 34, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);

            GUIBuilder.WriteVerticalText("I", 18, 69, 23, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);
            GUIBuilder.WriteVerticalText("I", 18, 100, 23, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);

            GUIBuilder.WriteHorizontalText("╬" + new string('=', 30) + "╬", 69, 40, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);

            DrawSelectedPauseMenuOption();
           
            GUIBuilder.WriteElement(LocalizationModel.LocalizedPaths["mainMenuTip"],
                                          6, 24, 0, ConsoleColor.DarkGreen, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_1"],
                                       21, 24, 0, ConsoleColor.DarkGreen, ConsoleColor.White, 32);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_2"],
                                        21, 28, 0, ConsoleColor.DarkGreen, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_3"],
                                        21, 31, 0, ConsoleColor.DarkGreen, ConsoleColor.White);

            WindowController.PauseMenuSelector();
        }

        public static void DrawSelectedPauseMenuOption()
        {
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["resumeGame"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["resumeGame"]),
                                       25, 0, ConsoleColor.Yellow, ConsoleColor.DarkMagenta);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["legend"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["legend"]),
                                       28, 0, ConsoleColor.DarkMagenta, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["settingsStr"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["settingsStr"]),
                                        31, 0, ConsoleColor.DarkGreen, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"]),
                                        37, 0, ConsoleColor.Red, ConsoleColor.White);
        }

        public static void DrawMainMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            _currentOutcomeView = "mainMenuView";
            Console.Clear();

            GUIBuilder.WriteHorizontalText(new string('▄', 170), 0, 0, 0, ConsoleColor.Yellow, ConsoleColor.Magenta);
            GUIBuilder.WriteElement(LocalizationModel.LocalizedPaths["mainMenuHeader"], 0, 1, 0, ConsoleColor.Cyan, ConsoleColor.DarkMagenta);
            GUIBuilder.WriteHorizontalText(new string('▀', 170), 0, 17, 0, ConsoleColor.Yellow, ConsoleColor.Magenta);
            GUIBuilder.WriteHorizontalText(new string('╦', 170), 0, 18, 0, ConsoleColor.DarkYellow, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(new string('╩', 170), 0, 19, 0, ConsoleColor.DarkYellow, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText("╬" + new string('=', 30) + "╬", 69, 23, 0, ConsoleColor.Yellow, ConsoleColor.Magenta);
            GUIBuilder.WriteHorizontalText("╬" + new string('=', 30) + "╬", 69, 35, 0, ConsoleColor.Yellow, ConsoleColor.Magenta);

            GUIBuilder.WriteVerticalText("I", 11, 69, 24, 0, ConsoleColor.Yellow, ConsoleColor.Magenta);
            GUIBuilder.WriteVerticalText("I", 11, 100, 24, 0, ConsoleColor.Yellow, ConsoleColor.Magenta);

            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuCredits"],
                                        GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["mainMenuCredits"]),
                                        45, 0, ConsoleColor.DarkRed, ConsoleColor.Yellow);

            DrawSelectedMainMenuOption();

            GUIBuilder.WriteHorizontalText(new string('╦', 170), 0, 39, 0, ConsoleColor.DarkYellow, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(new string('╩', 170), 0, 40, 0, ConsoleColor.DarkYellow, ConsoleColor.White);
            GUIBuilder.WriteElement(LocalizationModel.LocalizedPaths["mainMenuTip"],
                                          6, 24, 0, ConsoleColor.DarkGreen, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_1"],
                                       21, 24, 0, ConsoleColor.DarkGreen, ConsoleColor.White, 32);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_2"],
                                        21, 28, 0, ConsoleColor.DarkGreen, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_3"],
                                        21, 31, 0, ConsoleColor.DarkGreen, ConsoleColor.White);

            WindowController.MainMenuSelector();
        }

        public static void DrawLevelsMenu()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            GUIBuilder.WriteHorizontalText(new string('▄', 170), 0, 0, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);
            GUIBuilder.WriteElement(LocalizationModel.LocalizedPaths["pathLevelsHeader"], 0, 1, 0, ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            GUIBuilder.WriteHorizontalText(new string('▀', 170), 0, 16, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);
            GUIBuilder.WriteHorizontalText(new string('╦', 170), 0, 17, 0, ConsoleColor.DarkMagenta, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(new string('╩', 170), 0, 18, 0, ConsoleColor.DarkMagenta, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(new string('╦', 170), 0, 40, 0, ConsoleColor.DarkMagenta, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(new string('╩', 170), 0, 41, 0, ConsoleColor.DarkMagenta, ConsoleColor.White);
            GUIBuilder.WriteElement(LocalizationModel.LocalizedPaths["mainMenuTip"],
                                          6, 24, 0, ConsoleColor.DarkMagenta, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_1"],
                                       21, 24, 0, ConsoleColor.DarkMagenta, ConsoleColor.White, 32);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_2"],
                                        21, 28, 0, ConsoleColor.DarkMagenta, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_3"],
                                        21, 31, 0, ConsoleColor.DarkMagenta, ConsoleColor.White);

            GUIBuilder.WriteHorizontalText("╬" + new string('=', 30) + "╬", 69, 21, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);
            GUIBuilder.WriteHorizontalText("╬" + new string('=', 30) + "╬", 69, 37, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);

            GUIBuilder.WriteVerticalText("I", 16, 69, 22, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);
            GUIBuilder.WriteVerticalText("I", 16, 100, 22, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);

            WindowController.LevelsMenuSelector();
        }

        public static void DrawSelectedLevelsMenuOption()
        {
            for (int i = 0; i < WindowController.LevelsList.Count; i++)
            {
                if (WindowController.LevelsList[i].IsAvailable)
                    GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings[$"level{i + 1}Str"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings[$"level{i + 1}Str"]),
                                           24 + i * 2, 0, ConsoleColor.Yellow, ConsoleColor.DarkGreen);
                else
                    GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings[$"level{i + 1}Str"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings[$"level{i + 1}Str"]),
                                           24 + i * 2, 0, ConsoleColor.Gray, ConsoleColor.DarkRed);
            }                     
        }

        public static void DrawExitMenu()
        {
            Console.Clear();
            GUIBuilder.WriteHorizontalText(new string('╦', 170), 0, 4, 0, ConsoleColor.DarkYellow, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(new string('╩', 170), 0, 5, 0, ConsoleColor.DarkYellow, ConsoleColor.White);

            GUIBuilder.WriteHorizontalText("╬" + new string('=', 59) + "╬", 54, 19, 0, ConsoleColor.Yellow, ConsoleColor.DarkMagenta);
            GUIBuilder.WriteHorizontalText("╬" + new string('=', 59) + "╬", 54, 27, 0, ConsoleColor.Yellow, ConsoleColor.DarkMagenta);

            GUIBuilder.WriteVerticalText("I", 7, 54, 20, 0, ConsoleColor.Yellow, ConsoleColor.Magenta);
            GUIBuilder.WriteVerticalText("I", 7, 114, 20, 0, ConsoleColor.Yellow, ConsoleColor.Magenta);

            GUIBuilder.WriteHorizontalText(new string('╦', 170), 0, 41, 0, ConsoleColor.DarkYellow, ConsoleColor.DarkMagenta);
            GUIBuilder.WriteHorizontalText(new string('╩', 170), 0, 42, 0, ConsoleColor.DarkYellow, ConsoleColor.DarkMagenta);



            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuExitQuestion"],
                                       GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["mainMenuExitQuestion"]),
                                       23, 1, ConsoleColor.Red, ConsoleColor.White);

            WindowController.ExitMenuSelector(_currentOutcomeView);
        }

        public static void DrawSelectedMainMenuOption()
        {
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["startGameStr"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["startGameStr"]),
                                       26, 0, ConsoleColor.DarkMagenta, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["settingsStr"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["settingsStr"]),
                                        29, 0, ConsoleColor.DarkGreen, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["exitStr"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["exitStr"]),
                                        32, 0, ConsoleColor.Red, ConsoleColor.White);
        }

        public static void DrawSettingsMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();

            GUIBuilder.WriteHorizontalText(new string('▄', 170), 0, 0, 0, ConsoleColor.Magenta, ConsoleColor.DarkBlue);
            GUIBuilder.WriteElement(LocalizationModel.LocalizedPaths["pathSettingsHeader"], 0, 1, 0, ConsoleColor.Cyan, ConsoleColor.Magenta);
            GUIBuilder.WriteHorizontalText(new string('▀', 170), 0, 16, 0, ConsoleColor.Magenta, ConsoleColor.DarkBlue);
            GUIBuilder.WriteHorizontalText(new string('╦', 170), 0, 17, 0, ConsoleColor.DarkYellow, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(new string('╩', 170), 0, 18, 0, ConsoleColor.DarkYellow, ConsoleColor.White);

            GUIBuilder.WriteHorizontalText("╬" + new string('=', 30) + "╬", 69, 22, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);
            GUIBuilder.WriteHorizontalText("╬" + new string('=', 30) + "╬", 69, 34, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);
            for (int i = 0; i < 18; i++)
            {
                GUIBuilder.WriteHorizontalText(new string('I', 1), 69, 23 + i, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);
            }
            for (int i = 0; i < 18; i++)
            {
                GUIBuilder.WriteHorizontalText(new string('I', 1), 100, 23 + i, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);
            }
            GUIBuilder.WriteHorizontalText("╬" + new string('=', 30) + "╬", 69, 40, 0, ConsoleColor.Magenta, ConsoleColor.Yellow);

            GUIBuilder.WriteElement(LocalizationModel.LocalizedPaths["mainMenuTip"],
                                          6, 24, 0, ConsoleColor.DarkBlue, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_1"],
                                       21, 24, 0, ConsoleColor.DarkBlue, ConsoleColor.White, 32);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_2"],
                                        21, 28, 0, ConsoleColor.DarkBlue, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["mainMenuTip_3"],
                                        21, 31, 0, ConsoleColor.DarkBlue, ConsoleColor.White);

            WindowController.SettingsMenuSelector(_currentOutcomeView);
        }

        public static void DrawSelectedSettingsMenuOption()
        {
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["settingsMenu_UILang"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["settingsMenu_UILang"]),
                                       25, 0, ConsoleColor.DarkRed, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["langRusStr"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["langRusStr"]),
                                        28, 0, ConsoleColor.Yellow, ConsoleColor.Magenta);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["langEngStr"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["langEngStr"]),
                                        31, 0, ConsoleColor.DarkBlue, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText(LocalizationModel.LocalizedStrings["isSoundsEnabledStr"], GUIBuilder.PlaceInCenter(LocalizationModel.LocalizedStrings["isSoundsEnabledStr"]),
                                        37, 0, ConsoleColor.White, ConsoleColor.Black);
        }

        public static void DrawLegendView()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            GUIBuilder.WriteHorizontalText("█" + new string('▀', 168) + "█", 0, 0, 0, ConsoleColor.Black, ConsoleColor.White);
            GUIBuilder.WriteVerticalText("▌", 45, 0, 1, 0, ConsoleColor.Black, ConsoleColor.White);
            GUIBuilder.WriteVerticalText("▐", 45, 169, 1, 0, ConsoleColor.Black, ConsoleColor.White);
            GUIBuilder.WriteHorizontalText("█" + new string('▄', 168) + "█", 0, 46, 0, ConsoleColor.Black, ConsoleColor.White);

            WindowController.LegendViewSelector();
        }
    }
}
