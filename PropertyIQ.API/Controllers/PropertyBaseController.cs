using Microsoft.AspNetCore.Mvc;
using PropertyIQ.ServiceAbstractions.Services;

namespace PropertyIQ.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PropertyBaseController : ControllerBase
    {
        
        private readonly IPropertyService _propertyService;
        private readonly ILogger<IPropertyService> _logger;

        public PropertyBaseController(IPropertyService propertyService, ILogger<IPropertyService> logger)
        {
            _propertyService = propertyService;
            _logger = logger;
        }

        [HttpGet, Route("/property/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var property = await _propertyService.GetById(id);
                return Ok(property);
            }

            catch (Exception ex)
            {
                return Problem($"{ex}");
            }
        }
    }
}
