using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CipherTest.Pages
{

    public class ErrorModel : PageModel
    {
        private readonly ILogger<ErrorModel> _logger;

        public string Message { get; set; }

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message = "An error occurred while processing your request.";
            _logger.LogError(Message);
        }
    }
}
