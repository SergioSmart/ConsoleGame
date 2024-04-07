using ConsoleGameRpg.Engine.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameRpg.Views
{
    internal static class LevelView
    {
        public static void DrawLevel(LevelBuilder level)
        {
            level.InitializeScreen();

            while (true)
            {              
                level.ControlBehavior();               
                level.ConstructScreen();               
                level.DrawPlayer();
                level.DrawScreen();
            }
        }
    }
}
