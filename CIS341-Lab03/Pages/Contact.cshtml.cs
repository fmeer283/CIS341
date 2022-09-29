using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIS341_Lab03.Pages
{
    public class ContactModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            var name = Request.Form["name"];
            var emailAddress = Request.Form["EmailAddress"];
            var message = Request.Form["message"];
            // do something with emailAddress
        }
    }
}
