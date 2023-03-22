using EntityFrameworkCore.EncryptColumn.Attribute;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EncryptionEF
{
    public class User
    {
        [JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [EncryptColumn]
        public string Firstname { get; set; }
        [EncryptColumn]
        public string Lastname { get; set; }
        [EncryptColumn]
        public string Email { get; set; }
    }
}
