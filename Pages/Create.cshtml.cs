using Microsoft.AspNetCore.Mvc;
using InquiryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InquiryApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        // This binds the Inquiry model to the form input fields
        [BindProperty]
        public Inquiry Inquiry { get; set; }

        // Constructor to inject the ApplicationDbContext into the page model
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // Method to handle GET request (display the form)
        public void OnGet() { }

        // Method to handle POST request (submit the form)
        public IActionResult OnPost()
        {
            // If the model state is not valid, return the page with validation errors
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Add the Inquiry to the database
            _context.Inquiries.Add(Inquiry);

            // Save the changes to the database
            _context.SaveChanges();

            // Redirect to the List page after successful form submission
            return RedirectToPage("/List");
        }
    }
}
