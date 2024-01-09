using System.ComponentModel.DataAnnotations.Schema;

namespace CarStoreAPI.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
    }
}
