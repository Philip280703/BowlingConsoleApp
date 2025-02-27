using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingConsoleApp
{
	public class Game
	{
		private int[] rolls = new int[21]; // array på 21 kast. plus en for homer cenario
		private int currentRoll = 0;

		public void Roll(int pins)
		{
			rolls[currentRoll++] = pins;
		}

	
		public int Score()
		{
			int score = 0;
			int rollIndex = 0;

			for (int frame = 0; frame < 10; frame++) 
			{
				// strike
				if (IsStrike(rollIndex))
				{
					score += 10 + rolls[rollIndex + 1] + rolls[rollIndex + 2];
					rollIndex ++;
				}
				// spare
				else if (IsSpare(rollIndex))
				{
					score += 10 + rolls[rollIndex + 2];
					rollIndex += 2;
				}
				else
				{
					score += rolls[rollIndex] + rolls[rollIndex + 1];
					rollIndex += 2;
				}
			}
			return score;
		}

		private bool IsStrike(int rollIndex)
		{
			return rolls[rollIndex] == 10; // hvis et kast er 10, true
		}

		private bool IsSpare(int rollIndex) 
		{ 
			return rolls[rollIndex] + rolls[rollIndex + 1] == 10; // hvis et frame er lig 10, true
		}
	}
}
