using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Game
{
    public class Snake_Ladder
    {
        int num;
        int START_POSITION = 0;
        int END_POSITION = 100;
        int playerPosition = 0;
        int previousPlayerPosition = 0;
        int updatedPlayerPosition = 0;
        int countDiceRoll = 0;
        public int SnakeLadder()
        {
           // Random random = new Random();
           
            while (playerPosition >= START_POSITION && playerPosition <= END_POSITION)
            {
                Random random = new Random();
                 num = random.Next(6);
                Console.WriteLine(num);
            }

            return num;
        }


    }
        }
    
