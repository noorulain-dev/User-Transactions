using System;
using System.Collections.Generic;

namespace Passtask3{

    /// <summary>
    /// Defining a Constructor, methods, and attributes in this class
    /// </summary>
    public class UserProfile{

        private int id_;
        private string name_;
        private int contactNumber;
        private int yearJoined;
        private string status_;
        private List<Transaction> transaction_;

    /// <summary>
    /// Constructor 
    /// This is the template for our object
    /// All new UserProfiles will followe this template
    /// </summary>
        public UserProfile(int id, string name, int contact_number, int year_joined){
            id_ = id;
            name_ = name;
            contactNumber = contact_number;
            yearJoined = year_joined;
            transaction_ = new List<Transaction>();
        }

    /// <summary>
    /// This code is used to avoid code duplication in the program
    /// </summary>
        public UserProfile():this(1001, "John", 0102158456, 2004){

        }

    /// <summary>
    /// Property
    /// We can access and change information in the object using this property
    /// </summary>
        public int id{
            get{ return id_; }
            set{ id_ = value; }
        }

    /// <summary>
    /// Property
    /// We can access and change information in the object using this property
    /// </summary>
        public string name{
            get{ return name_; }
            set{ name_ = value; }
        }

    /// <summary>
    /// Property
    /// We can access and change information in the object using this property
    /// </summary>
        public int contact_number{
            get{ return contactNumber; }
            set{ contactNumber = value; }
        }

    /// <summary>
    /// Property
    /// We can access and change information in the object using this property
    /// </summary>
        public int year_joined{
            get{ return yearJoined; }
            set{ yearJoined = value; }
        }

    /// <summary>
    /// Read-only Property
    /// We can access information in the object using this property
    /// </summary>
        public string status{
            get{ return status_; }
        }

    /// <summary>
    /// Read-only Property
    /// We can access information in the object using this propoerty
    /// </summary>
        public List<Transaction> Transaction{
            get{ return transaction_; }
        }

    /// <summary>
    /// An Indexer
    /// Objects can be accessed by using this indexer in the form of an array
    /// This indexer is called using the name of the object an the number 
    /// of the array of the accessed enclosed in a bracket
    /// </summary>
        public Transaction this[int i]{
            get{ return transaction_[i]; }
        }
        
    /// <summary>
    /// Read-only Property
    /// When this property is called, it returns the total number of Transactions in the UserProfile
    /// </summary>
        public int TransactionTotal{
            get { return transaction_.Count; }
        }
    
    /// <summary>
    /// Method
    /// This method will Add a transaction to the Transaction list
    /// </summary>
        public void AddTransaction(Transaction t){
            transaction_.Add(t);
        }
    
    /// <summary>
    /// Method
    /// This method Removes a transaction from the transaction list
    /// </summary>
        public void RemoveTransaction(Transaction t){
            transaction_.Remove(t);
        }

    /// <summary>
    /// Method
    /// This method is used to calculate the total years joined by the user
    /// When called, this method returns the total years 
    /// </summary>
        public int update_year_joined(){
            int totalyears = 2021 - year_joined;
            return totalyears;
        }

    /// <summary>
    /// Method
    /// In When called, this method will return the correct string on information
    /// corresponding to the total amount spent by the user
    /// This method uses an if-else statement
    /// </summary>
        public void update_status(){
            int total_amount = 0;
            foreach(Transaction t in transaction_){
                total_amount = total_amount +t.Amounts;
            }

            if(update_year_joined()>3 && total_amount>10000){
                status_ = "Gold";
            }

            if(update_year_joined()>5 && total_amount >30000){
                status_ = "Platinum";
            }
            else {
                status_ = "Normal";
            }
        }
    }
}