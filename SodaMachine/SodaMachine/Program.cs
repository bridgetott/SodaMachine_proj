using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaMachine testMachine = new SodaMachine();
            Customer testCustomer = new Customer();
            double testDouble = .20;
            Can testCan = new OrangeSoda();
            List<Coin> testList = new List<Coin>();
            Wallet testWallet = new Wallet();

            //bool enoughMoneyForPurchase = testMachine.EnoughMoneyForPurchase(testDouble, testCan);
            //testMachine.ReturnMoneyToCustomer(testList, testCustomer);

            //testWallet.AddCoinstoWallet();
            //testMachine.AddCoinstoMachine();

        }
    }
}
