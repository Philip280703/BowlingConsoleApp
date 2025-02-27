using BowlingConsoleApp;

namespace XUnitBowling
{
	public class UnitTest1
	{
		[Fact]
		public void Test_Gutter()
		{
			Game g = new Game();
			for (int i = 0; i < 20; i++) 
			{
				g.Roll(0);
			}

			Assert.Equal(0, g.Score());
		}

		[Fact]
		public void Test_AllOnes()
		{
			Game g = new Game();
			for (int i = 0; i < 20; i++)
			{
				g.Roll(1);
			}

			Assert.Equal(20, g.Score());
		}

		[Fact]
		public void Test_SpareFirst_then3_then0()
		{
			Game g = new Game();

			//spare
			g.Roll(7);
			g.Roll(3);

			//3 pins
			g.Roll(3);
			g.Roll(0);

			for (int i = 0; i < 16; i++)
			{
				g.Roll(0);
			}

			Assert.Equal(16, g.Score());
		}

		[Fact]
		public void Test_Strike_then4_then0()
		{
			Game g = new Game();

			//strike
			g.Roll(10);

			//3 pins
			g.Roll(3);
			//4 pins
			g.Roll(4);

			for(int i = 0;i < 16; i++)
			{
				g.Roll(0);
			}

			Assert.Equal(24, g.Score());
		}


		[Fact]
		public void Test_Homer()
		{
			Game g = new Game();

			for(int i = 0;i < 12 ; i++)
			{
				g.Roll(10);
			}

			Assert.Equal(300, g.Score());
		}
	}
}