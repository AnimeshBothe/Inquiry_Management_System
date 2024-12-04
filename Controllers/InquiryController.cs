using InquiryApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InquiryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InquiryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InquiryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Inquiry
        [HttpGet]
        public IActionResult GetAllInquiries()
        {
            var inquiries = _context.Inquiries.ToList();
            return Ok(inquiries);
        }

        // GET: api/Inquiry/{id}
        [HttpGet("{id}")]
        public IActionResult GetInquiry(int id)
        {
            var inquiry = _context.Inquiries.Find(id);
            if (inquiry == null)
            {
                return NotFound();
            }
            return Ok(inquiry);
        }

        // POST: api/Inquiry
        [HttpPost]
        public IActionResult CreateInquiry([FromBody] Inquiry inquiry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Inquiries.Add(inquiry);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetInquiry), new { id = inquiry.Id }, inquiry);
        }

        // PUT: api/Inquiry/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateInquiry(int id, [FromBody] Inquiry inquiry)
        {
            if (id != inquiry.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingInquiry = _context.Inquiries.Find(id);
            if (existingInquiry == null)
            {
                return NotFound();
            }

            existingInquiry.Name = inquiry.Name;
            existingInquiry.DateOfBirth = inquiry.DateOfBirth;
            existingInquiry.Gender = inquiry.Gender;
            existingInquiry.Hobbies = inquiry.Hobbies;
            existingInquiry.Address = inquiry.Address;
            existingInquiry.State = inquiry.State;
            existingInquiry.City = inquiry.City;
            existingInquiry.Pincode = inquiry.Pincode;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/Inquiry/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteInquiry(int id)
        {
            var inquiry = _context.Inquiries.Find(id);
            if (inquiry == null)
            {
                return NotFound();
            }

            _context.Inquiries.Remove(inquiry);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
