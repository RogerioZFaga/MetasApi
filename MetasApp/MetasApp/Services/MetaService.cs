using SQLite;
using MetasApp.Models;

namespace MetasApp.Services
{
    public class MetaService
    {
        private SQLiteConnection _connection;
        private static string dbPath => Path.Combine(FileSystem.AppDataDirectory, "metas.db");

        public MetaService()
        {
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<Meta>();
        }

        public List<Meta> GetAll() => _connection.Table<Meta>().ToList();

        public void Add(Meta meta) => _connection.Insert(meta);

        public void Update(Meta meta) => _connection.Update(meta);

        public void Delete(int id)
        {
            var meta = _connection.Table<Meta>().FirstOrDefault(m => m.IdMeta == id);
            if (meta != null)
                _connection.Delete(meta);
        }
    }
}
