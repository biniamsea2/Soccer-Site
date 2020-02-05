using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SoccerApp
{
    public class HighlightsModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "View Highlights of the most recent soccer matches!";
        }
    }
}