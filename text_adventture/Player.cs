using System;

namespace PlayerCS
{
	public class Player
	{
		private CommandLibrary commands;  // holds all valid command words
        private Room currentRoom;

        public Player()
		{
            createRooms();
		}

		/**
	     * Ask and interpret the user input. Return a Command object.
	     */

        public Room CurrentRoom
        {

            get{ return currentRoom; }
            set{ currentRoom = value; }
        }

		public Command getCommand()
		{
			Console.Write("> ");     // print prompt

			string word1 = null;
			string word2 = null;

			string[] words = Console.ReadLine().Split(' ');
			if (words.Length > 0) { word1 = words[0]; }
			if (words.Length > 1) { word2 = words[1]; }

			// Now check whether this word is known. If so, create a command with it.
			if (commands.isCommand(word1)) {
				return new Command(word1, word2);
			}

			// If not, create a "null" command (for unknown command).
			return new Command(null, null);
		}

		/**
	     * Print out a list of valid command words.
	     */
		public void showCommands()
		{
			commands.showAll();
		}

       /* private void createRooms()
        {
            Room outside, theatre, pub, lab, office, attic;

            // create the rooms
            outside = new Room("outside the main entrance of the university");
            theatre = new Room("in a lecture theatre");
            pub = new Room("in the campus pub");
            lab = new Room("in a computing lab");
            office = new Room("in the computing admin office");
            attic = new Room("in the dusty room upstairs");

            // initialise room exits
            outside.setExit("east", theatre);
            outside.setExit("south", lab);
            outside.setExit("west", pub);

            theatre.setExit("up", attic);
            attic.setExit("down", theatre);

            theatre.setExit("west", outside);

            pub.setExit("east", outside);

            lab.setExit("north", outside);
            lab.setExit("east", office);

            office.setExit("west", lab);

            currentRoom = outside;  // start game outside
        }*/

    }

}
