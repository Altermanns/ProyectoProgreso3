using ProyectoProgreso3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgreso3.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Usuario>().Wait();
        }

        public Task<List<Usuario>> GetVendedoresAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        public Task<int> SaveVendedorAsync(Usuario vendedor)
        {
            if (vendedor.IdUsuario != 0)
                return _database.UpdateAsync(vendedor);
            else
                return _database.InsertAsync(vendedor);
        }

        public Task<int> DeleteVendedorAsync(Usuario vendedor)
        {
            return _database.DeleteAsync(vendedor);
        }
    }
}
