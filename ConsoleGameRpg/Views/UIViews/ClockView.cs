using ConsoleGameRpg.Engine.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameRpg.Views.UIViews
{
    //Unnecessary
    internal class ClockView
    { 
        private const int _position = 7890;

        public void DisplayClockAndPlayerPos(char[] screen)
        {
            DateTime dateTime = DateTime.Now;
            char[] dateTimeCharArr = dateTime.ToString().ToCharArray();
            dateTimeCharArr.CopyTo(screen, _position);

            //Delete
            char[] playerCurrPos = LevelBuilder.PlayerPosition.ToString().ToCharArray();
            playerCurrPos.CopyTo(screen, 173);
        }
    }
}
