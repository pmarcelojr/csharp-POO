namespace _07Heranca.Entities
{
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount() { }
        public SavingAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
            {
                InterestRate = interestRate;
            }
        
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}