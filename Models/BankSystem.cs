namespace Models.BankSystem
{
    class Account
    {
        private decimal balance;
        private decimal deposit;

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance manfiy son qabul qilmaydi");
                }
                else
                {
                    this.balance = value;   
                }
            }
        }

        public decimal Deposit
        {
            get
            {
                return deposit;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Deposit minus qabul qilmaydi");
                }
                else
                {
                    this.deposit = value;
                }
            }
        }

        public void ShowDeposit()
        {
            Console.WriteLine($"Deposit: {Deposit}$");
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {Balance}$");
        }
    }

    class SavingsAccount : Account
    {
        public void AddInterest()
        {
            Console.WriteLine("Added new Interest!!!");
        }
    }

    class CreditCard : Account
    {
        public void TakeCredit(decimal credit)
        {
            Console.WriteLine($"Credit olindi, summa:  {credit}$");
        }
    }
}