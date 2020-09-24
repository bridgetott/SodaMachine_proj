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

                
        }
        
        


        //member methods
        public void AddCoins()
        {
            Quarter quarter = new Quarter();
            coins.Add(quarter);
            Dime dime = new Dime();
            coins.Add(dime);

        }

    }
}

