using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ISettingRepository
    {
        Task<IEnumerable<Setting>> GetBySettingProcAsync(string Lang, string UserName, string Category);
        void Insert(Entities.Setting Setting);
        
    }
}
