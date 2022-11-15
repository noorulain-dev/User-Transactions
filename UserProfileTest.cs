using System;
using NUnit.Framework;

namespace Passtask3{

    [TestFixture()]

    public class UserProfileTest{

        [Test()]
        public void AddTesting(){
            UserProfile myUserProfile = new UserProfile();
            int count = myUserProfile.TransactionTotal;

            Assert.AreEqual(0,count);

            myUserProfile.AddTransaction(new Transaction(1001, "1/1/2021", 150, Transaction.TransactionMode.online));
            myUserProfile.AddTransaction(new Transaction(1002, "2/2/2021", 280, Transaction.TransactionMode.offline));

            count = myUserProfile.TransactionTotal;

            Assert.AreEqual(2,count);
        }

        [Test()]
        public void RemoveTesting(){
            UserProfile myUserProfile = new UserProfile();
            int count = myUserProfile.TransactionTotal;

            Assert.AreEqual(0,count);

            Transaction[] TestTransaction = {
                new Transaction(1001, "1/1/2021", 150, Transaction.TransactionMode.online),
                new Transaction(1002, "2/2/2021", 280, Transaction.TransactionMode.offline),
                new Transaction(1003, "3/3/2021", 110, Transaction.TransactionMode.online)
            };

            foreach(Transaction t in TestTransaction){
                myUserProfile.AddTransaction(t);
            }

            count = myUserProfile.TransactionTotal;

            Assert.AreEqual(3,count);

            myUserProfile.RemoveTransaction(TestTransaction[2]);

            count = myUserProfile.TransactionTotal;

            Assert.AreEqual(2,count);
        }

        [Test()]

        public void FetchingTransaction(){
            UserProfile myUserProfile = new UserProfile();

            myUserProfile.AddTransaction(new Transaction(1001, "1/1/2021", 150, Transaction.TransactionMode.online));
            myUserProfile.AddTransaction(new Transaction(1002, "2/2/2021", 280, Transaction.TransactionMode.offline));

            Assert.AreEqual(1001,myUserProfile[0].TransNo);
            StringAssert.AreEqualIgnoringCase("2/2/2021",myUserProfile[1].Date);
            Assert.AreEqual(280, myUserProfile[1].Amounts);
            StringAssert.AreEqualIgnoringCase("You have secured some points",myUserProfile[1].PrintInfo());

        }

        [Test()]

        public void StatusTesting(){
            UserProfile myUserProfile = new UserProfile();
            Transaction[] transaction_ = {
                new Transaction(1001, "1/1/2021", 150, Transaction.TransactionMode.online),
                new Transaction(1002, "2/2/2021", 280, Transaction.TransactionMode.offline)
            };

            foreach(Transaction t in transaction_){
                myUserProfile.AddTransaction(t);
            }

            myUserProfile.update_status();
            Assert.AreEqual(myUserProfile.status, "Normal");
            
        }


    }
}