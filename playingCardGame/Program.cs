using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playingCardGame
{
    class Program
    {
        static void Main()
        {
            /* I wanted to make sure that my code represents proffesional level of writing code, so I have kept my main metod clean.
             * I also have demonstrated the use of OOP concept to make my code reusable that resembles enterprise level software development proces.
             * I want to thank you so much for giving me this opportunity to demonstrate my skills, Gaming is my passion and I have a dream of making 
             * gaming software that will reach millions of people and will make a positive impact in the society. Thus, my passion, skills and work experience 
             * is a great fit for Kingslsle.
             */


             WelcomeMessage();   //calling the Welcome Message function to display the Welcome message for players.

             PlayAgain();     //playAgain method which gives the user the option to play again if they want to.

        }


        //function that displays the welcome message for the user.
        public static void WelcomeMessage()
        {
            //Trying to give an intro info about the game and how it will be played.
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Welcome to the Card game. You will have a great time playing the game.");
            Console.WriteLine("You will be distributed a card each and the bigger card will be the winner.");

            Console.WriteLine("************************************************************************");


            
            Console.Write("Player 1 name: ");    //Prompting the user to enter their name to personalize the game.
            string userName1 = Console.ReadLine();

            Console.Write("Player 2 name: ");
            String userName2 = Console.ReadLine();

            Console.WriteLine("Let's get this started.");
            Console.WriteLine();
            Console.WriteLine("It's " + userName1 + " vs " + userName2);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            //Creating object of CardGenerate Class to display the player cards.
            CardGenerate playerCards = new CardGenerate();

            //calling all the other methods in the CardGenerate class to initialize deck of cards and generate number.
            playerCards.DeckOfCard();
            playerCards.RandomNumberGenerator();

            string firstPlayerCard = playerCards.player1Card();  //Assigining the card to each players
            string secondPlayerCard = playerCards.player2Card();

           
            //Binds the name and the card of the users.
            Console.WriteLine(userName1 + " Card:"  + firstPlayerCard);

            Console.WriteLine("Let's check card of our next player. Press any key to continue.");
            Console.ReadLine();

            Console.WriteLine(userName2 + " Card:" + secondPlayerCard);

            //Calling method to access the key value in the dictionary, getting the remainder to determine the winner among two players.
            int firstUserCardRemainder = playerCards.player1CardIndex() % 13;
            int secondUserCardRemainder = playerCards.player2CardIndex() % 13;

            //if-else block that determines the winner of the game.
            //if-the reamainder is equal it means the players have the same card so game declared as a tie.
            if (firstUserCardRemainder == secondUserCardRemainder)
            {
                Console.WriteLine("It's a Tie.");

            }

            //if remainder is 1, it means the card is Ace which becomes winner if the other player don't have same card. 
            else if (firstUserCardRemainder == 0 && secondUserCardRemainder != 0)
            {
                Console.WriteLine("The winner is " + userName1);
            }

            //same logic as the previous else if block.
            else if (firstUserCardRemainder != 0 && secondUserCardRemainder == 0)
            {
                Console.WriteLine("The winner is " + userName2);
            }

            //Comparing the remainder to determine the winner.
            else if (firstUserCardRemainder > secondUserCardRemainder)
            {
                Console.WriteLine("The winner is " + userName1);
            }

            else if (firstUserCardRemainder < secondUserCardRemainder)
            {
                Console.WriteLine("The winner is " + userName2);
            }

        }

        //play again function gives the option for the user to play again if they want to do so.
        public static void PlayAgain()
        {
            Console.WriteLine("Do you want to play again ?");
            string userResponse = Console.ReadLine();

            //if-else block which analyzes the user input and repeats the game as per instructions.
            if (userResponse.Equals('y') || userResponse.Equals("yes"))
            {
                Main();
            }

            else
            {
                Console.WriteLine("Thanks for playing.");
            }
            
        }
    }
}


    
