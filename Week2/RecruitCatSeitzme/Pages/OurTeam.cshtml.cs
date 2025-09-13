using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecruitCatSeitzme.Pages
{
    public class OurTeam : PageModel
    {
        private readonly ILogger<OurTeam> _logger;

        public OurTeam(ILogger<OurTeam> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}