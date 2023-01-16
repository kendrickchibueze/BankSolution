namespace BankNuggets;

  
    class BankAccount
    {
        private string _accountNumber;
        private double _balance;

      
        public BankAccount(string accountNumber, double balance)
        {
            _accountNumber = accountNumber;
            _balance = balance;
        }

        [MethodInfoAttribute("This method deposits a specified amount of money into the account", Input = "double amount", Output = "none")]
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        [MethodInfoAttribute("This method withdraws a specified amount of money from the account", Input = "double amount", Output = "bool indicating success or failure of the withdrawal")]
        public bool Withdraw(double amount)
        {
            if (_balance < amount)
            {
                return false;
            }
            _balance -= amount;
            return true;
        }

        [MethodInfoAttribute("This method gets the current balance of the account", Input = "none", Output = "double representing the current balance")]
        public double GetBalance()
        {
            return _balance;
        }

    }