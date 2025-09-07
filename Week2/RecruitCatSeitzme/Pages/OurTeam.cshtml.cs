using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

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