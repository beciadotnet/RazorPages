using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Models;

namespace RazorPagesUI.Pages.Forms
{
    public class AddAddressModel : PageModel
    {
        [BindProperty]
        public AddressModel Address { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
			return ModelState.IsValid == false ? Page() : RedirectToPage("/Index", new {Address.City});
		}

		
	}
}
