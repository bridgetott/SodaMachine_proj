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
            //AddCoinstoMachine();

        }



        //member methods
        //public void AddChangetoMachine();
        public void AddCoinstoMachine()
        {
            //create a for loop to add the coins
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                register.Add(penny);
            }

            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                register.Add(quarter);
            }

            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                register.Add(dime);
            }

            for (int i = 0; i < 20; i++)
            {
                Nickle nickle = new Nickle();
                register.Add(nickle);
            }

        }

        public void AddCansToMachine()
        {
            //create a for loop to add the coins
            for (int i = 0; i < 10; i++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                inventory.Add(orangeSoda);
                Cola cola = new Cola();
                inventory.Add(cola);
            }

            for (int i = 0; i < 7; i++)
            {
                Rootbeer rootbeer = new Rootbeer();
                inventory.Add(rootbeer);
            }

        
        }




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
        //reuse this method when customer gives too much money

        public void AddCanstoBackPack(Can canDispensedFromMachine, Backpack backpack)
        {
            inventory.Remove(canDispensedFromMachine);
            backpack.cans.Add(canDispensedFromMachine);
        }



    }
}

