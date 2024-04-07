using ConsoleGameRpg.Engine.Graphics;
using ConsoleGameRpg.Engine.Sounds;
using ConsoleGameRpg.Models.UIModels;
using ConsoleGameRpg.Views;
using System.Globalization;
using System.Resources;

namespace ConsoleGameRpg
{
    public class Program
    {     
        public static void Main()
        {
            WindowView.InitializeConsole(LevelBuilder.ScreenWidth, LevelBuilder.ScreenHeight, false);
            
            LocalizationModel.InitializeLocalization();
            ///////hkkukuykuy////////
            WindowView.DrawIntro();                   
        }                                 
    }
}