using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playingCardGame
{
    //created a seperate class to implement oop concept allowing to make reusable code.
    class CardGenerate
    {


        //variable that stores the random number generated.
        private int cardUser1;

        //List that stores the random number generated.
        private int cardUser2;

        //Dictionary to store all the cards value can be accessed via key easier to simulate distributing the card.
        Dictionary<int, string> totalCard = new Dictionary<int, string>();

        //method that simulates the deck of card.
        public void DeckOfCard()
        {
            //counter number int on each if statements to provide correct number to the cards.
            int H = 2; int S = 2; int C = 2; int D = 2;

            //for loop to put the value of the card in the dictionary.
            for (int i = 1; i < 14; i++)
            {

                //if, else-if, else statements that simulates the deck of card via the dictionary created above.
                if (i < 10)
                {

                    string cardOfHeart = H + " Of Hearts";
                    H++;
                    totalCard.Add(i, cardOfHeart);

                }

                //else-if block that establish jack of heart if the random number generated is 10.
                else if (i == 10)
                {

                    string cardOfHeart = "Jack Of Hearts";
                    totalCard.Add(i, cardOfHeart);
                    
                }

                //else-if block that establish Queen of heart if the random number generated is 11.
                else if (i == 11)
                {

                    string cardOfHeart = "Queen Of Hearts";
                    totalCard.Add(i, cardOfHeart);
                    
                }

                //else-if block that establish king of heart if the random number generated is 12.
                else if (i == 12)
                {
                    string cardOfHeart = "King of Hearts";
                    totalCard.Add(i, cardOfHeart);
                }

                //else-if block that establish Ace of heart if the random number generated is 13.
                else if (i == 13)
                {

                    string cardOfHeart = "Ace Of Hearts";
                    totalCard.Add(i, cardOfHeart);
                    
                }

            }

            //for loop to put the value of the card in the dictionary.
            for (int i = 14; i < 27; i++)
            {

                //if, else-if, else statements that simulates the deck of card via the dictionary created above.
                if (i < 23)
                {

                    string cardOfDiamond = D + " Of Diamonds";
                    D++;
                    totalCard.Add(i, cardOfDiamond);

                }

                //else-if block that establish jack of diamond if the random number generated is 23.
                else if (i == 23)
                {

                    string cardOfDiamond = "Jack Of Diamonds";
                    totalCard.Add(i, cardOfDiamond);

                }

                //else-if block that establish queen of diamond if the random number generated is 24.
                else if (i == 24)
                {

                    string cardOfDiamond = "Queen Of Diamonds";
                    totalCard.Add(i, cardOfDiamond);

                }

                //else-if block that establish King of diamond if the random number generated is 25.
                else if (i == 25)
                {
                    string cardOfDiamond = "King of Diamonds";
                    totalCard.Add(i, cardOfDiamond);
                }

                //else-if block that establish Ace of diagmond if the random number generated is 26.
                else if (i == 26)
                {

                    string cardOfDiamond = "Ace Of Diamonds";
                    totalCard.Add(i, cardOfDiamond);

                }

            }

            //for loop to put the value of the card in the dictionary.
            for (int i = 27; i < 40; i++)
            {

                //if, else-if, else statements that simulates the deck of card via the dictionary created above.
                if (i < 36)
                {

                    string cardOfClubs = C + " Of Clubs";
                    C++;
                    totalCard.Add(i, cardOfClubs);

                }

                //else-if block that establish jack of Club if the random number generated is 36.
                else if (i == 36)
                {

                    string cardOfClubs = "Jack Of Clubs";
                    totalCard.Add(i, cardOfClubs);

                }

                //else-if block that establish Queen of Club if the random number generated is 37.
                else if (i == 37)
                {

                    string cardOfClubs = "Queen Of Clubs";
                    totalCard.Add(i, cardOfClubs);

                }

                //else-if block that establish King of Club if the random number generated is 38.
                else if (i == 38)
                {

                    string cardOfClubs = "King of Clubs";
                    totalCard.Add(i, cardOfClubs);

                }

                //else-if block that establish Ace of Club if the random number generated is 37.
                else if (i == 39)
                {

                    string cardOfClubs = "Ace Of Clubs";
                    totalCard.Add(i, cardOfClubs);

                }
            }

            //for loop to put the value of the card in the dictionary.
            for (int i = 40; i < 53; i++)
            {

                //if, else-if, else statements that simulates the deck of card via the dictionary created above.
                if (i < 48)
                {

                    string cardOfSpades = S + " Of Spades";
                    S++;
                    totalCard.Add(i, cardOfSpades);

                }

                //else-if block that establish jack of spades if the random number generated is 49.
                else if (i == 49)
                {

                    string cardOfSpades = "Jack Of Clubs";
                    totalCard.Add(i, cardOfSpades);

                }

                //else-if block that establish Queen of spades if the random number generated is 50.
                else if (i == 50)
                {

                    string cardOfSpades = "Queen Of Clubs";
                    totalCard.Add(i, cardOfSpades);

                }

                //else-if block that establish King of spades if the random number generated is 51.
                else if (i == 51)
                {
                    string cardOfSpades = "King of Clubs";
                    totalCard.Add(i, cardOfSpades);
                }

                //else-if block that establish Ace of spades if the random number generated is 52.
                else if (i == 52)
                {

                    string cardOfSpades = "Ace Of Clubs";
                    totalCard.Add(i, cardOfSpades);

                }
            }
        }

        //function that generates random card for two players using rand function.
        public void RandomNumberGenerator()
        {
            //Creating Random Class object to assign a random call to the user.
            Random randomNumbers = new Random();

            //Assigning a random card for the user which will act as key and pull a card from Dictionary.
            int rand1 = randomNumbers.Next(1, 52);
            cardUser1 = rand1;

            //Assigning a random card for the 2nd user.
            int rand2 = randomNumbers.Next(1, 52);

            //if-else statement checks if the random number generated for the user are different.
            if (rand2 != cardUser1)
            {
                cardUser2 = rand2;
            }

            else
            {
                //do-while loop keeps on looping until a different random number is generated than the first one.
                do
                {
                    rand2 = randomNumbers.Next(1, 52);
                }

                while (rand2 == cardUser1);

            }

        }

        //method that returns card generated from random number for player 2.
        public string player1Card()
        {
            string playerOneCard = Convert.ToString(totalCard[cardUser1]);
            return playerOneCard;
        }

        //method that returns card generated from random number for player 2.
        public string player2Card()
        {
            //calling the card value from the dictionary.   
            string playerTwoCard = Convert.ToString(totalCard[cardUser2]);
            return playerTwoCard;
            
        }

        //returns the key on the dictionary generated as random number for player 1.
        public int player1CardIndex()
        {
            return cardUser1;
        }


        //returns the key on the dictionary generated as random number for player 2.
        public int player2CardIndex()
        {
            return cardUser2;
        }
    }

    }

