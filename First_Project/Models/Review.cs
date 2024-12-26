namespace First_Project.Models
{
    internal class Review
    {
        public double Rate { get; }
        public Review(double rate)
        {
            if (rate > 10)
            {
                rate = 10;
            }
            else
            {
                if (rate < 0)
                {
                    rate = 0;
                }
            }
            Rate = rate;
        }

        public static Review Convert(string text)
        {
            var review = Double.Parse(text);
            return new Review(review);
        }

    }
}