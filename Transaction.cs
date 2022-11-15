using System;

namespace Passtask3{
    // In Transaction class, the Constructor for main class Program is defined as well as the attributes and methods
    public class Transaction{
        private int _transNo;
        private string _date;
        private int _amounts;
        private int _points;
        private TransactionMode _mode;

        // Defining the enumerations 'online' and 'offline'
        public enum TransactionMode
        {
            online,
            offline
        }
        
        // The following is a Constructor called Transaction. 
        // A way to identify a constructor is by noticing that the constructor has the same name as the file name
        // All the information inside this constructor is in the following template Transaction number, date, amount, and mode
        public Transaction(int transNo, string date, int amounts, TransactionMode mode){
            _transNo = transNo;
            _date = date;
            _amounts = amounts;
            _mode = mode;
        }
        
        // The following property has been introduced to access private information inside the Transaction. 
        // The following property has the get and set method using which we can send a value to this property and set it as the value
        // In this property we can access and change the Mode of the transaction
        public TransactionMode Mode{
            get{return _mode;}
            set{_mode = value;}
        }

        // In the following property, private information inside the Transaction can accessed
        // We can access and change or set the value of the Transaction Number 
        public int TransNo{
            get{return _transNo;}
            set{_transNo = value;}
        }
        
        // In the following property, private information inside the Transaction can accessed
        // We can access and change or set the value of the Transaction Date
        public string Date{
            get{return _date;}
            set{_date = value;}
        }

        // In the following property, private information inside the Transaction can accessed
        // We can access and change or set the value of the Transaction Amount
        public int Amounts{
            get{return _amounts;}
            set{_amounts = value;}
        }
        
        // In the following method, an operation will be performed on the information passed to this method
        // This method will receive the information from the Main Class Program 
        // Then this method will divide the amount value received and save it in the variable _points
        public void UpdatePoints(){
            _points = _amounts/10;
        }

        // In the following property, private information inside the Transaction can accessed
        // We can access and change or set the value of the Transaction Points
        public int Points{
            get{return _points;}
            set{_points = value;}
        }

        // In the following method, an if-else statement is introduced
        // The method will receive the information and the method will be executed accordingly
        // If an online mode is passed through the method, then the respective string will be returned to the main class Program
        // Else the other string will be returned.
        public string PrintInfo(){
            if(_mode == TransactionMode.online){
                return "That’s a wise choice with more rewards";
            }
            else{
                return "You have secured some points";
            }
        }

    }

}