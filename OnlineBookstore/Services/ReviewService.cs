using OnlineBookstore.Models;
using OnlineBookstore.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<IEnumerable<Review>> GetAllReviews()
        {
            return await _reviewRepository.GetAllReviews();
        }

        public async Task<Review> GetReviewById(int reviewId)
        {
            return await _reviewRepository.GetReviewById(reviewId);
        }

        public async Task AddReview(Review review)
        {
            await _reviewRepository.AddReview(review);
        }

        public async Task UpdateReview(Review review)
        {
            await _reviewRepository.UpdateReview(review);
        }

        public async Task DeleteReview(int reviewId)
        {
            await _reviewRepository.DeleteReview(reviewId);
        }
    }
}
