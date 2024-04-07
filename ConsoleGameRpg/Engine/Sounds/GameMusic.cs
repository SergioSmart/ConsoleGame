namespace ConsoleGameRpg.Engine.Sounds
{
    public class GameMusic
    {
        private static int _tempo = (int)Tempo.Allegro;

        public static bool IsSoundsEnabled { get; set; } = true;

        public static void PlayTrack1()
        {
            int frequency = 100;
            int duration = 300;
            byte length = 0;
            byte step = 0;
            byte cycle = 0;

            while (true)
            {
                if (cycle >= 0 && cycle < 4)
                {
                    while (length < 4)
                    {
                        Console.Beep(frequency + step, duration);
                        step += 17;
                        length++;
                    }
                    while (length > 0)
                    {
                        Console.Beep(frequency + step, duration);
                        step -= 17;
                        length--;
                    }
                    cycle++;
                }

                if (cycle >= 4 && cycle < 6)
                {
                    while (length < 4)
                    {
                        Console.Beep(frequency + 90 + step, duration);
                        step += 17;
                        length++;
                    }
                    while (length > 0)
                    {
                        Console.Beep(frequency + 90 + step, duration);
                        step -= 17;
                        length--;
                    }
                    cycle++;
                }

                if (cycle >= 6)
                {
                    cycle = 0;
                }
            }
        }

        public static void PlayIntro()
        {
            
        }

        public static void PlayTrack2(bool isEnabled)
        {
            if (isEnabled)
            {
                while (true)
                {
                    Console.Beep((int)Note.A3, (int)Duration.Quarter * 7);
                    Console.Beep((int)Note.A3, (int)Duration.Eighth * 7);
                    Console.Beep((int)Note.E3, (int)Duration.Quarter * 7);
                    Console.Beep((int)Note.G3, (int)Duration.Eighth * 7);
                    Console.Beep((int)Note.D3, (int)Duration.Quarter * 7);
                    Console.Beep((int)Note.E3, (int)Duration.Eighth * 7);
                    Console.Beep((int)Note.A2, (int)Duration.Half * 7);
                    Console.Beep((int)Note.A2, (int)Duration.Quarter * 7);
                }
            }
        }

        public static void PlayButtonSelected(bool isEnabled)
        {
            if (isEnabled)
            {
                Console.Beep((int)Note.Cs5, (int)Duration.Sixteenth);
                Console.Beep((int)Note.E5, (int)Duration.Sixteenth);
            }         
        }

        public static void PlayButtonPressed(bool isEnabled)
        {
            if(isEnabled) 
                Console.Beep((int)Note.Cs4, (int)Duration.Sixteenth);
        }

        public static void PlayHeartPickedUp()
        {
            for (int i = 0; i < 12; i++)
            {
                
            }
        }
    }
}
