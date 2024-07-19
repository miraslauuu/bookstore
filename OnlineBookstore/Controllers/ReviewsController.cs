using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Data.Repositories;
using OnlineBookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewsController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviews()
        {
            var reviews = await _reviewRepository.GetAllReviews();
            return Ok(reviews);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReview(int id)
        {
            var review = await _reviewRepository.GetReviewById(id);
            if (review == null)
            {
                return NotFound();
            }
            return Ok(review);
        }

        [HttpPost]
        public async Task<ActionResult> AddReview(Review review)
        {
            await _reviewRepository.AddReview(review);
            return CreatedAtAction(nameof(GetReview), new { id = review.ReviewID }, review);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReview(int id, Review review)
        {
            if (id != review.ReviewID)
            {
                return BadRequest();
            }

            await _reviewRepository.UpdateReview(review);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            await _reviewRepository.DeleteReview(id);
            return NoContent();
        }
    }
}
