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

        // GET: api/Places/Type
        [HttpGet("PlaceType")]
        public async Task<List<Place>> GetPlaceTypes()
        {
            var placeTypes = await _context.Place.PlaceType
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return placeTypes;
        }

        // GET: api/Places/LocationName
        [HttpGet("Location")]
        public async Task<List<Place>> GetLocations()
        {
            var locations = await _context.Place.Location
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return locations;
        }

        // GET: api/Places/ActivityName
        [HttpGet("Activity")]
        public async Task<List<Place>> GetActivities()
        {
            var activities = await _context.Place.Activity
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return activities;
        }

        // GET: api/Places/ActivityDescription
        [HttpGet("Description")]
        public async Task<List<Place>> GetDescriptions()
        {
            var descriptions = await _context.Place.Description
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return descriptions;
        }

        // GET: api/Places/LocationAddress
        [HttpGet("Address")]
        public async Task<List<Place>> GetAddresses()
        {
            var addresses = await _context.Place.Address
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return placeTypes;
        }

        // GET: api/Places/HoursofOperation
        [HttpGet("Hours")]
        public async Task<List<Place>> GetHours()
        {
            var hours = await _context.Place.Hours
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return hours;
        }

        // GET: api/Places/ActivityCost
        [HttpGet("Cost")]
        public async Task<List<Place>> GetCosts()
        {
            var costs = await _context.Place.Cost
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return costs;
        }

        // GET: api/Places/LocationLatitude
        [HttpGet("Latitude")]
        public async Task<List<Place>> GetLatitudes()
        {
            var latitudes = await _context.Place.Latitude
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return latitudes;
        }

        // GET: api/Places/LocationLongitude
        [HttpGet("Longitude")]
        public async Task<List<Place>> GetLongitudes()
        {
            var longitudes = await _context.Place.Longitude
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return longitudes;
        }

        // GET: api/Places/LocationURL
        [HttpGet("Location URL")]
        public async Task<List<Place>> GetLocationURLs()
        {
            var locationURLs = await _context.Place.LocationURL
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return locationURLs;
        }

        // GET: api/Places/ImageURL
        [HttpGet("Image URL")]
        public async Task<List<Place>> GetImageURLs()
        {
            var imageURLs = await _context.Place.ImageURL
                                                .OrderBy(x => x.PlaceId)
                                                .ToListAsync();

            return imageURLs;
        }
    }
}