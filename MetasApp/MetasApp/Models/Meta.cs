using SQLite;

namespace MetasApp.Models
{
    public class Meta
    {
        [PrimaryKey, AutoIncrement]
        public int IdMeta { get; set; }
        public int IdUsuario { get; set; }
        public string NomeMeta { get; set; } = string.Empty;
        public string DescricaoMeta { get; set; } = string.Empty;
    }
}
