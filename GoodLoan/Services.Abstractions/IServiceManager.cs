using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Abstractions
{
   public interface IServiceManager
    {
        IUserService UserService { get; }
        I_EnumsService _EnumsService { get; }
        
    }
}
