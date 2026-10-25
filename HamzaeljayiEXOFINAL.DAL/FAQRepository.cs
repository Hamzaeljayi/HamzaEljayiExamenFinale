using HamzaeljayiEXOFINAL.DAL;
using HamzaeljayiEXOFINAL.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQManager.DAL
{
    public class FAQRepository
    {
        private readonly FAQContext _context;

        public FAQRepository()
        {
            _context = new FAQContext();
            _context.Database.EnsureCreated();
        }

        // CREATE
        public void Add(FAQItem faq)
        {
            _context.FAQItems.Add(faq);
            _context.SaveChanges();
        }

        // READ - All
        public List<FAQItem> GetAll()
        {
            return _context.FAQItems
                .Where(f => f.IsActive)
                .ToList();
        }

        // READ - By Id
        public FAQItem GetById(int id)
        {
            return _context.FAQItems
            .FirstOrDefault(f => f.Id == id && f.IsActive);

        }

        // READ - Search
        public List<FAQItem> Search(string keyword)
        {
            return _context.FAQItems
                .Where(f => f.IsActive &&
                      (f.Question.Contains(keyword) ||
                       f.Answer.Contains(keyword)))
                .ToList();
        }

        // READ - By Category
        public List<FAQItem> GetByCategory(string category)
        {
            return _context.FAQItems
                .Where(f => f.IsActive && f.Category == category)
                .ToList();
        }

        // UPDATE
        public void Update(FAQItem faq)
        {
            _context.FAQItems.Update(faq);
            _context.SaveChanges();
        }

        // DELETE (Soft Delete)
        public void Delete(int id)
        {
            var faq = GetById(id);
            if (faq != null)
            {
                faq.IsActive = false;
                _context.SaveChanges();
            }
        }

        // Get Categories
        public List<string> GetCategories()
        {
            return _context.FAQItems
                .Where(f => f.IsActive && f.Category != null)
                .Select(f => f.Category)
                .Distinct()
                .ToList();
        }
    }
}
