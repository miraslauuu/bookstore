using OnlineBookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstore.Data.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly OnlineBookstoreContext _context;

        public ReviewRepository(OnlineBookstoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Review>> GetAllReviews()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<Review> GetReviewById(int reviewId)
        {
            return await _context.Reviews.FindAsync(reviewId);
        }

        public async Task AddReview(Review review)
        {
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateReview(Review review)
        {
            _context.Reviews.Update(review);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReview(int reviewId)
        {
            var review = await _context.Reviews.FindAsync(reviewId);
            if (review != null)
            {
                _context.Reviews.Remove(review);
                await _context.SaveChangesAsync();
            }
        }
    }
}
