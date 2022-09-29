using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIS341_Lab03.Pages
{
    public class ContactModel : PageModel
    {
        public void OnGet()
        {
        }
        //public void OnPost()
        //{
        //    var name = Request.Form["name"];
        //    var emailAddress = Request.Form["EmailAddress"];
        //    var message = Request.Form["message"];
        //}
        [BindProperty]
        public ContactModel ContactForm { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            System.Diagnostics.Debug.WriteLine(ContactForm.Message);

            return RedirectToPage("./Index");
        }
    }
}
