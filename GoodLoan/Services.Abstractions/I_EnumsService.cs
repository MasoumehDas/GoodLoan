using Contracts.Models;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface I_EnumsService
    {
        Task<IList<_EnumsDto>> GetBy_EnumsTypeAsync(string _EnumsType);
    }
}
