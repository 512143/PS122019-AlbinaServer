using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bor.DataAccess.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bor.Core.Models;
using Albina.BusinesLogic.Core.Interfaces;
using AutoMapper;

namespace Bor_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("/auth")]
        public async Task<ActionResult<UserInformationDto>> Auth([FromBody] UserIdentityDto userIdentityDto)
        {
            _userService.Auth();
        }
    }
}
