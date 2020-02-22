using IdentityServer4.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ids4React.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ErrorController : ControllerBase
    {
        private readonly ILogger<ErrorController> _logger;
        private readonly IIdentityServerInteractionService _interaction;

        public ErrorController(ILogger<ErrorController> logger, IIdentityServerInteractionService interaction)
        {
            _logger = logger;
            _interaction = interaction;
        }

        [HttpGet]
        public async Task<string> Get(string errorId)
        {
            var message = await _interaction.GetErrorContextAsync(errorId);
            return message.Error;
        }
    }
}
