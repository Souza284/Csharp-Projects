namespace First_Project.Models
{
    internal interface IReview
    {
        double Average { get;}
        void Rate(Review review);
    }
}