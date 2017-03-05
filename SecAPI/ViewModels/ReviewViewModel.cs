using SecAPI.Models;

namespace SecAPI.ViewModels
{
    public class ReviewViewModel
    {

        public ReviewViewModel()
        { }

        public ReviewViewModel(Review newReview)
        {
            if (newReview == null)
            {
                return;
            }

            BookId = newReview.BookId;
            Rating = newReview.Rating;
            Description = newReview.Description;
        }

        public int BookId { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        public Review ToReview()
        {
            return new Review
            {
                BookId = BookId,
                Description = Description,
                Rating = Rating
            };
        }
    }
}