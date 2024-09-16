using SQLite;
using EjercicioCRUDMvvm.Models;


namespace EjercicioCRUDMvvm.Services
{
    public class ProveedorService
    {
        private SQLiteAsyncConnection _db;

        public async Task Init()
        {
            if (_db != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "Proveedores.db");
            _db = new SQLiteAsyncConnection(databasePath);
            await _db.CreateTableAsync<Proveedor>();
        }

        public async Task<int> AddProveedor(Proveedor proveedor)
        {
            await Init();
            return await _db.InsertAsync(proveedor);
        }

        public async Task<List<Proveedor>> GetProveedores()
        {
            await Init();
            return await _db.Table<Proveedor>().ToListAsync();
        }

        public async Task<int> UpdateProveedor(Proveedor proveedor)
        {
            await Init();
            return await _db.UpdateAsync(proveedor);
        }

        public async Task<int> DeleteProveedor(Proveedor proveedor)
        {
            await Init();
            return await _db.DeleteAsync(proveedor);
        }
    }
}

