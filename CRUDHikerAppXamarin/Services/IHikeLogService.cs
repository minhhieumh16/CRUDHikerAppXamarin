using CRUDHikerAppXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDHikerAppXamarin.Services
{
    public interface IHikeLogService
    {
        Task<List<HikeLog>> GetHikeLogsList();

        Task<int> AddHikeLog(HikeLog hikeLog);
        Task<int> DeleteHikeLog(HikeLog hikeLog);
        Task<int> UpdateHikeLog(HikeLog hikeLog);
    }
}
