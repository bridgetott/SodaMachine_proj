using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {

        //member variables

        public List<Coin> register;
        public List<Can> inventory;



        //Constructor

        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();


        }



        //member methods
        //public void AddChangetoMachine();
        //for

        public bool EnoughMoney(double money, Can can)
        {
            if(money < can.Cost)
            {
                return false;
            }
            return true;
        }

        public void GiveMoneyBackToCustomer(List<Coin> coinsPutInMachine ,Customer customer)
        {
            customer.wallet.coins.AddRange(coinsPutInMachine);
        }

        public bool CustomerHasExactChange(double money, Can can)
        {
            if(money == can.Cost)
            {
                return false;
            }
            return true;
        }

        public void AcceptChangefromCustomer(List<Coin> coinsPutInMachine, Customer customer)
        {
            customer.wallet.coins.RemoveRange(0 , coinsPutInMachine.Count);
            register.AddRange(coinsPutInMachine);


        }



    }
}

