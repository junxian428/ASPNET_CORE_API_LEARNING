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

        public bool CreateReviewer(Reviewer reviewer)
        {
            _context.Add(reviewer);
            return Save();
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

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateReviewer(Reviewer reviewer)
        {
            
            _context.Update(reviewer);
            return Save();
        }
    }
}
