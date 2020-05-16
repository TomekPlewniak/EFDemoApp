using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDataAccessLibrary.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EFDemoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PepoleContext _db;

        public IndexModel(ILogger<IndexModel> logger, PepoleContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {

        }

        private void LoadSampleData()
        {

        }
    }
}
