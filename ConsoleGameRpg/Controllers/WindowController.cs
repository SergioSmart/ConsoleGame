using ConsoleGameRpg.Engine.Graphics;
using ConsoleGameRpg.Engine.Sounds;
using ConsoleGameRpg.Models.UIModels;
using ConsoleGameRpg.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameRpg.ViewModels
{
    internal class WindowController
    {
        private static sbyte _selectorMainMenu = 0;
        private static sbyte _selectorSettingsMenu = 0;
        private static sbyte _selectorLevelsMenu = 0;
        private static sbyte _selectorPauseMenu = 0;

        public static List<LevelBuilder> LevelsList = new List<LevelBuilder>() { 
                                                                                 new LevelBuilder(LocalizationModel.LocalizedPaths["level1"], 62, 6, true, ConsoleColor.Blue, ConsoleColor.White), 
                                                                                 new LevelBuilder(LocalizationModel.LocalizedPaths["level2"], 62, 6, false, ConsoleColor.Black, ConsoleColor.White), 
                                                                                 new LevelBuilder(LocalizationModel.LocalizedPaths["level3"], 62, 6, false, ConsoleColor.Black, ConsoleColor.White), 
                                                                                 new LevelBuilder(LocalizationModel.LocalizedPaths["level4"], 62, 6, false, ConsoleColor.Black, ConsoleColor.White), 
                                                                                 new LevelBuilder(LocalizationModel.LocalizedPaths["level5"], 62, 6, false, ConsoleColor.Black, ConsoleColor.White), 
                                                                                 new LevelBuilder(LocalizationModel.LocalizedPaths["level6"], 62, 6, false, ConsoleColor.Black, ConsoleColor.White), 
                                                                               };

        public static void LevelsMenuSelector()
        {
            while (true)
            {
                if (_selectorLevelsMenu == 0)
                {
                    LocalizationModel.LocalizedStrings["level1Str"] = LocalizationModel.LocalizedStrings["level1Str"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["level2Str"] = LocalizationModel.LocalizedStrings["level2Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level3Str"] = LocalizationModel.LocalizedStrings["level3Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level4Str"] = LocalizationModel.LocalizedStrings["level4Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level5Str"] = LocalizationModel.LocalizedStrings["level5Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level6Str"] = LocalizationModel.LocalizedStrings["level6Str"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedLevelsMenuOption();
                }
                else if (_selectorLevelsMenu == 1)
                {
                    LocalizationModel.LocalizedStrings["level1Str"] = LocalizationModel.LocalizedStrings["level1Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level2Str"] = LocalizationModel.LocalizedStrings["level2Str"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["level3Str"] = LocalizationModel.LocalizedStrings["level3Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level4Str"] = LocalizationModel.LocalizedStrings["level4Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level5Str"] = LocalizationModel.LocalizedStrings["level5Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level6Str"] = LocalizationModel.LocalizedStrings["level6Str"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedLevelsMenuOption();
                }
                else if (_selectorLevelsMenu == 2)
                {
                    LocalizationModel.LocalizedStrings["level1Str"] = LocalizationModel.LocalizedStrings["level1Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level2Str"] = LocalizationModel.LocalizedStrings["level2Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level3Str"] = LocalizationModel.LocalizedStrings["level3Str"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["level4Str"] = LocalizationModel.LocalizedStrings["level4Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level5Str"] = LocalizationModel.LocalizedStrings["level5Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level6Str"] = LocalizationModel.LocalizedStrings["level6Str"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedLevelsMenuOption();
                }
                else if (_selectorLevelsMenu == 3)
                {
                    LocalizationModel.LocalizedStrings["level1Str"] = LocalizationModel.LocalizedStrings["level1Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level2Str"] = LocalizationModel.LocalizedStrings["level2Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level3Str"] = LocalizationModel.LocalizedStrings["level3Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level4Str"] = LocalizationModel.LocalizedStrings["level4Str"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["level5Str"] = LocalizationModel.LocalizedStrings["level5Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level6Str"] = LocalizationModel.LocalizedStrings["level6Str"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedLevelsMenuOption();
                }
                else if (_selectorLevelsMenu == 4)
                {
                    LocalizationModel.LocalizedStrings["level1Str"] = LocalizationModel.LocalizedStrings["level1Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level2Str"] = LocalizationModel.LocalizedStrings["level2Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level3Str"] = LocalizationModel.LocalizedStrings["level3Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level4Str"] = LocalizationModel.LocalizedStrings["level4Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level5Str"] = LocalizationModel.LocalizedStrings["level5Str"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["level6Str"] = LocalizationModel.LocalizedStrings["level6Str"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedLevelsMenuOption();
                }
                else if (_selectorLevelsMenu == 5)
                {
                    LocalizationModel.LocalizedStrings["level1Str"] = LocalizationModel.LocalizedStrings["level1Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level2Str"] = LocalizationModel.LocalizedStrings["level2Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level3Str"] = LocalizationModel.LocalizedStrings["level3Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level4Str"] = LocalizationModel.LocalizedStrings["level4Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level5Str"] = LocalizationModel.LocalizedStrings["level5Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level6Str"] = LocalizationModel.LocalizedStrings["level6Str"].Replace('∙', '►').Replace('·', '◄');

                    WindowView.DrawSelectedLevelsMenuOption();
                }
                else if (_selectorLevelsMenu > 5)
                {
                    _selectorLevelsMenu = 0;

                    LocalizationModel.LocalizedStrings["level1Str"] = LocalizationModel.LocalizedStrings["level1Str"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["level2Str"] = LocalizationModel.LocalizedStrings["level2Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level3Str"] = LocalizationModel.LocalizedStrings["level3Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level4Str"] = LocalizationModel.LocalizedStrings["level4Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level5Str"] = LocalizationModel.LocalizedStrings["level5Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level6Str"] = LocalizationModel.LocalizedStrings["level6Str"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedLevelsMenuOption();
                }
                else if (_selectorLevelsMenu < 0)
                {
                    _selectorLevelsMenu = 5;

                    LocalizationModel.LocalizedStrings["level1Str"] = LocalizationModel.LocalizedStrings["level1Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level2Str"] = LocalizationModel.LocalizedStrings["level2Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level3Str"] = LocalizationModel.LocalizedStrings["level3Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level4Str"] = LocalizationModel.LocalizedStrings["level4Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level5Str"] = LocalizationModel.LocalizedStrings["level5Str"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["level6Str"] = LocalizationModel.LocalizedStrings["level6Str"].Replace('∙', '►').Replace('·', '◄');

                    WindowView.DrawSelectedLevelsMenuOption();
                }

                ConsoleKey consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.W:
                        {
                            _selectorLevelsMenu -= 1;
                            GameMusic.PlayButtonSelected(GameMusic.IsSoundsEnabled);
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            _selectorLevelsMenu += 1;
                            GameMusic.PlayButtonSelected(GameMusic.IsSoundsEnabled);
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            if (_selectorLevelsMenu == 0 && LevelsList[0].IsAvailable)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LevelView.DrawLevel(LevelsList[_selectorLevelsMenu]);
                            }
                            else if (_selectorLevelsMenu == 1)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LevelView.DrawLevel(LevelsList[_selectorLevelsMenu]);
                            }
                            else if (_selectorLevelsMenu == 2)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LevelView.DrawLevel(LevelsList[_selectorLevelsMenu]);
                            }
                            else if (_selectorLevelsMenu == 3)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LevelView.DrawLevel(LevelsList[_selectorLevelsMenu]);
                            }
                            else if (_selectorLevelsMenu == 4)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LevelView.DrawLevel(LevelsList[_selectorLevelsMenu]);
                            }
                            else if (_selectorLevelsMenu == 5)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LevelView.DrawLevel(LevelsList[_selectorLevelsMenu]);
                            }
                            else if (_selectorLevelsMenu == 6)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LevelView.DrawLevel(LevelsList[_selectorLevelsMenu]);
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                            WindowView.DrawMainMenu();
                        }
                        break;
                }
            }
        }

        public static void ExitMenuSelector(string outcomeView)
        {
            ConsoleKey consoleKey = Console.ReadKey(true).Key;
            switch (consoleKey)
            {
                case ConsoleKey.Escape:
                    {
                        GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                        if (outcomeView == "mainMenuView")
                            WindowView.DrawMainMenu();
                        else if (outcomeView == "pauseMenuView")
                            WindowView.DrawPauseMenu();
                        break;
                    }
                case ConsoleKey.Enter:
                    {
                        GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                        if (outcomeView == "mainMenuView")
                        {
                            Console.SetCursorPosition(0, 43);
                            Environment.Exit(0);
                        }
                        else if (outcomeView == "pauseMenuView")
                            WindowView.DrawMainMenu();                      
                        break;
                    }
                default:
                    GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                    WindowView.DrawExitMenu();
                    break;
            }
        }

        public static void PauseMenuSelector()
        {
            while (true)
            {
                if (_selectorPauseMenu == 0)
                {
                    LocalizationModel.LocalizedStrings["resumeGame"] = LocalizationModel.LocalizedStrings["resumeGame"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["legend"] = LocalizationModel.LocalizedStrings["legend"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"] = LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedPauseMenuOption();
                }
                else if ( _selectorPauseMenu == 1)
                {
                    LocalizationModel.LocalizedStrings["resumeGame"] = LocalizationModel.LocalizedStrings["resumeGame"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["legend"] = LocalizationModel.LocalizedStrings["legend"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"] = LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedPauseMenuOption();
                }
                else if (_selectorPauseMenu == 2)
                {
                    LocalizationModel.LocalizedStrings["resumeGame"] = LocalizationModel.LocalizedStrings["resumeGame"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["legend"] = LocalizationModel.LocalizedStrings["legend"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"] = LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedPauseMenuOption();
                }
                else if (_selectorPauseMenu == 3)
                {
                    LocalizationModel.LocalizedStrings["resumeGame"] = LocalizationModel.LocalizedStrings["resumeGame"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["legend"] = LocalizationModel.LocalizedStrings["legend"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"] = LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"].Replace('∙', '►').Replace('·', '◄');

                    WindowView.DrawSelectedPauseMenuOption();
                }
                else if (_selectorPauseMenu > 3)
                {
                    _selectorPauseMenu = 0;

                    LocalizationModel.LocalizedStrings["resumeGame"] = LocalizationModel.LocalizedStrings["resumeGame"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["legend"] = LocalizationModel.LocalizedStrings["legend"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"] = LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedPauseMenuOption();
                }
                else if (_selectorPauseMenu < 0)
                {
                    _selectorPauseMenu = 3;

                    LocalizationModel.LocalizedStrings["resumeGame"] = LocalizationModel.LocalizedStrings["resumeGame"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["legend"] = LocalizationModel.LocalizedStrings["legend"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"] = LocalizationModel.LocalizedStrings["pauseMenu_ExitToMainMenu"].Replace('∙', '►').Replace('·', '◄');

                    WindowView.DrawSelectedPauseMenuOption();
                }

                ConsoleKey consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.W:
                        {
                            _selectorPauseMenu -= 1;
                            GameMusic.PlayButtonSelected(GameMusic.IsSoundsEnabled);
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            _selectorPauseMenu += 1;
                            GameMusic.PlayButtonSelected(GameMusic.IsSoundsEnabled);
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            if (_selectorPauseMenu == 0)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LevelView.DrawLevel(LevelsList[_selectorLevelsMenu]);
                            }
                            else if (_selectorPauseMenu == 1)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                WindowView.DrawLegendView();
                            }
                            else if (_selectorPauseMenu == 2)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                WindowView.DrawSettingsMenu();
                            }
                            else if (_selectorPauseMenu == 3)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                WindowView.DrawExitMenu();
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                            LevelView.DrawLevel(LevelsList[_selectorLevelsMenu]);
                            break;
                        }
                }
            }
        }

        public static void MainMenuSelector()
        {
            while (true)
            {
                if (_selectorMainMenu == 0)
                {
                    LocalizationModel.LocalizedStrings["startGameStr"] = LocalizationModel.LocalizedStrings["startGameStr"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["exitStr"] = LocalizationModel.LocalizedStrings["exitStr"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedMainMenuOption();
                }
                else if (_selectorMainMenu == 1)
                {
                    LocalizationModel.LocalizedStrings["startGameStr"] = LocalizationModel.LocalizedStrings["startGameStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["exitStr"] = LocalizationModel.LocalizedStrings["exitStr"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedMainMenuOption();
                }
                else if (_selectorMainMenu == 2)
                {
                    LocalizationModel.LocalizedStrings["startGameStr"] = LocalizationModel.LocalizedStrings["startGameStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["exitStr"] = LocalizationModel.LocalizedStrings["exitStr"].Replace('∙', '►').Replace('·', '◄');

                    WindowView.DrawSelectedMainMenuOption();
                }
                else if (_selectorMainMenu > 2)
                {
                    _selectorMainMenu = 0;

                    LocalizationModel.LocalizedStrings["startGameStr"] = LocalizationModel.LocalizedStrings["startGameStr"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["exitStr"] = LocalizationModel.LocalizedStrings["exitStr"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedMainMenuOption();
                }
                else if (_selectorMainMenu < 0)
                {
                    _selectorMainMenu = 2;

                    LocalizationModel.LocalizedStrings["startGameStr"] = LocalizationModel.LocalizedStrings["startGameStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["settingsStr"] = LocalizationModel.LocalizedStrings["settingsStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["exitStr"] = LocalizationModel.LocalizedStrings["exitStr"].Replace('∙', '►').Replace('·', '◄');

                    WindowView.DrawSelectedMainMenuOption();
                }

                ConsoleKey consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.W:
                        {
                            _selectorMainMenu -= 1;
                            GameMusic.PlayButtonSelected(GameMusic.IsSoundsEnabled);
                            break;
                        }                   
                    case ConsoleKey.S:
                        {
                            _selectorMainMenu += 1;
                            GameMusic.PlayButtonSelected(GameMusic.IsSoundsEnabled);
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            if (_selectorMainMenu == 0)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                WindowView.DrawLevelsMenu();
                            }
                            else if (_selectorMainMenu == 1)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                WindowView.DrawSettingsMenu();
                            }
                            else if (_selectorMainMenu == 2)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                WindowView.DrawExitMenu();
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                            WindowView.DrawExitMenu();
                            break;
                        }
                }
            }
        }
        public static void SettingsMenuSelector(string outcomeView)
        {
            while (true)
            {
                if (_selectorSettingsMenu == 0)
                {
                    LocalizationModel.LocalizedStrings["langRusStr"] = LocalizationModel.LocalizedStrings["langRusStr"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["langEngStr"] = LocalizationModel.LocalizedStrings["langEngStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["isSoundsEnabledStr"] = LocalizationModel.LocalizedStrings["isSoundsEnabledStr"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedSettingsMenuOption();
                }
                else if (_selectorSettingsMenu == 1)
                {
                    LocalizationModel.LocalizedStrings["langRusStr"] = LocalizationModel.LocalizedStrings["langRusStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["langEngStr"] = LocalizationModel.LocalizedStrings["langEngStr"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["isSoundsEnabledStr"] = LocalizationModel.LocalizedStrings["isSoundsEnabledStr"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedSettingsMenuOption();
                }
                else if (_selectorSettingsMenu == 2)
                {
                    LocalizationModel.LocalizedStrings["langRusStr"] = LocalizationModel.LocalizedStrings["langRusStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["langEngStr"] = LocalizationModel.LocalizedStrings["langEngStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["isSoundsEnabledStr"] = LocalizationModel.LocalizedStrings["isSoundsEnabledStr"].Replace('∙', '►').Replace('·', '◄');

                    WindowView.DrawSelectedSettingsMenuOption();
                }
                else if (_selectorSettingsMenu > 2)
                {
                    _selectorSettingsMenu = 0;

                    LocalizationModel.LocalizedStrings["langRusStr"] = LocalizationModel.LocalizedStrings["langRusStr"].Replace('∙', '►').Replace('·', '◄');
                    LocalizationModel.LocalizedStrings["langEngStr"] = LocalizationModel.LocalizedStrings["langEngStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["isSoundsEnabledStr"] = LocalizationModel.LocalizedStrings["isSoundsEnabledStr"].Replace('►', '∙').Replace('◄', '·');

                    WindowView.DrawSelectedSettingsMenuOption();
                }
                else if (_selectorSettingsMenu < 0)
                {
                    _selectorSettingsMenu = 2;

                    LocalizationModel.LocalizedStrings["langRusStr"] = LocalizationModel.LocalizedStrings["langRusStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["langEngStr"] = LocalizationModel.LocalizedStrings["langEngStr"].Replace('►', '∙').Replace('◄', '·');
                    LocalizationModel.LocalizedStrings["isSoundsEnabledStr"] = LocalizationModel.LocalizedStrings["isSoundsEnabledStr"].Replace('∙', '►').Replace('·', '◄');

                    WindowView.DrawSelectedSettingsMenuOption();
                }

                ConsoleKey consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.W:
                        {
                            _selectorSettingsMenu -= 1;
                            GameMusic.PlayButtonSelected(GameMusic.IsSoundsEnabled);
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            _selectorSettingsMenu += 1;
                            GameMusic.PlayButtonSelected(GameMusic.IsSoundsEnabled);
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            if (_selectorSettingsMenu == 0)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LocalizationModel.CultureInfo = CultureInfo.CreateSpecificCulture("ru");
                                LocalizationModel.InitializeLocalization();
                                WindowView.DrawSettingsMenu();
                            }
                            else if (_selectorSettingsMenu == 1)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LocalizationModel.CultureInfo = CultureInfo.CreateSpecificCulture("en");
                                LocalizationModel.InitializeLocalization();
                                WindowView.DrawSettingsMenu();
                            }
                            else if (_selectorSettingsMenu == 2)
                            {
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                if (GameMusic.IsSoundsEnabled)
                                    GameMusic.IsSoundsEnabled = false;
                                else
                                    GameMusic.IsSoundsEnabled = true;
                                GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                                LocalizationModel.InitializeLocalization();
                                WindowView.DrawSettingsMenu();
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                            if (outcomeView == "mainMenuView")
                                WindowView.DrawMainMenu();
                            else if (outcomeView == "pauseMenuView")
                                WindowView.DrawPauseMenu();
                        }
                        break;
                }
            }
        }

        public static void LegendViewSelector()
        {
            while (true)
            {
                ConsoleKey consoleKey = Console.ReadKey(true).Key;
                switch (consoleKey)
                {
                    case ConsoleKey.Escape:
                        {
                            GameMusic.PlayButtonPressed(GameMusic.IsSoundsEnabled);
                            WindowView.DrawPauseMenu();
                        }
                        break;
                }
            }
        }
    }
}
