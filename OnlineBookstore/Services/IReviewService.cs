using OnlineBookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public interface IReviewService
    {
        Task<IEnumerable<Review>> GetAllReviews();
        Task<Review> GetReviewById(int reviewId);
        Task AddReview(Review review);
        Task UpdateReview(Review review);
        Task DeleteReview(int reviewId);
    }
}
