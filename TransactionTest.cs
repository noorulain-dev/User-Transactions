using System;
using SplashKitSDK;
using NUnit.Framework;

namespace Passtask3{

    [TestFixture()]

    public class TransactionTest{

        [Test()]
        public void TestOnline()
        {
            Transaction online = new Transaction(1001, "1/1/2021", 150, Transaction.TransactionMode.online);
            string returnedValueForOnline = online.PrintInfo();
            StringAssert.AreEqualIgnoringCase("That’s a wise choice with more rewards",returnedValueForOnline);
        }


        [Test()]
        public void TestOffine()
        {
            Transaction offline = new Transaction(1002, "2/2/2021", 280, Transaction.TransactionMode.offline);
            string returnedValueForOffline = offline.PrintInfo();
            StringAssert.AreEqualIgnoringCase("You have secured some points",returnedValueForOffline);
        }

        [Test()]
        public void TestPoints()
        {
            Transaction[] myTransactions = new Transaction[2];
            myTransactions[0] = new Transaction(1001, "1/1/2021", 150, Transaction.TransactionMode.online);
            myTransactions[1] = new Transaction(1002, "2/2/2021", 280, Transaction.TransactionMode.offline);
            
            myTransactions[0].Points = 150/10;
            myTransactions[1].Points = 280/10;
            Assert.AreEqual(15,myTransactions[0].Points);
            Assert.AreEqual(28,myTransactions[1].Points);
        }
    }
}