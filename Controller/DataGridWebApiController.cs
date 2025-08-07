using DataGridWebApi.ContextData;
using DataGridWebApi.Model;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace DataGridWebApi.Controller
{
    [Authorize]
    [ApiController]
    [Route("api/DataGridWebApi")]
    public class DataGridWebApiController: ControllerBase
    {
        private readonly InMemoryAddressContext _addressContext; 

        public DataGridWebApiController(InMemoryAddressContext addressContext) {
            _addressContext = addressContext;
        }

        [HttpGet]
        [Route("Addresses")]
        public IActionResult Addresses(string? search = null,string? sortBy = null, bool descending = false, int page = 1, int pageSize = 10)
        {
            var data = _addressContext.Items.AsQueryable();

            // Optional search across multiple fields
            if (!string.IsNullOrWhiteSpace(search))
            {
                data = data.Where(item =>
                    item.City.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    item.Country.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    item.Region.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            // Optional sorting
            if (!string.IsNullOrEmpty(sortBy))
            {
                data = sortBy.ToLower() switch
                {
                    "city" => descending ? data.OrderByDescending(x => x.City) : data.OrderBy(x => x.City),
                    "country" => descending ? data.OrderByDescending(x => x.Country) : data.OrderBy(x => x.Country),
                    "region" => descending ? data.OrderByDescending(x => x.Region) : data.OrderBy(x => x.Region),
                    _ => data
                };
            }

            // Paging
            var total = data.Count();
            var pagedData = data.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var result = new
            {
                data = pagedData,
                totalCount = total,
                page,
                pageSize
            };

            return Ok(result);
        }

        [HttpPost("InsertAddress")]
        public IActionResult InsertAddress([FromForm] string values)
        {
            var newItem = new AddressEntry();
            JsonConvert.PopulateObject(values, newItem);

            if (!TryValidateModel(newItem))
                return BadRequest(ModelState);

            _addressContext.Items.Add(newItem);
            _addressContext.SaveChanges();

            return Created("", newItem);
        }

        [HttpPut("UpdateAddress")]
        public IActionResult UpdateAddress([FromForm] int key, [FromForm] string values)
        {
            var item = _addressContext.Items.FirstOrDefault(i => i.Id == key);
            if (item == null) return NotFound();

            JsonConvert.PopulateObject(values, item);

            if (!TryValidateModel(item))
                return BadRequest(ModelState);

            _addressContext.SaveChanges();

            return Ok(item);
        }

        [HttpDelete("DeleteAddress")]
        public IActionResult DeleteAddress([FromForm] int key)
        {
            var item = _addressContext.Items.FirstOrDefault(i => i.Id == key);
            if (item == null) return NotFound();

            _addressContext.Items.Remove(item);
            _addressContext.SaveChanges();

            return NoContent();
        }

        [HttpGet("AddressDetails")]
        public IActionResult AddressDetails()
        {
            var data = _addressContext.GetAll();
            return Ok(data);
        }
    }
}
