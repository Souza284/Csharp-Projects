namespace Project03.Models
{
    internal class CurrentAccount
    {
        public int Number { get; set; }
        public int Agency { get; set; }
        public double Balance { get; set; }
        public Client? Holder { get; set; }

        public CurrentAccount(int agency, int number)
        {
            Agency = agency;
            Number = number;
        }
    }
}