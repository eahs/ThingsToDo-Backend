using ADSBackend.Data;
using ADSBackend.Models.Identity;
using ADSBackend.Models.PlaceViewModels;
using ADSBackend.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace ADSBackend.Controllers
{
    [Authorize]
    public class PlaceController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly Services.Configuration Configuration;

        public PlaceController(ApplicationDbContext context, Services.Configuration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            var viewModel = new PlaceViewModel
            {
                Name = Configuration.Get("Place Name"),
                Location = Configuration.Get("Location Name"),
            };

            return View(viewModel);
        }
    }
}
