using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SoccerApp.Pages
{
    public class MatchesModel : PageModel
    {
        private readonly ILogger<MatchesModel> _logger;
        public string Message { get; set; }

        public MatchesModel(ILogger<MatchesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message = "*Only Premier matches in February shown above";
        }
    }
}
