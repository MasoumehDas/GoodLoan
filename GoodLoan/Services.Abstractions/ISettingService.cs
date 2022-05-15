using Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
   public interface ISettingService
    {
        Task<List<SettingDto>> GetBySettingProcAsync(string Lang, string UserName, string Category);
    }
}
