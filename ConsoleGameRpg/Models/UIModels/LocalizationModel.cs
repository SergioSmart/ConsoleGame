using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using ConsoleGameRpg.Engine.Sounds;

namespace ConsoleGameRpg.Models.UIModels
{
    internal static class LocalizationModel
    {
        public static CultureInfo CultureInfo { get; set; } = CultureInfo.CurrentCulture;
        public static Dictionary<string, string> LocalizedStrings { get; set; } 
        public static Dictionary<string, string> LocalizedPaths { get; set; } 

        public static ResourceManager ResourceManagerPaths { get; } = new ResourceManager("ConsoleGameRpg.Engine.Resources.Paths.Paths", typeof(Program).Assembly);
        public static ResourceManager ResourceManagerLocal { get; } = new ResourceManager("ConsoleGameRpg.Engine.Resources.Languages.Local", typeof(Program).Assembly);

        public static void InitializeLocalization()
        {
            LocalizedStrings = new Dictionary<string, string>() {
                                                                    {"level1Str", " ∙ " + ResourceManagerLocal.GetString("Level1", CultureInfo) + " · " },
                                                                    {"level2Str", " ∙ " + ResourceManagerLocal.GetString("Level2", CultureInfo) + " · " },
                                                                    {"level3Str", " ∙ " + ResourceManagerLocal.GetString("Level3", CultureInfo) + " · " },
                                                                    {"level4Str", " ∙ " + ResourceManagerLocal.GetString("Level4", CultureInfo) + " · " },
                                                                    {"level5Str", " ∙ " + ResourceManagerLocal.GetString("Level5", CultureInfo) + " · " },
                                                                    {"level6Str", " ∙ " + ResourceManagerLocal.GetString("Level6", CultureInfo) + " · " },
                                                                    {"startGameStr", " ∙ " + ResourceManagerLocal.GetString("MainMenu_StartGame", CultureInfo) + " · " },
                                                                    {"settingsStr", " ∙ " + ResourceManagerLocal.GetString("MainMenu_Settings", CultureInfo) + " · " },
                                                                    {"exitStr", " ∙ " + ResourceManagerLocal.GetString("MainMenu_Exit", CultureInfo) + " · " },
                                                                    {"langRusStr", " ∙ " + ResourceManagerLocal.GetString("SettingsMenu_UILang_Ru", CultureInfo) + " · " },
                                                                    {"langEngStr", " ∙ " + ResourceManagerLocal.GetString("SettingsMenu_UILang_En", CultureInfo) + " · " },
                                                                    {"isSoundsEnabledStr", "" },
                                                                    {"introPressAnyKey", ResourceManagerLocal.GetString("Intro_PressAnyKey", CultureInfo) },
                                                                    {"mainMenuCredits", ResourceManagerLocal.GetString("MainMenu_Credits", CultureInfo) },
                                                                    {"mainMenuTip_1", ResourceManagerLocal.GetString("MainMenu_Tip1", CultureInfo) },
                                                                    {"mainMenuTip_2", ResourceManagerLocal.GetString("MainMenu_Tip2", CultureInfo) },
                                                                    {"mainMenuTip_3", ResourceManagerLocal.GetString("MainMenu_Tip3", CultureInfo) },
                                                                    {"mainMenuExitQuestion", ResourceManagerLocal.GetString("MainMenu_ExitQuestion", CultureInfo) },
                                                                    {"settingsMenu_UILang", " " + ResourceManagerLocal.GetString("SettingsMenu_UILang" , CultureInfo) + " " },
                                                                    {"resumeGame", " ∙ " + ResourceManagerLocal.GetString("ResumeGame", CultureInfo) + " · "  },
                                                                    {"legend", " ∙ " + ResourceManagerLocal.GetString("Legend", CultureInfo) + " · "  },
                                                                    {"pauseMenu_ExitToMainMenu", " ∙ " + ResourceManagerLocal.GetString("PauseMenu_ExitToMainMenu", CultureInfo) + " · " },
                                                                    {"legendMenu_ExitToMainMenu", " ∙ " + ResourceManagerLocal.GetString("PauseMenu_ExitToMainMenu", CultureInfo) + " · " },

                                                                  };

            LocalizedPaths = new Dictionary<string, string>() {
                                                                { "pathSettingsHeader", ResourceManagerPaths.GetString("SettingsMenuHeaderRus") },
                                                                { "pathLevelsHeader", ResourceManagerPaths.GetString("LevelsMenuHeaderRus") },
                                                                { "mainMenuHeader", ResourceManagerPaths.GetString("MainMenuHeader") },
                                                                { "intro", ResourceManagerPaths.GetString("Intro") },
                                                                { "mainMenuTip", ResourceManagerPaths.GetString("MainMenuTip") },
                                                                { "level1", ResourceManagerPaths.GetString("Level1") },
                                                                { "level2", ResourceManagerPaths.GetString("Level2") },
                                                                { "level3", ResourceManagerPaths.GetString("Level3") },
                                                                { "level4", ResourceManagerPaths.GetString("Level4") },
                                                                { "level5", ResourceManagerPaths.GetString("Level5") },
                                                                { "level6", ResourceManagerPaths.GetString("Level6") },
                                                                { "pathPauseMenuHeader", ResourceManagerPaths.GetString("pauseMenuHeaderRus") }
                                                              };

            if (GameMusic.IsSoundsEnabled)
                LocalizedStrings["isSoundsEnabledStr"] = " ∙ " + ResourceManagerLocal.GetString("SettingsMenu_Sounds_On", CultureInfo) + " · ";
            else
                LocalizedStrings["isSoundsEnabledStr"] = " ∙ " + ResourceManagerLocal.GetString("SettingsMenu_Sounds_Off", CultureInfo) + " · ";

            if (CultureInfo.TwoLetterISOLanguageName == "ru")
            {
                LocalizedPaths["pathSettingsHeader"] = ResourceManagerPaths.GetString("SettingsMenuHeaderRus");
                LocalizedPaths["pathLevelsHeader"] = ResourceManagerPaths.GetString("LevelsMenuHeaderRus");
                LocalizedPaths["pathPauseMenuHeader"] = ResourceManagerPaths.GetString("PauseMenuHeaderRus");
            }
            else if (CultureInfo.TwoLetterISOLanguageName == "en")
            {
                LocalizedPaths["pathSettingsHeader"] = ResourceManagerPaths.GetString("SettingsMenuHeaderEng");
                LocalizedPaths["pathLevelsHeader"] = ResourceManagerPaths.GetString("LevelsMenuHeaderEng");
                LocalizedPaths["pathPauseMenuHeader"] = ResourceManagerPaths.GetString("PauseMenuHeaderEng");
            }
            else
            {
                LocalizedPaths["pathSettingsHeader"] = ResourceManagerPaths.GetString("SettingsMenuHeaderEng");
                LocalizedPaths["pathLevelsHeader"] = ResourceManagerPaths.GetString("LevelsMenuHeaderEng");
                LocalizedPaths["pathPauseMenuHeader"] = ResourceManagerPaths.GetString("PauseMenuHeaderEng");
            }
        }
    }
}
