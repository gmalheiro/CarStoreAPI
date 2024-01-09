using System.ComponentModel.DataAnnotations.Schema;

namespace CarStoreAPI.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
