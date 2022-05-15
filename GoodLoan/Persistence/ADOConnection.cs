using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    
    public sealed class ADOConnection<U> where U : class
    {
        private readonly string _connectionString = "";

        public ADOConnection(string connectionString) => _connectionString = connectionString;
        public async Task<List<U>> ExecutionCommand(string StoredProcedureName,SqlParameter[] sqlParameter,U TDestination)
        {
            List<U> lstU = new List<U>();
            DataReaderMapper<U> dataReaderMapper = new DataReaderMapper<U>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(StoredProcedureName, con);
                await con.OpenAsync();
                
                cmd.CommandType = CommandType.StoredProcedure;
                if(sqlParameter.Length>0)
                {
                    cmd.Parameters.AddRange(sqlParameter);
                }
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();   
                da.Fill(ds, "newtbale");
                

                if (ds.Tables.Count>0)
                {
                   
                     DataTable dataTable = ds.Tables[0];

                    //-------Convert to class from DataTable---------------------
                    lstU = dataReaderMapper.MapProp(dataTable, TDestination);

                }

                await con.CloseAsync();
            }
            return lstU;
        }
    }
}
