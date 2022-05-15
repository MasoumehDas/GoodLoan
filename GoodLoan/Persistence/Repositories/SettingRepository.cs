using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Persistence.Repositories
{
    public class SettingRepository : ISettingRepository
    {
        private readonly RepositoryDbContext _dbContext;
        private readonly ADOConnection<Setting> _aDOConnection;

        public SettingRepository(RepositoryDbContext dbContext, ADOConnection<Setting> aDOConnection)
        {
            _dbContext = dbContext;
            _aDOConnection = aDOConnection;
        }

        public async Task<IEnumerable<Setting>> GetBySettingProcAsync(string Lang, string UserName, string Category)
        {
            SqlParameter[] parameters ={
                         
                          new SqlParameter("@Lang", SqlDbType.VarChar, 10) { Value = Lang },
                          new SqlParameter("@UserName", SqlDbType.VarChar, 20) { Value = UserName },
                          new SqlParameter("@Category", SqlDbType.VarChar, 50) { Value = Category },

                        };
            var list = await _aDOConnection.ExecutionCommand("sp_Settings_Select", parameters, new Setting());
            return list;
        }

        public void Insert(Setting Setting)
        {
            _dbContext.Settings.Add(Setting);
        }


    }
}
