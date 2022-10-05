using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIS341_Lab03.Pages.About
{
    public class ThanksModel : PageModel
    {
        private readonly LinkGenerator _linkGenerator;
        public string contactPath { get; set; }
        public ThanksModel(LinkGenerator linkGenerator)
        {
            _linkGenerator = linkGenerator;
            contactPath = _linkGenerator.GetPathByPage("/About/Contact");
        }
        public void OnGet()
        {
        }
    }
}
