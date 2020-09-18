using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoRoyale
{
    class Program1
    {

        static void Main(string[] args)


        {
            Console.WriteLine("Welcome to Casino Royale!");

            Console.WriteLine("Please take a look at your hand, and press continue!");

            Console.ReadLine();

            int playerHand = 0;
            int dealerHand = 0;



            Random random = new Random();

            playerHand += random.Next(1, 12);
            playerHand += random.Next(1, 12);
            dealerHand += random.Next(1, 12);
            dealerHand += random.Next(1, 12);

            if (playerHand > 21)
            {
                playerHand -= 10;
            }
            if (dealerHand == 21)
            {
                dealerHand += 0;
            }


            while (true)
            {
                if (playerHand == 21)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerHand < 21)
                {
                    Console.WriteLine("Would you like to hit? 'y' or 'n'");

                }
                Console.WriteLine("Current Score:" + playerHand);

                string reply = Console.ReadLine();

                if (reply == "n")

                {
                    dealerHand += random.Next(1, 12);

                    if (dealerHand > 21)
                    {
                        Console.WriteLine("The dealer busted! You've won!");
                        Console.ReadLine();
                        break;
                    }
                    else if (dealerHand < playerHand)
                    {
                        Console.WriteLine("You had the better hand! Congratulations!");
                        Console.ReadLine();
                    }



                    else if (playerHand < dealerHand)
                    {
                        Console.WriteLine("The dealer had the better hand! You've Lost! ");
                        Console.ReadLine();
                        break;
                    }
                    else if (playerHand == dealerHand)
                    {
                        Console.WriteLine("It appears theres been a tie!");
                        Console.WriteLine("Current Score:" + playerHand);
                        Console.WriteLine("Dealer's Score:" + dealerHand);
                        Console.ReadLine();
                        break;
                    }
                }

                if (reply == "y")
                {
                    playerHand += random.Next(1, 12);
                    dealerHand += random.Next(1, 12);

                    if (playerHand > 21)
                    {
                        Console.WriteLine("You Busted!");
                        Console.ReadLine();
                        break;

                    }
                    else if (playerHand < 21)
                    {
                        Console.WriteLine("Would you like a hit? 'y' or 'n' ");
                        Console.WriteLine("Current Score:" + playerHand);
                        string repliedYes = Console.ReadLine();

                        if (repliedYes == "y")
                        {
                            playerHand += random.Next(1, 12);
                            dealerHand += random.Next(1, 12);

                            if (dealerHand > 21)
                            {
                                Console.WriteLine("The dealer Has busted");
                                break;
                            }
                            else if (playerHand > 21)
                            {
                                Console.WriteLine("Oh no! You busted!");
                                break;
                            }
                            else if (playerHand < dealerHand)
                            {
                                Console.WriteLine("You've Won!");
                                break;

                            }
                            else if (dealerHand > playerHand)
                            {
                                Console.WriteLine("You've Lost. Better Luck Next Time!");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if (repliedYes == "n")


                        {
                            dealerHand += random.Next(1, 12);

                            if (dealerHand > 21)
                            {
                                Console.WriteLine("The dealer busted! You've won!");
                                Console.ReadLine();
                                break;
                            }
                            else if (dealerHand < playerHand)
                            {
                                Console.WriteLine("You had the better hand! Congratulations!");
                                Console.ReadLine();
                            }



                            else if (playerHand < dealerHand)
                            {
                                Console.WriteLine("The dealer had the better hand! You've Lost! ");
                                Console.ReadLine();
                                break;
                            }
                            else if (playerHand == dealerHand)
                            {
                                Console.WriteLine("It appears theres been a tie!");
                                Console.WriteLine("Current Score:" + playerHand);
                                Console.WriteLine("Dealer's Score:" + dealerHand);
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                }
            }

        }
    }
}

    

   
        



  





