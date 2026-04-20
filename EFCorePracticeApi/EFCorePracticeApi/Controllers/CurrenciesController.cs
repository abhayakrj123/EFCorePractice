using EFCorePracticeApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EFCorePracticeApi.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private readonly AppDBContext _appDBContext;

        public CurrenciesController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCurrencies()
        {
            try
            {
                //var currencies = _appDBContext.Currencies.ToList();
                // var currencies = (from c in _appDBContext.Currencies select c).ToList();

                //Using async-await pattern to fetch currencies from the database
                //var currencies = await (from c in _appDBContext.Currencies select c).ToListAsync();  
               var currencies = await _appDBContext.Currencies.ToListAsync();
                return Ok(currencies);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error fetching currencies: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while fetching currencies.");
            }
        }
    }
}
