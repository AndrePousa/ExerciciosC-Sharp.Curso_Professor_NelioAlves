namespace Course.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) //prefixo override, o médodo de saque está sendo sobrescrito. 
        {
            base.Withdraw(amount); // chamei a regra da superclasse.
            Balance -= 2.0; //acrecentei ação. 
        }
    }
}
