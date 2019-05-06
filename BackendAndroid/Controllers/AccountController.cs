using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendAndroid.BLL.Abstraction;
using BackendAndroid.BLL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendAndroid.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[ApiController]
    public class AccountController : ControllerBase
    {
        readonly IFileService _fileService;
        public AccountController(IFileService fileService)
        {
            _fileService = fileService;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]Credentials credentials)
        {
            return Ok();
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]RegisterViewModel model)
        {
            string path = _fileService.UploadImage(model.Image);
            return Ok();
        }

    }
}