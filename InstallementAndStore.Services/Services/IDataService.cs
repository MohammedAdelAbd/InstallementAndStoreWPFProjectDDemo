using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallementAndStore.Services.Services
{
    public interface IDataService<Table> where Table : class
    {
        //Read

        Task<List<Table>> GetAllDataAsync();
        Task<List<Table>> SearchDataAsync(string Item);
        Task< Table> FindAsync(int Id);

        //Write

        Task<bool> AddDataAsync(Table table);
        Task<bool> EditDataAsync(Table table);
        Task<bool> DeleteAsync(int Id);
    }
}
