using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimGearGarage.Pages
{
    public class CategoryModel : PageModel
    {
        public string CategoryName { get; set; } = "";

        public void OnGet(string id)
        {
            CategoryName = id;
        }
    }
}
