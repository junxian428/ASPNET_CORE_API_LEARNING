using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SSLAPI.Data;
using SSLAPI.Interfaces;
using SSLAPI.Models;

namespace SSLAPI.Repository
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly DataContext _context;

        private readonly IMapper _mapper;
        public ReviewerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }

        public Reviewer GetReviewer(int reviewersId)
        {
            return _context.Reviewers.Where(r => r.Id == reviewersId).Include(e => e.Reviews ).FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public ICollection<Review> GetReviewsByReviewer(int reviewersId)
        {
            return _context.Reviews.Where(r => r.Reviewer.Id == reviewersId).ToList();
        }

        public bool ReviewerExist(int reviewersId)
        {
            return _context.Reviewers.Any(r => r.Id == reviewersId);
        }

    }
}
