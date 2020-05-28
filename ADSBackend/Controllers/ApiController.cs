using ADSBackend.Data;
using ADSBackend.Models;
using ADSBackend.Models.ApiModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSBackend.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class ApiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Config
        [HttpGet("Config")]
        public static ConfigResponse GetConfig()
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

        // GET: api/PlaceType
        [HttpGet("PlaceType")]
        public async Task<List<Place>> GetPlaceTypes()
        {
            var placeTypes = await _context.Place.Include(p => p.PlaceType)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return placeTypes;
        }

        // GET: api/LocationName
        [HttpGet("Location")]
        public async Task<List<Place>> GetLocations()
        {
            var locations = await _context.Place.Include(p => p.Location)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return locations;
        }

        // GET: api/ActivityName
        [HttpGet("Activity")]
        public async Task<List<Place>> GetActivities()
        {
            var activities = await _context.Place.Include(p => p.Activity)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return activities;
        }

        // GET: api/ActivityDescription
        [HttpGet("Description")]
        public async Task<List<Place>> GetDescriptions()
        {
            var descriptions = await _context.Place.Include(p => p.Description)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return descriptions;
        }

        // GET: api/LocationAddress
        [HttpGet("Address")]
        public async Task<List<Place>> GetAddresses()
        {
            var addresses = await _context.Place.Include(p => p.Address)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return addresses;
        }

        // GET: api/HoursofOperation
        [HttpGet("Hours")]
        public async Task<List<Place>> GetHours()
        {
            var hours = await _context.Place.Include(p => p.Hours)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return hours;
        }

        // GET: api/ActivityCost
        [HttpGet("Cost")]
        public async Task<List<Place>> GetCosts()
        {
            var costs = await _context.Place.Include(p => p.Cost)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return costs;
        }

        // GET: api/LocationLatitude
        [HttpGet("Latitude")]
        public async Task<List<Place>> GetLatitudes()
        {
            var latitudes = await _context.Place.Include(p => p.Latitude)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return latitudes;
        }

        // GET: api/LocationLongitude
        [HttpGet("Longitude")]
        public async Task<List<Place>> GetLongitudes()
        {
            var longitudes = await _context.Place.Include(p => p.Longitude)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return longitudes;
        }

        // GET: api/LocationURL
        [HttpGet("Location URL")]
        public async Task<List<Place>> GetLocationURLs()
        {
            var locationURLs = await _context.Place.Include(p => p.URL)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return locationURLs;
        }

        // GET: api/ImageURL
        [HttpGet("Image URL")]
        public async Task<List<Place>> GetImageURLs()
        {
            var imageURLs = await _context.Place.Include(p => p.Image)
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return imageURLs;
        }
    }
}