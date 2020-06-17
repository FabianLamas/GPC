using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MockGPC.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        Task<T> GetEmpleadoAsync(string id);
        Task<IEnumerable<T>> GetClientesAsync(bool forceRefresh = false);
        Task<T> GetClienteAsync(string id);
        Task<IEnumerable<T>> GetEmpleadosAsync(bool forceRefresh = false);
        Task<T> GetProyectoAsync(string id);
        Task<IEnumerable<T>> GetPoyectosAsync(bool forceRefresh = false);
    }
}
