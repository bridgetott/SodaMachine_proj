using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {

        //member variables

        public Card card;
        public List<Coin> coins;
        

    
        //Constructor
        public Wallet()
        {
            card = new Card();
            coins = new List<Coin>();
            //AddCoinstoWallet();
                
        }
        
        


        //member methods
        public void AddCoinstoWallet()
        {
            //create a for loop to add the coins
            for(int i = 0; i < 10; i++)
            {
                Penny penny = new Penny();
                coins.Add(penny);
            }

            for (int i = 0; i < 12; i++)
            {
                Quarter quarter = new Quarter();
                coins.Add(quarter);
            }

            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                coins.Add(dime);
            }

            for (int i = 0; i < 20; i++)
            {
                Nickle nickle = new Nickle();
                coins.Add(nickle);
            }


        }
        //remove coins when customer purchases a can of soda

    }
}

//Quarter quarter = new Quarter();
//coins.Add(quarter);
//Dime dime = new Dime();
//coins.Add(dime);