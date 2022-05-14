using System;
using System.Threading;
using System.Threading.Tasks;
using Contracts.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using System.Collections.Generic;

using System.Linq;


namespace Presentation.Controllers.Users
{
    [ApiController]
    [Route("api/user/")]
    public class UserController : ControllerBase

    {
        private readonly IServiceManager _serviceManager;
        
        public UserController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        //[HttpGet]
        //public async Task<IEnumerable<_EnumsDto>> GetAllAsync(CancellationToken cancellationToken = default)
        //{
        //    var result = await _serviceManager._EnumsService.GetBy_EnumsTypeAsync("PaymentStatus");

        //    return result.ToList();
        //}
        [HttpGet]
        public async Task<IEnumerable<UserDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var result = await _serviceManager.UserService.GetAllAsync();

            return result.ToList();
        }

    }
}
