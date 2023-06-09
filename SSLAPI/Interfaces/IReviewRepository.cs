﻿using SSLAPI.Models;

namespace SSLAPI.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();

        Review GetReview(int reviewId);

        ICollection<Review> GetReviewsOfAPokemon(int pokeId);

        bool ReviewExists(int reviewId);

        //
        bool CreatedReview(Review review);

        bool Save();

        // 

        bool UpdateReview(Review review);

        /// For Pokemon Delete
        bool DeleteReview(Review review);

        bool DeleteReviews(List<Review> reviews);



    }
}
