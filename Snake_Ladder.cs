using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake_And_Ladder_Game
{
    public class Snake_Ladder
    {
        public static void snakeLadder()
        {
            int num;
            int START_POSITION = 0;
            int END_POSITION = 100;
            int playerPosition = 0;
            int previousPlayerPosition = 0;
            int updatedPlayerPosition = 0;
            int countDiceRoll = 0;

            void rollDice()
            {
                countDiceRoll = (countDiceRoll + 1);
                Random random = new Random();
                num = random.Next(6);
                option();
            }
            void option()
            {
                int NO_PLAY_OPTION = 0;
                int LADDER_OPTION = 1;
                int SNAKE_OPTION = 2;
                Random R = new Random();
                int select_option = R.Next(3);

                if (select_option == NO_PLAY_OPTION)
                {
                    noPlay();
                }
                else if (select_option == LADDER_OPTION)
                {
                    ladder();
                }
                else
                {
                    snake();
                }
            }

            void noPlay()
            {
                playerPosition = previousPlayerPosition;
            }

            void ladder()
            {
                updatedPlayerPosition = (previousPlayerPosition + num);
                if (updatedPlayerPosition > END_POSITION)
                {
                    playerPosition = previousPlayerPosition;
                }
                else if (updatedPlayerPosition == END_POSITION)
                {
                    playerPosition = END_POSITION;
                }
                else
                {
                    playerPosition = updatedPlayerPosition;
                }

                previousPlayerPosition = playerPosition;
            }

            void snake()
            {
                updatedPlayerPosition = (previousPlayerPosition - num);
                if (updatedPlayerPosition < START_POSITION)
                {
                    playerPosition = START_POSITION;
                }
                else
                {
                    playerPosition = updatedPlayerPosition;
                }

                previousPlayerPosition = playerPosition;
            }

            while (playerPosition >= START_POSITION && playerPosition < END_POSITION)
            {
                rollDice();
                Console.WriteLine("Position After Every Roll Dice :-  " + playerPosition);
            }
            Console.WriteLine("Total Number Of Dice Roll :- " + countDiceRoll);
        }   
    }
}
    
