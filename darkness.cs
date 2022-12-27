using System;
namespace darkSpace{
	class darkClass{
		static void Main(string []args){


			//Basic Player Variables
			string playerName;
			int playerHealth = 100;
			string playerChoice;

			//Enemy Variables
			string enemyName;
			int enemyHealth = 100;

			//Misc Variables
			string choiceList = "attack\ndodge\nbag\nrun";

			//The ASCII That displays at the start of the game
			Console.WriteLine("+---------------------+\n|                     |\n| -+--+--      -+--+- |\n|  |  |         |  |  |");
			Console.WriteLine("|  |  |         |  |  |\n|  +--+         +--+  |\n|                     |");
			Console.WriteLine("|                     |\n|                     |\n|   +-------------+   |\n|   |+++++++++++++|   |");
			Console.WriteLine("|   +-------------+   |\n|                     |\n+---------------------+");

			//The initial part of the game that introduces it and asks for players name
			Console.WriteLine("Welcome to Darkness(It took me bloody ages to do that ascii)\nPress enter to continue");
			Console.ReadLine();
			Console.WriteLine("This is a basic text based game I'm making to familirise myself with C#\nas I am quite new to it.");
			Console.ReadLine();
			Console.WriteLine("In this game you will play as a cave explorer,\nplease enter the name you desire for your character ");
			playerName = Console.ReadLine();
			Console.WriteLine("\n{0}, okay not a name I'd want but you do you", playerName);

			Console.ReadLine();
		
			//Introducing fight mechanics
			Console.WriteLine("Well {0} you're gonna need to fight in a cave like this\n I'll teach you the basics", playerName);
			Console.ReadLine();
			Console.WriteLine("This is your current health: {0} and this is your enemy's: {1}", playerHealth, enemyHealth);
			Console.WriteLine("The fight is won or lost depending on whose health hits 0 or below zero first\n");
			Console.ReadLine();
			Console.WriteLine("Pick one of these options by typing it out\n");
			Console.WriteLine("{0}\n", choiceList);
			playerChoice = Console.ReadLine();

			int i = 1;
			while (i == 1){			
				if (playerChoice == "attack")
				{
					enemyName = "Tutorial Man";
					Console.WriteLine("You attack {0}", enemyName);
					i = 0;
				}
				else
				{
					Console.WriteLine("Please for tutorial purposes select 'attack'");
					break;
				}
			}			
			
		}
	}
}
