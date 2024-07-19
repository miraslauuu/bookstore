using OnlineBookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBookstore.Data.Repositories
{
    public interface IReviewRepository
    {
        Task<IEnumerable<Review>> GetAllReviews();
        Task<Review> GetReviewById(int reviewId);
        Task AddReview(Review review);
        Task UpdateReview(Review review);
        Task DeleteReview(int reviewId);
    }
}
