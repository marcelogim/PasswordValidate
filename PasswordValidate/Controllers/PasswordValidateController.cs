using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PasswordValidate.Model;
using PasswordValidate.Services;

namespace PasswordValidate.Controllers
{
    [ApiController]
    [Route("passwordValidate")]
    public class PasswordValidateController : ControllerBase
    {

        private readonly ILogger<PasswordValidateController> _logger;

        public PasswordValidateController(ILogger<PasswordValidateController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<PasswordValidateResModel> Post([FromBody] PasswordValidateReqModel password)
        {
            _logger.LogInformation("Initialize request");
            return new PasswordValidateResModel
            {
                IsValid = PasswordValidateService.Validate(password.Password)
            };
            _logger.LogInformation("Finalize request");
        }
    }
}
