using EmailService.BussinessLayer.Dtos;
using EmailService.BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController(IEmailServices emailServices) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Send([FromBody] EmailRequest request)
        {
            try
            {
                bool response = await emailServices.SendEmailAsync(request);
                return response ? Created() : BadRequest();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message, ex);
            }
        }
    }
}
