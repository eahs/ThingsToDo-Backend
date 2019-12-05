using ADSBackend.Data;
using ADSBackend.Models;
using ADSBackend.Models.ApiModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSBackend.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class ApiController : Controller
    {
        private readonly Services.Configuration Configuration;
        private readonly Services.Cache _cache;
        private readonly ApplicationDbContext _context;

        public ApiController(Services.Configuration configuration, Services.Cache cache, ApplicationDbContext context)
        {
            Configuration = configuration;
            _cache = cache;
            _context = context;
        }

        // GET: api/Config
        [HttpGet("Config")]
        public ConfigResponse GetConfig()
        {
            // TODO: extend this object to include some configuration items
            return new ConfigResponse();
        }

        // GET: api/Place
        [HttpGet("Place")]
        public async Task<Place> GetPlace(int id)
        {

            var place = await _context.Place.Where(p => p.PlaceTypeId == id)
                                            .Include(p => p.PlaceType)
                                            .OrderBy(x => x.PlaceId)
                                            .FirstOrDefaultAsync();

            return place;
        }

        // GET: api/Places
        [HttpGet("Places")]
        public async Task<List<Place>> GetPlaces()
        {            
            var places = await _context.Place.Include(p => p.PlaceType)
                                            .OrderBy(x => x.PlaceId)
                                            .ToListAsync();

            foreach (var place in places)
            {
                place.PlaceType.Places = null;
            }

            return places;
        }
    }
}