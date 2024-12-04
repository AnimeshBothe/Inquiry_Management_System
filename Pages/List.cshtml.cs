using InquiryApp.Models;
using InquiryApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InquiryApp.Pages
{  // Ensure this matches the namespace in @model
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Inquiry> Inquiries { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; } = 5;

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(int currentPage = 1, int pageSize = 5)
        {
            PageSize = pageSize;
            CurrentPage = currentPage;

            var totalInquiries = _context.Inquiries.Count();
            TotalPages = (int)Math.Ceiling(totalInquiries / (double)PageSize);

            Inquiries = _context.Inquiries
                .OrderBy(i => i.Id)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
        }
    }
}

