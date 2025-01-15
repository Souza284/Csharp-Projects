namespace Project03.Models
{
    internal class CurrentAccount
    {
        public int Number { get; set; }
        public int Agency { get; set; }
        public double Balance { get; private set; }
        public Client? Holder { get; set; }

        public CurrentAccount(int agency, int number)
        {
            Agency = agency;
            Number = number;
        }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Deposit value must to be greater than 0.", nameof(value));
            }

            Balance += value;
        }

        public void WithDraw(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Deposit value must to be greater than 0.", nameof(value));
            }
            if (value > Balance)
            {
                throw new ArgumentException("Insufficient balance.");
            }
            Balance += value;
        }
    }
}