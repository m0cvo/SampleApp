using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //We will need the string Message to interact with the form on the index page
        public string Message { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        
        //This is the function that is enabled by the form in the Index page (index.cshtml)
        public void OnPostRegister(string email)
        {
            Message = $"You registered {email} for newsletter updates. ";
        }
    }
}