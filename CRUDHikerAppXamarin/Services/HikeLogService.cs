using CRUDHikerAppXamarin.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDHikerAppXamarin.Services
{
    public class HikeLogService : IHikeLogService
    {
        public SQLiteAsyncConnection _dbconnection;
        /*public HikeLogService() {
            SetupDatabase();
        }*/

        private async Task SetupDatabase() //setup database
        {
            if (_dbconnection == null)
            {
                string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HikeLog.db3");
                _dbconnection = new SQLiteAsyncConnection(dbpath);
                await _dbconnection.CreateTableAsync<HikeLog>();
            }
        }

        //add event
        public async Task<int> AddHikeLog(HikeLog hikeLog)
        {
            await SetupDatabase();
            return await _dbconnection.InsertAsync(hikeLog);
        }

        //delete event
        public async Task<int> DeleteHikeLog(HikeLog hikeLog)
        {
            await SetupDatabase();
            return await _dbconnection.DeleteAsync(hikeLog);
        }

        //get all list
        public async Task<List<HikeLog>> GetHikeLogsList()
        {
            await SetupDatabase();
            var hikeLogsList = await _dbconnection.Table<HikeLog>().ToListAsync();
            return hikeLogsList;
        }

        //update event
        public async Task<int> UpdateHikeLog(HikeLog hikeLog)
        {
            await SetupDatabase();
            return await _dbconnection.UpdateAsync(hikeLog);

        }
    }
}
