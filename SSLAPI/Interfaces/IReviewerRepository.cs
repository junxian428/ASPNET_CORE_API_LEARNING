using SSLAPI.Models;

namespace SSLAPI.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewersId);
        
        ICollection<Review> GetReviewsByReviewer(int reviewersId);

        bool ReviewerExist(int reviewersId);
    }
}
