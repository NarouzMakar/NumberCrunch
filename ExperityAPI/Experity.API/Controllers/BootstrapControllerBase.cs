using Experity.API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootstrapControllerBase : ControllerBase
    {
        private JsonUtility _jsonUtility;
        protected JsonUtility JsonUtility => _jsonUtility ??= new JsonUtility();
    }
}
